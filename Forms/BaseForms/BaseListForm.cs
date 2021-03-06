using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show.Interfaces;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using DevExpress.Utils.Extensions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.Forms.FiltreForms;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.GenelForms;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;
using OgrenciTakip.Common.Messages;
using System.Drawing;
using OgrenciTakip.UI.Win.UserControls.Grids;

namespace OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : RibbonForm
    {
        #region Variables

        private long _filtreId;
        private bool formSablonKayitEdilecek;
        private bool tabloSablonKayitEdilecek;
        protected IBaseFormShow FormShow;
        protected KartTuru BaseKartTuru;
        protected bool AktifKartlariGoster = true;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal bool AktifPasifButtonGoster = false;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected internal GridView Tablo;
        protected internal long? SeciliGelecekId;
        protected internal IList<long> ListeDisiTutulacakKayitlar;
        protected internal SelectRowFunctions RowSelect;
        protected internal bool EklenebilecekEntityVar = false;
        protected internal IList<BaseEntity> SelectedEntities;
        #endregion

        public BaseListForm()
        {
            InitializeComponent();
        }

        #region Functions

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;

                //switch (item)
                //{
                //    case BarItem button:
                //        button.ItemClick += Button_ItemClick;
                //        break;
                //}
            }

            //Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
            Tablo.EndSorting += Tablo_EndSorting;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;
            Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell;
            Tablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
            Tablo.RowDeleted += Tablo_RowDeleted;

            //Form Events
            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            FormClosing += BaseListForm_FormClosing;
            SizeChanged += BaseListForm_SizeChanged;
            LocationChanged += BaseListForm_LocationChanged;
        }

        private void ButtonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButtonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barSec.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barSecAciklama.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButtonGoster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            //foreach (BarItem item in ShowItems)
            //{
            //    item.Visibility = BarItemVisibility.Always;
            //}

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);


        }

        protected virtual void SutunGizleGoster() { }

        private void SablonKaydet()
        {
            if (formSablonKayitEdilecek)
            {
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            }

            if (tabloSablonKayitEdilecek)
            {
                Tablo.TabloSablonKaydet(IsMdiChild ? Name + " Tablosu" : Name + " TablosuMDI");
            }
        }

        private void SablonYukle()
        {
            if (IsMdiChild)
            {
                Tablo.TabloSablonYukle(Name + " Tablosu");
            }
            else
            {
                Name.FormSablonYukle(this);
                Tablo.TabloSablonYukle(Name + " TablosuMDI");
            }
        }

        private void FormCaptionAyarla()
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }

            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";
            }

            Listele();
        }

        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //btnSec butonu gözükmüyorsa btnDuzelt butonuna tıklanmış gibi işlem yap. gözüküyorsa entityselect
                if (btnSec.Visibility == BarItemVisibility.Never)
                {
                    btnDuzelt.PerformClick();
                }
                else
                {
                    EntitySelect();
                }
            }
            else
            {
                btnDuzelt.PerformClick();
            }
        }

        protected virtual void EntitySelect()
        {
            if (MultiSelect)
            {
                SelectedEntities = new List<BaseEntity>();
                if (RowSelect.SelectedRowCount == 0)
                {
                    Messages.KartSecmemeUyariMesaji();
                    return;
                }

                SelectedEntities = RowSelect.GetSelectedRows();
            }
            else
            {
                SelectedEntity = Tablo.GetRow<BaseEntity>();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FiltreSec()
        {
            if (!KartTuru.Filtre.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var entity = (Filtre)ShowListForms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);

            if (entity == null) return;

            _filtreId = entity.Id;
            Tablo.ActiveFilterString = entity.FiltreMetni;
        }

        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;

            AktifKartlariGoster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);
        }

        protected virtual void DegiskenleriDoldur() { }

        protected virtual void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(BaseKartTuru, id);
            ShowEditFormDefault(result);
        }

        protected virtual void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();

            if (entity == null) return;

            if (!((IBaseCommonBll)Bll).Delete(entity)) return;

            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }

        protected virtual void Listele() { }

        protected virtual void Yazdir()
        {
            TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);
        }

        protected virtual void BaskiOnizleme() { }

        protected virtual void BagliKartAc() { }

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

            Tablo.Appearance.ViewCaption.ForeColor = Color.FromArgb(AnaForm.KullaniciParametreleri.TableViewCaptionForeColor);
            Tablo.Appearance.HeaderPanel.ForeColor = Color.FromArgb(AnaForm.KullaniciParametreleri.TableColumnHeaderForeColor);

            if (Tablo is MyBandedGridView bandedGrid)
            {
                bandedGrid.Appearance.BandPanel.ForeColor = Color.FromArgb(AnaForm.KullaniciParametreleri.TableBandPanelForeColor);
            }
        }

        protected virtual void TahakkukYap() { }
        protected virtual void BelgeHareketleri() { }
        protected virtual void Duzelt() { }

        #endregion

        #region Events

        protected virtual void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcellDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.ExcellStandart, e.Item.Caption, Text);
            }
            else if (e.Item == btnFormatliExcellDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.ExcellFormatli, e.Item.Caption, Text);
            }
            else if (e.Item == btnFormatsizExcellDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.ExcellFormatsiz, e.Item.Caption, Text);
            }
            else if (e.Item == btnWordDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnPdfDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnTxtDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnYeni)
            {
                if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir)) return;
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
            {
                ShowEditForm(Tablo.GetRowId());
            }
            else if (e.Item == btnSil)
            {
                if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Silebilir)) return;
                EntityDelete();
            }
            else if (e.Item == btnSec)
            {
                EntitySelect();
            }
            else if (e.Item == btnYenile)
            {
                Listele();
            }
            else if (e.Item == btnFiltrele)
            {
                FiltreSec();
            }
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }
            else if (e.Item == btnTahakkukYap)
            {
                TahakkukYap();
            }
            else if (e.Item == btnBelgeHareketleri)
            {
                BelgeHareketleri();
            }
            else if (e.Item == btnBagliKartlar)
            {
                BagliKartAc();
            }
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnTabloYazdir)
            {
                TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);
            }
            else if (e.Item == btnBaskiOnizleme)
            {
                BaskiOnizleme();
            }
            else if (e.Item == btnTasarimDegistir)
            {
                Duzelt();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
            else if (e.Item == btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();
            }
            else if (e.Item == btnParametreler)
            {
                BagliKartAc();
            }

            Cursor.Current = DefaultCursor;
        }
        private void Tablo_DoubleClick(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            tabloSablonKayitEdilecek = true;
        }

        private void Tablo_ColumnPositionChanged(object sender, System.EventArgs e)
        {
            tabloSablonKayitEdilecek = true;
        }

        private void Tablo_EndSorting(object sender, System.EventArgs e)
        {
            tabloSablonKayitEdilecek = true;
        }

        private void Tablo_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            if (!KartTuru.Filtre.YetkiKontrolu(YetkiTuru.Degistirebilir)) return;

            e.ShowFilterEditor = false;
            ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);
        }

        //Tablo kolonundaki filtreden bir filtre seçersek o filtreyi yeni filtre olarak kaydetmemizi sağlar.
        private void Tablo_ColumnFilterChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
            {
                _filtreId = 0;
            }
        }

        private void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Tablo.OptionsView.ShowFooter) return;

            if (e.Column.Summary.Count > 0 && e.Column.ColumnEdit != null)
            {
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
            }
        }

        private void Tablo_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            SutunGizleGoster();
        }

        private void Tablo_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            SutunGizleGoster();
        }

        private void BaseListForm_Shown(object sender, System.EventArgs e)
        {
            Tablo.Focus();
            ButtonGizleGoster();
            SutunGizleGoster();

            if (IsMdiChild || SeciliGelecekId == null) return;

            Tablo.RowFocus("Id", SeciliGelecekId);
        }

        private void BaseListForm_Load(object sender, System.EventArgs e)
        {
            SablonYukle();
        }

        private void BaseListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        private void BaseListForm_SizeChanged(object sender, System.EventArgs e)
        {
            if (!IsMdiChild)
            {
                formSablonKayitEdilecek = true;
            }
        }

        private void BaseListForm_LocationChanged(object sender, System.EventArgs e)
        {
            if (!IsMdiChild)
            {
                formSablonKayitEdilecek = true;
            }
        }

        #endregion
    }
}