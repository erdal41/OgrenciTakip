using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.FiltreForms;
using OgrenciTakip.UI.Win.Forms.RaporForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Reports.FormReports.Base
{
    public partial class BaseRapor : RibbonForm
    {
        #region Variables

        private long _filtreId;
        private long _raporSablonId;
        private RaporBolumTuru _raporBolumTuru = RaporBolumTuru.GenelRaporlar;
        protected KartTuru RaporTuru;
        protected ControlNavigator Navigator;
        protected internal GridView Tablo;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected MyCheckedComboboxEdit Subeler;
        protected MyCheckedComboboxEdit Hizmetler;
        protected MyCheckedComboboxEdit Indirimler;
        protected MyCheckedComboboxEdit Odemeler;
        protected MyCheckedComboboxEdit KayitSekilleri;
        protected MyCheckedComboboxEdit KayitDurumlari;
        protected MyCheckedComboboxEdit IptalDurumlari;
        protected MyCheckedComboboxEdit BelgeDurumlari;
        protected MyComboboxEdit HizmetAlimTuru;
        protected MyComboboxEdit HesaplamaSekli;
        protected MyDataLayoutControl DataLayoutControl;
        protected DateEdit IlkTarih, SonTarih;

        #endregion

        public BaseRapor()
        {
            InitializeComponent();
        }

        #region Functions

        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Navigator.NavigatableControl = Tablo.GridControl;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }


        protected virtual void DegiskenleriDoldur() { }

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }

            //Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Control_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell;
            Tablo.CustomDrawRowFooterCell += Tablo_CustomDrawRowFooterCell;
            Tablo.CustomSummaryCalculate += Tablo_CustomSummaryCalculate;
            Tablo.MasterRowGetRelationCount += Tablo_MasterRowGetRelationCount;
            Tablo.MasterRowGetRelationName += Tablo_MasterRowGetRelationName;
            Tablo.MasterRowGetChildList += Tablo_MasterRowGetChildList;

            //Form Events
            FormClosing += BaseRapor_FormClosing;

            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;

                if (control is SimpleButton btn)
                {
                    btn.Click += Control_Click;
                }
            }

            //DataLayoutControl içindeki button vb. her nesneyi dolaşarak bunlara klavye kısayolu ekler.
            foreach (Control ctrl in DataLayoutControl.Controls)
            {
                ControlEvents(ctrl);
            }
        }

        protected void SubeKartlariYukle()
        {
            using (var bll = new SubeBll())
            {
                var entities = bll.List(x => AnaForm.YetkiliOlunanSubeler.Contains(x.Id));

                foreach (SubeList entity in entities)
                {
                    var item = new CheckedListBoxItem
                    {
                        CheckState = entity.Id == AnaForm.SubeId ? CheckState.Checked : CheckState.Unchecked,
                        Description = entity.SubeAdi,
                        Value = entity.Id,
                    };

                    Subeler.Properties.Items.Add(item);
                }
            }
        }

        protected void KayitSekliYukle()
        {
            var enums = Enum.GetValues(typeof(KayitSekli));

            foreach (KayitSekli enm in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = enm.ToName(),
                    Value = enm,
                };

                KayitSekilleri.Properties.Items.Add(item);
            }
        }

        protected void KayitDurumuYukle()
        {
            var enums = Enum.GetValues(typeof(KayitDurumu));

            foreach (KayitDurumu enm in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = enm == KayitDurumu.KesinKayit ? CheckState.Checked : CheckState.Unchecked,
                    Description = enm.ToName(),
                    Value = enm,
                };

                KayitDurumlari.Properties.Items.Add(item);
            }
        }

        protected void IptalDurumuYukle()
        {
            var enums = Enum.GetValues(typeof(IptalDurumu));

            foreach (IptalDurumu enm in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = enm.ToName(),
                    Value = enm,
                };

                IptalDurumlari.Properties.Items.Add(item);
            }
        }

        protected void HizmetKartlariYukle()
        {
            using (var bll = new HizmetBll())
            {
                var entities = bll.List(null);

                foreach (HizmetList entity in entities)
                {
                    var item = new CheckedListBoxItem
                    {
                        CheckState = CheckState.Checked,
                        Description = entity.HizmetAdi,
                        Value = entity.Id,
                    };

                    Hizmetler.Properties.Items.Add(item);
                }
            }
        }

        protected void IndirimKartlariYukle()
        {
            using (var bll = new IndirimBll())
            {
                var entities = bll.List(null);

                foreach (IndirimList entity in entities)
                {
                    var item = new CheckedListBoxItem
                    {
                        CheckState = CheckState.Checked,
                        Description = entity.IndirimAdi,
                        Value = entity.Id,
                    };

                    Indirimler.Properties.Items.Add(item);
                }
            }
        }

        protected void OdemeTurleriYukle()
        {
            var enums = Enum.GetValues(typeof(OdemeTipi));

            foreach (OdemeTipi enm in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = enm.ToName(),
                    Value = enm,
                };

                Odemeler.Properties.Items.Add(item);
            }
        }

        protected virtual void BelgeDurumlariYukle()
        {
            var enums = Enum.GetValues(typeof(BelgeDurumu));

            foreach (BelgeDurumu enm in enums)
            {
                var item = new CheckedListBoxItem
                {
                    CheckState = CheckState.Checked,
                    Description = enm.ToName(),
                    Value = enm,
                };

                BelgeDurumlari.Properties.Items.Add(item);
            }
        }

        private void RaporSablonSec()
        {
            var entity = (RaporList)ShowListForms<RaporListForm>.ShowDialogListForm(KartTuru.Rapor, _raporSablonId, RaporTuru, _raporBolumTuru, SablonDosyasiOlustur());

            if (entity == null) return;

            _raporSablonId = entity.Id;

            using (var bll = new RaporBll())
            {
                var stream = ((Rapor)bll.Single(x => x.Id == entity.Id)).Dosya.ByteToStream();
                Tablo.RestoreLayoutFromStream(stream);
                Tablo.Focus();
            }
        }

        private byte[] SablonDosyasiOlustur()
        {
            var stream = new MemoryStream();
            Tablo.SaveLayoutToStream(stream);
            return stream.GetBuffer();
        }

        private void FiltreSec()
        {
            var entity = (Filtre)ShowListForms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, RaporTuru, Tablo.GridControl);

            if (entity == null) return;

            _filtreId = entity.Id;
            Tablo.ActiveFilterString = entity.FiltreMetni;
        }

        protected virtual void Listele()
        {
            Tablo.ExpandAllGroups();
        }

        protected virtual void ShowEditForm() { }

        protected virtual void BelgeHareketleri() { }

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
            else if (e.Item == btnRaporSablonlari)
            {
                RaporSablonSec();
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
            else if (e.Item == btnYazdir)
            {
                switch (RaporTuru)
                {
                    //ComboboxEdit yoksa bu şekilde çıktı alıyoruz
                    case KartTuru.GenelAmacliRapor:
                    case KartTuru.SinifRaporlari:
                    case KartTuru.UcretVeOdemeRaporu:
                    case KartTuru.MesleklereGoreKayitRaporu:
                    case KartTuru.AylikKayitRaporu:
                    case KartTuru.UcretOrtalamalariRaporu:
                    case KartTuru.OdemeBelgeleriRaporu:
                        TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, Subeler.Text, KayitSekilleri.Text, KayitDurumlari.Text, IptalDurumlari.Text);
                        break;

                    //ComboboxEdit varsa adetine göre parametreli gönderiyoruz
                    case KartTuru.HizmetAlimRaporu:
                        TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, Subeler.Text, KayitSekilleri.Text, KayitDurumlari.Text, null, "Hizmet Türü", Hizmetler.Text, "Hizmet Alım Türü", HizmetAlimTuru.Text);
                        break;
                    case KartTuru.NetUcretRaporu:
                        TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, Subeler.Text, KayitSekilleri.Text, KayitDurumlari.Text, IptalDurumlari.Text, "Hizmet Türü", Hizmetler.Text);
                        break;
                    case KartTuru.IndirimDagilimRaporu:
                        TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, Subeler.Text, KayitSekilleri.Text, KayitDurumlari.Text, IptalDurumlari.Text, "İndirim Türü", Indirimler.Text);
                        break;
                    case KartTuru.GelirDagilimRaporu:
                        TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, Subeler.Text, KayitSekilleri.Text, KayitDurumlari.Text, IptalDurumlari.Text, "Hesaplama Şekli", HesaplamaSekli.Text);
                        break;
                    case KartTuru.TahsilatRaporu:
                    case KartTuru.OdemesiGecikenAlacaklarRaporu:
                        TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, Subeler.Text, KayitSekilleri.Text, KayitDurumlari.Text, IptalDurumlari.Text, "Tarih Aralığı", $"{IlkTarih.Text} - {SonTarih.Text}");
                        break;
                }
            }
            else if (e.Item == btnKartAc)
            {
                ShowEditForm();
            }
            else if (e.Item == btnGruplamaPaneli)
            {
                Tablo.OptionsView.ShowGroupPanel = !Tablo.OptionsView.ShowGroupPanel;
            }
            else if (e.Item == btnTumGruplariGenislet)
            {
                Tablo.ExpandAllGroups();
            }
            else if (e.Item == btnTumGruplariDaralt)
            {
                Tablo.CollapseAllGroups();
            }
            else if (e.Item == btnTumDetaylariGenislet)
            {
                for (int i = 0; i < Tablo.DataRowCount; i++)
                {
                    Tablo.SetMasterRowExpanded(i, true);
                }
            }
            else if (e.Item == btnTumDetaylariDaralt)
            {
                Tablo.CollapseAllDetails();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
            else if (e.Item == btnBelgeHareketleri)
            {
                BelgeHareketleri();
            }

            Cursor.Current = DefaultCursor;
        }

        private void Tablo_DoubleClick(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ShowEditForm();
            Cursor.Current = DefaultCursor;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F7:
                    Subeler.Focus();
                    break;
            }
        }

        private void BaseRapor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AnaForm.KullaniciParametreleri.RaporlariOnayAlmadanKapat)
            {
                if (Messages.RaporuKapatmaMesaji() != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            btnKartAc.Enabled = Tablo.DataRowCount > 0;
            btnTumGruplariGenislet.Enabled = Tablo.DataRowCount > 0;
            btnTumGruplariDaralt.Enabled = Tablo.DataRowCount > 0;
            btnTumDetaylariGenislet.Enabled = Tablo.DataRowCount > 0;
            btnTumDetaylariDaralt.Enabled = Tablo.DataRowCount > 0;
            btnBelgeHareketleri.Enabled = Tablo.DataRowCount > 0;
            e.SagMenuGoster(sagMenu);
        }

        private void Tablo_ColumnFilterChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(Tablo.ActiveFilterString))
            {
                _filtreId = 0;
            }
        }

        private void Tablo_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            e.ShowFilterEditor = false;
            ShowEditForms<FiltreEditForm>.ShowDialogEditForm(KartTuru.Filtre, _filtreId, RaporTuru, Tablo.GridControl);
        }

        private void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (!Tablo.OptionsView.ShowFooter) return;

            if (e.Column.Summary.Count > 0 && e.Column.ColumnEdit != null)
            {
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
            }
        }

        private void Tablo_CustomDrawRowFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.Summary.Count > 0 && e.Column.ColumnEdit != null)
            {
                e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
            }
        }

        protected virtual void Tablo_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) { }
        protected virtual void Tablo_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e) { }
        protected virtual void Tablo_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e) { }
        protected virtual void Tablo_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e) { }

        private void Control_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Tablo.Focus();
            Cursor.Current = DefaultCursor;
        }

        #endregion
    }
}