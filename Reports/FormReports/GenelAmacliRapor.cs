﻿using DevExpress.Data;
using DevExpress.XtraGrid;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class GenelAmacliRapor : BaseRapor
    {
        public GenelAmacliRapor()
        {
            InitializeComponent();
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
            RaporTuru = KartTuru.GenelAmacliRapor;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboboxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboboxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboboxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboboxList<IptalDurumu>();

            using (var bll = new GenelAmacliRaporBll())
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

        protected override void ShowEditForm()
        {
            var entity = view.GetRow<GenelAmacliRaporList>();
            if (entity == null) return;

            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
        }

        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;
            if (item.FieldName != "IndirimOrani") return;

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
    }
}