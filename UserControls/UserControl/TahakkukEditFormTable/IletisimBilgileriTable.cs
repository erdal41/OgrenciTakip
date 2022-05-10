using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.IletisimForms;
using OgrenciTakip.UI.Win.Forms.YakinlikForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class IletisimBilgileriTable : BaseTablo
    {
        public IletisimBilgileriTable()
        {
            InitializeComponent();
            Bll = new IletisimBilgileriBll();
            Tablo = view;
            EventsLoad();
            ShowItems = new BarItem[] { btnKartDuzenle };
            repositoryItemAdresTuru.Items.AddEnum<AdresTuru>();
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((IletisimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IletisimBilgileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IletisimBilgileriList>().Where(x => !x.Delete).Select(x => x.IletisimId).ToList();

            var entities = ShowListForms<IletisimListForm>.ShowDialogListForm(KartTuru.Iletisim, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<IletisimList>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new IletisimBilgileriList
                {
                    TahakkukId = OwnerForm.Id,
                    IletisimId = entity.Id,
                    TcKimlikNo = entity.TcKimlikNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    EvTelefonu = entity.EvTelefonu,
                    CepTelefonu1 = entity.CepTelefonu1,
                    CepTelefonu2 = entity.CepTelefonu2,
                    IsTelefonu1 = entity.IsTelefonu1,
                    IsTelefonu2 = entity.IsTelefonu2,
                    EvAdresi = entity.EvAdresi,
                    EvAdresiIlAdi = entity.EvAdresiIlAdi,
                    EvAdresiIlceAdi = entity.EvAdresiIlceAdi,
                    IsAdresi = entity.IsAdresi,
                    IsAdresiIlAdi = entity.IsAdresiIlAdi,
                    IsAdresiIlceAdi = entity.IsAdresiIlceAdi,
                    MeslekAdi = entity.MeslekAdi,
                    IsyeriAdi = entity.IsyeriAdi,
                    GorevAdi = entity.GorevAdi,
                    Insert = true,
                };

                if (source.Count == 0)
                {
                    row.Veli = true;
                    row.FaturaAdresi = AdresTuru.EvAdresi;
                }

                var yakinlik = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, -1);

                if (yakinlik == null) return;

                row.YakinlikId = yakinlik.Id;
                row.YakinlikAdi = yakinlik.YakinlikAdi;

                source.Add(row);
            }

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colVeli;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (view.HasColumnErrors) view.ClearColumnErrors();

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<IletisimBilgileriList>(i);
                if (entity.YakinlikAdi == null)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colYakinlikAdi;
                    view.SetColumnError(colYakinlikAdi, "Yakınlık adı alanına geçerli bir değer giriniz.");
                }

                if (!view.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{view.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }

        protected override void OpenEntity()
        {
            var entity = Tablo.GetRow<IletisimBilgileriList>();
            if (entity == null) return;
            ShowEditForms<IletisimEditForm>.ShowDialogEditForm(KartTuru.Iletisim, entity.IletisimId, null);
        }

        protected override void ImageCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            //birden fazla satırdaki comboboxlardan sadece 1 tanesinin değişmesini sağlar.
            var source = Tablo.DataController.ListSource.Cast<IletisimBilgileriList>().ToList();

            if (source.Count == 0) return;

            var rowHandle = Tablo.FocusedRowHandle;

            for (int i = 0; i < Tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (source[i].FaturaAdresi == null) continue;
                source[i].FaturaAdresi = null;

                if (!source[i].Insert)
                {
                    source[i].Update = true;
                }

                insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            }
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            //birden fazla satırdaki checklerden sadece 1 tanesinin değişmesini sağlar.
            var source = Tablo.DataController.ListSource.Cast<IletisimBilgileriList>().ToList();

            if (source.Count == 0) return;

            var rowHandle = Tablo.FocusedRowHandle;

            for (int i = 0; i < Tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (!source[i].Veli) continue;
                source[i].Veli = false;

                if (!source[i].Insert)
                {
                    source[i].Update = true;
                }

                insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            }
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colYakinlikAdi)
            {
                e.FocusedColumn.Sec(view, insUpNavigator.Navigator, repositoryItemYakinlik, colYakinlikId);
            }
        }
    }
}