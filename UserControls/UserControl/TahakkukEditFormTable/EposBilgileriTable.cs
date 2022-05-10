using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class EposBilgileriTable : BaseTablo
    {
        public EposBilgileriTable()
        {
            InitializeComponent();
            Bll = new EposBilgileriBll();
            Tablo = view;
            EventsLoad();
            repositoryItemKartTuru.Items.AddEnum<EposKartTuru>();
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((EposBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<EposBilgileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;

            var row = new EposBilgileriList
            {
                TahakkukId = OwnerForm.Id,
                Insert = true,
            };
            source.Add(row);

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colAdi;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (view.HasColumnErrors) view.ClearColumnErrors();

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<EposBilgileriList>(i);
                if (string.IsNullOrEmpty(entity.Adi))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colAdi;
                    view.SetColumnError(colAdi, "Kart sahibinin adı alanına geçerli bir değer giriniz.");
                }

                if (string.IsNullOrEmpty(entity.Soyadi))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colSoyadi;
                    view.SetColumnError(colSoyadi, "Kart sahibinin soyadı alanına geçerli bir değer giriniz.");
                }

                if (string.IsNullOrEmpty(entity.BankaAdi))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colBankaAdi;
                    view.SetColumnError(colBankaAdi, "Banka adı alanına geçerli bir değer giriniz.");
                }

                if (string.IsNullOrEmpty(entity.KartNo))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colKartNo;
                    view.SetColumnError(colKartNo, "Kart numarası alanına geçerli bir değer giriniz.");
                }

                if (string.IsNullOrEmpty(entity.SonKullanmaTarihi))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colSonKullanmaTarihi;
                    view.SetColumnError(colSonKullanmaTarihi, "Son kullanma tarihi alanına geçerli bir değer giriniz.");
                }

                if (string.IsNullOrEmpty(entity.GuvenlikKodu))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colGuvenlikKodu;
                    view.SetColumnError(colGuvenlikKodu, "Güvenlik kodu alanına geçerli bir değer giriniz.");
                }

                if (!view.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{view.ViewCaption} Tablosu");

                return true;
            }
            return false;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankaAdi)
            {
                e.FocusedColumn.Sec(view, insUpNavigator.Navigator, repositoryItemBanka, colBankaId);
            }
        }
    }
}