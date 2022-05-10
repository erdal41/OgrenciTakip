using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    //Belge durumuna göre satır renklendirme yapılacak
    public partial class OdemesiGecikenAlacaklarRaporu : BaseRapor
    {
        public OdemesiGecikenAlacaklarRaporu()
        {
            InitializeComponent();
            ShowItems = new BarItem[] { btnKartAc, btnBelgeHareketleri, btnTumDetaylariGenislet, btnTumDetaylariDaralt };
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
            BelgeDurumlari = txtBelgeDurumlari;
            IlkTarih = txtIlkTarih;
            SonTarih = txtSonTarih;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            OdemeTurleriYukle();
            BelgeDurumlariYukle();
            txtIlkTarih.DateTime = AnaForm.DonemParametreleri.DonemBaslamaTarihi;
            txtSonTarih.DateTime = DateTime.Now.Date;
            RaporTuru = KartTuru.OdemesiGecikenAlacaklarRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboboxList<long>();
            var odemeler = txtOdemeler.CheckedComboboxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboboxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboboxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboboxList<IptalDurumu>();
            var belgeDurumlari = txtBelgeDurumlari.CheckedComboboxList<BelgeDurumu>();


            using (var bll = new OdemesiGecikenAlacaklarRaporuBll())
            {
                view.GridControl.DataSource = bll.List(x =>
                    subeler.Contains(x.Tahakkuk.SubeId) &&
                    odemeler.Contains(x.OdemeTipi) &&
                    kayitSekli.Contains(x.Tahakkuk.KayitSekli) &&
                    kayitDurumu.Contains(x.Tahakkuk.KayitDurumu) &&
                    iptalDurumu.Contains(x.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                    x.Vade >= txtIlkTarih.DateTime.Date &&
                    x.Vade <= txtSonTarih.DateTime.Date &&
                    x.Tahakkuk.DonemId == AnaForm.DonemId,
                    belgeDurumlari
                );

                base.Listele();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = view.GetRow<OdemesiGecikenAlacaklarRaporuList>();
            if (entity == null) return;

            ShowListForms<GecikmeAciklamalariListForm>.ShowDialogListForm(KartTuru.GecikmeAciklamalari, null, entity.PortfoyNo);
        }

        protected override void BelgeHareketleri()
        {
            var entity = view.GetRow<OdemesiGecikenAlacaklarRaporuList>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.PortfoyNo);
        }

        protected override void BelgeDurumlariYukle()
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

                if (enm == BelgeDurumu.Portfoyde ||
                    enm == BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                    enm == BelgeDurumu.KismiTahsilEdildi ||
                    enm == BelgeDurumu.BankayaTahsileGonderme ||
                    enm == BelgeDurumu.AvukataGonderme ||
                    enm == BelgeDurumu.CiroEtme ||
                    enm == BelgeDurumu.BlokeAlma ||
                    enm == BelgeDurumu.OnayBekliyor ||
                    enm == BelgeDurumu.PortfoyeGeriIade ||
                    enm == BelgeDurumu.PortfoyeKarsiliksizIade ||
                    enm == BelgeDurumu.TahsiliImkansizHaleGelme)
                {
                    BelgeDurumlari.Properties.Items.Add(item);
                }
            }
        }

        protected override void Tablo_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        protected override void Tablo_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "altGrid";
        }

        protected override void Tablo_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            var entity = view.GetRow<OdemesiGecikenAlacaklarRaporuList>(e.RowHandle);
            if (entity == null) return;

            using (var bll = new GecikmeAciklamalariBll())
            {
                var list = bll.List(x => x.OdemeBilgileriId == entity.PortfoyNo).EntityListConvert<GecikmeAciklamalariList>().ToList();
                if (list.Any())
                {
                    e.ChildList = list;
                }
            }
        }
    }
}