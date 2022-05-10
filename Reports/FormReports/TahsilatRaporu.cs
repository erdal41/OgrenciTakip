using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
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
    public partial class TahsilatRaporu : BaseRapor
    {
        public TahsilatRaporu()
        {
            InitializeComponent();
            ShowItems = new BarItem[] { btnBelgeHareketleri };
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
            txtIlkTarih.DateTime = DateTime.Now.Date;
            txtSonTarih.DateTime = DateTime.Now.Date;
            RaporTuru = KartTuru.TahsilatRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboboxList<long>();
            var odemeler = txtOdemeler.CheckedComboboxList<OdemeTipi>();
            var kayitSekli = txtKayitSekli.CheckedComboboxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboboxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboboxList<IptalDurumu>();
            var belgeDurumlari = txtBelgeDurumlari.CheckedComboboxList<BelgeDurumu>();


            using (var bll = new TahsilatRaporuBll())
            {
                view.GridControl.DataSource = bll.List(x =>
                    subeler.Contains(x.OdemeBilgileri.Tahakkuk.SubeId) &&
                    odemeler.Contains(x.OdemeBilgileri.OdemeTipi) &&
                    kayitSekli.Contains(x.OdemeBilgileri.Tahakkuk.KayitSekli) &&
                    kayitDurumu.Contains(x.OdemeBilgileri.Tahakkuk.KayitDurumu) &&
                    iptalDurumu.Contains(x.OdemeBilgileri.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                    belgeDurumlari.Contains(x.BelgeDurumu) &&
                    x.Makbuz.Tarih >= txtIlkTarih.DateTime.Date &&
                    x.Makbuz.Tarih <= txtSonTarih.DateTime.Date &&
                    x.OdemeBilgileri.Tahakkuk.DonemId == AnaForm.DonemId
                );

                base.Listele();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = view.GetRow<TahsilatRaporuList>();
            if (entity == null) return;

            ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, entity.MakbuzId, entity.MakbuzTuru, entity.MakbuzHesapTuru, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
        }

        protected override void BelgeHareketleri()
        {
            var entity = view.GetRow<TahsilatRaporuList>();
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

                if (enm == BelgeDurumu.AvukatYoluylaTahsilEtme ||
                    enm == BelgeDurumu.KismiAvukatYoluylaTahsilEtme ||
                    enm == BelgeDurumu.BlokeCozumu ||
                    enm == BelgeDurumu.MahsupEtme ||
                    enm == BelgeDurumu.OdenmisOlarakIsaretleme ||
                    enm == BelgeDurumu.TahsilEtmeBanka ||
                    enm == BelgeDurumu.TahsilEtmeKasa ||
                    enm == BelgeDurumu.BankaYoluylaTahsilEtme ||
                    enm == BelgeDurumu.KismiTahsilEdildi)
                {
                    BelgeDurumlari.Properties.Items.Add(item);
                }
            }
        }
    }
}