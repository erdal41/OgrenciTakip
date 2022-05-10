﻿using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using System;
using System.Linq;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class AylikKayitRaporu : BaseRapor
    {
        public AylikKayitRaporu()
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
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            RaporTuru = KartTuru.AylikKayitRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboboxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboboxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboboxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboboxList<IptalDurumu>();

            using (var bll = new AylikKayitRaporuBll())
            {
                view.GridControl.DataSource = bll.List(x =>
                    subeler.Contains(x.SubeId) &&
                    kayitSekli.Contains(x.KayitSekli) &&
                    kayitDurumu.Contains(x.KayitDurumu) &&
                    iptalDurumu.Contains(x.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                    x.DonemId == AnaForm.DonemId
                );

                base.Listele();
            }
        }

        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;
            if (item.FieldName == "colIndirimOrani")
            {
                //Grup alt toplamında bulunan 2 sutunun birbirine oranı
                if (e.IsGroupSummary)
                {
                    var hizmetlerToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetHizmet"]));
                    var indirimlerToplami = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetIndirim"]));

                    e.TotalValue = hizmetlerToplami == 0 ? 0 : indirimlerToplami / hizmetlerToplami * 100;
                }

                //Genel tablonun alt toplamında bulunan 2 sutunun birbirine oranı
                else if (e.IsTotalSummary)
                {
                    var hizmetlerToplami = Convert.ToDecimal(colNetHizmet.SummaryItem.SummaryValue);
                    var indirimlerToplami = Convert.ToDecimal(colNetIndirim.SummaryItem.SummaryValue);

                    e.TotalValue = hizmetlerToplami == 0 ? 0 : indirimlerToplami / hizmetlerToplami * 100;
                }
            }

            if (item.FieldName != "colOrtalama") return;

            //Grup alt toplamında bulunan 2 sutunun birbirine oranı
            if (e.IsGroupSummary)
            {
                var toplamKayit = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["ToplamKayit"]));
                var netUcret = Convert.ToDecimal(Tablo.GetGroupSummaryValue(e.GroupRowHandle, (GridGroupSummaryItem)Tablo.GroupSummary["NetUcret"]));

                e.TotalValue = toplamKayit == 0 ? 0 : netUcret / toplamKayit;
            }

            //Genel tablonun alt toplamında bulunan 2 sutunun birbirine oranı
            else if (e.IsTotalSummary)
            {
                var toplamKayit = Convert.ToDecimal(colToplamKayit.SummaryItem.SummaryValue);
                var netUcret = Convert.ToDecimal(colNetUcret.SummaryItem.SummaryValue);

                e.TotalValue = toplamKayit == 0 ? 0 : netUcret / toplamKayit;
            }
        }
    }
}