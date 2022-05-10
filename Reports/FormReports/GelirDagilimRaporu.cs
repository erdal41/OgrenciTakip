using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using System;
using System.Linq;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class GelirDagilimRaporu : BaseRapor
    {
        public GelirDagilimRaporu()
        {
            InitializeComponent();
            HideItems = new BarItem[] { btnKartAc };
        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl;
            Tablo = view;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Odemeler = txtOdemeler;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;
            HesaplamaSekli = txtHesaplamaSekli;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            OdemeTurleriYukle();
            txtHesaplamaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<GruplamaTuru>());
            txtHesaplamaSekli.SelectedItem = GruplamaTuru.VadeyeGore.ToName();
            RaporTuru = KartTuru.GelirDagilimRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboboxList<long>();
            var odemeler = txtOdemeler.CheckedComboboxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboboxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboboxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboboxList<IptalDurumu>();
            var hesaplamaSekli = txtHesaplamaSekli.Text.GetEnum<GruplamaTuru>();


            using (var bll = new GelirDagilimRaporuBll())
            {
                view.GridControl.DataSource = bll.List(x =>
                    subeler.Contains(x.Tahakkuk.SubeId) &&
                    odemeler.Contains(x.OdemeTipi) &&
                    kayitSekli.Contains(x.Tahakkuk.KayitSekli) &&
                    kayitDurumu.Contains(x.Tahakkuk.KayitDurumu) &&
                    iptalDurumu.Contains(x.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                    x.Tahakkuk.DonemId == AnaForm.DonemId,
                    hesaplamaSekli
                );

                base.Listele();
            }
        }

        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;
            if (item.FieldName != "colTahsilatOrani") return;

            //Grup alt toplamında bulunan 2 sutunun birbirine oranı
            if (e.IsGroupSummary)
            {
                var odemelerToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetOdeme"]));
                var tahsilatlarToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["Tahsil"]));

                e.TotalValue = odemelerToplami == 0 ? 0 : tahsilatlarToplami / odemelerToplami * 100;
            }

            //Genel tablonun alt toplamında bulunan 2 sutunun birbirine oranı
            else if (e.IsTotalSummary)
            {
                var odemelerToplami = Convert.ToDecimal(colNetOdeme.SummaryItem.SummaryValue);
                var tahsilatlarToplami = Convert.ToDecimal(colTahsilEdilen.SummaryItem.SummaryValue);

                e.TotalValue = odemelerToplami == 0 ? 0 : tahsilatlarToplami / odemelerToplami * 100;
            }
        }
    }
}