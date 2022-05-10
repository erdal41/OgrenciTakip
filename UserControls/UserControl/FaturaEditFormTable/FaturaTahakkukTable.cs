using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.FaturaForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.FaturaEditFormTable
{
    public partial class FaturaTahakkukTable : BaseTablo
    {
        public FaturaTahakkukTable()
        {
            InitializeComponent();
            Bll = new FaturaBll();
            Tablo = view;
            EventsLoad();
            btnHareketEkle.Caption = "Tahakkuk Yap";
            btnHareketSil.Caption = "Tahakkuk İptal Et";
            insUpNavigator.Navigator.Buttons.Append.Hint = "Tahakkuk Yap";
            insUpNavigator.Navigator.Buttons.Remove.Hint = "Tahakkuk İptal Et";
        }

        #region Functions

        protected internal override void Listele()
        {
            var selectedItem = ((FaturaTahakkukEditForm)OwnerForm).txtFaturaDonemi.SelectedItem;
            if (selectedItem == null) return;
            var t = DateTime.Parse("10.01.2021");
            var tarih = DateTime.Parse(selectedItem.ToString());
            view.GridControl.DataSource = ((FaturaBll)Bll).FaturaTahakkukList(x =>
                x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId &&
                x.PlanTarih == tarih).ToBindingList<FaturaPlaniList>();
        }

        protected override void HareketEkle()
        {
            if (view.DataRowCount == 0)
            {
                Messages.HataMesaji("Fatura tahakkuku yapılacak öğrenci bulunamadı. Fatura dönemi seçmemiş olabilirsiniz.");
                return;
            }

            if (Messages.HayirSeciliEvetHayir("Seçilen öğrencilere yukarıda girmiş olduğunuz parametlere göre fatura tahakkuku yapılacaktır. Onaylıyor musunuz?", "Tahakkuk Onayı") != DialogResult.Yes) return;

            var faturaNo = (int)((FaturaTahakkukEditForm)OwnerForm).txtFaturaNo.Value;
            var kdvSekli = ((FaturaTahakkukEditForm)OwnerForm).txtKdvSekli.Text.GetEnum<KdvSekli>();
            var kdvOrani = (byte)((FaturaTahakkukEditForm)OwnerForm).txtKdvOrani.Value;
            var adresTuru = ((FaturaTahakkukEditForm)OwnerForm).txtFaturaAdresi.Text.GetEnum<AdresTuru>();

            decimal kdvHesapla(decimal tutar)
            {
                return kdvSekli == KdvSekli.Dahil ? Math.Round(tutar * kdvOrani / (100 + kdvOrani), 2) : Math.Round((tutar * kdvOrani) / 100, 2);
            }

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<FaturaPlaniList>(i);
                if (entity == null) return;

                entity.FaturaNo = faturaNo + i;
                entity.TahakkukTarih = entity.PlanTarih;
                entity.TahakkukTutari = entity.PlanTutari;
                entity.TahakkukIndirimTutari = entity.PlanIndirimTutari;
                entity.TahakkukNetTutar = entity.PlanNetTutar;
                entity.KdvOrani = kdvOrani;
                entity.KdvTutari = kdvHesapla(entity.TahakkukNetTutar.Value);
                entity.KdvHaricTutar = kdvSekli == KdvSekli.Haric ? entity.TahakkukNetTutar : entity.TahakkukNetTutar - entity.KdvTutari;
                entity.ToplamTutar = entity.KdvHaricTutar + entity.KdvTutari;
                entity.ToplamTutarYazi = entity.TahakkukNetTutar.Value.YaziIleTutar();
                entity.KdvSekli = kdvSekli;
                entity.FaturaAdresi = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresi : entity.VeliIsAdresi;
                entity.FaturaAdresiIlId = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresiIlId : entity.VeliIsAdresiIlId;
                entity.VeliEvAdresiIlAdi = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresiIlAdi : entity.VeliIsAdresiIlAdi;
                entity.FaturaAdresiIlceId = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresiIlceId : entity.VeliIsAdresiIlceId;
                entity.VeliEvAdresiIlceAdi = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresiIlceAdi : entity.VeliIsAdresiIlceAdi;
                entity.Update = true;
            }

            view.RefreshData();
            ButtonEnabledDurumu(true);
        }

        protected override void HareketSil()
        {
            if (Messages.HayirSeciliEvetHayir("Seçilen öğrencilere yapılan fatura tahakkukları iptal  edilecektir. Onaylıyor musunuz?", "İptal Onayı") != DialogResult.Yes) return;

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<FaturaPlaniList>();
                if (entity == null) return;

                entity.FaturaNo = null;
                entity.TahakkukTarih = null;
                entity.TahakkukTutari = null;
                entity.TahakkukIndirimTutari = null;
                entity.TahakkukNetTutar = null;
                entity.KdvOrani = null;
                entity.KdvTutari = null;
                entity.KdvHaricTutar = null;
                entity.ToplamTutar = null;
                entity.ToplamTutarYazi = null;
                entity.KdvSekli = null;
                entity.FaturaAdresi = null;
                entity.FaturaAdresiIlId = null;
                entity.VeliEvAdresiIlAdi = null;
                entity.FaturaAdresiIlceId = null;
                entity.VeliEvAdresiIlceAdi = null;
                entity.Update = true;
            }

            view.RefreshData();
            ButtonEnabledDurumu(true);
        }
    }

    #endregion 
}