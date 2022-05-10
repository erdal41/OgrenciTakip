using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraTabbedMdi;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OgrenciTakip.UI.Win.Forms.AvukatForms;
using OgrenciTakip.UI.Win.Forms.BankaForms;
using OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using OgrenciTakip.UI.Win.Forms.CariForms;
using OgrenciTakip.UI.Win.Forms.EvrakForms;
using OgrenciTakip.UI.Win.Forms.FaturaForms;
using OgrenciTakip.UI.Win.Forms.GorevForms;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using OgrenciTakip.UI.Win.Forms.IletisimForms;
using OgrenciTakip.UI.Win.Forms.IlForms;
using OgrenciTakip.UI.Win.Forms.IndirimForms;
using OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakip.UI.Win.Forms.IsyeriForms;
using OgrenciTakip.UI.Win.Forms.KasaForms;
using OgrenciTakip.UI.Win.Forms.KontenjanForms;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Forms.MeslekForms;
using OgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using OgrenciTakip.UI.Win.Forms.OgrenciForms;
using OgrenciTakip.UI.Win.Forms.OkulForms;
using OgrenciTakip.UI.Win.Forms.PromosyonForms;
using OgrenciTakip.UI.Win.Forms.RehberForms;
using OgrenciTakip.UI.Win.Forms.ServisForms;
using OgrenciTakip.UI.Win.Forms.SinifForms;
using OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Forms.TesvikForms;
using OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using OgrenciTakip.UI.Win.Forms.YakinlikForms;
using OgrenciTakip.UI.Win.Reports.FormReports;
using OgrenciTakip.UI.Win.Show;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.GenelForms
{
    public partial class AnaForm : RibbonForm
    {
        #region Variables

        public static string KurumAdi;
        public static long KullaniciId;
        public static string KullaniciAdi;
        public static long KullaniciRolId;
        public static string KullaniciRolAdi;
        public static long DonemId;
        public static string DonemAdi = "Dönem bilgisi bekleniyor...";
        public static long SubeId;
        public static string SubeAdi = "Şube bilgisi bekleniyor...";
        public static List<long> YetkiliOlunanSubeler;
        public static DonemParametre DonemParametreleri;
        public static KullaniciParametreSingle KullaniciParametreleri = new KullaniciParametreSingle();
        public static IEnumerable<RolYetkileriList> RolYetkileri;

        #endregion

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();

            imgArkaPlanResmi.EditValue = KullaniciParametreleri.ArkaPlanResmi;
        }

        #region Functions

        private void EventsLoad()
        {
            Load += AnaForm_Load;
            FormClosing += AnaForm_FormClosing;
            KeyDown += Control_KeyDown;

            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    //SkinRibbonGalleryBarItem BarButtonItem'dan implement yani referans aldığı için üste yazılmalı
                    case SkinRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += Gallery_GalleryItemClick;
                        break;
                    case SkinPaletteRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += Gallery_GalleryItemClick;
                        break;
                    case BarButtonItem btn:
                        btn.ItemClick += Btnlar_ItemClick;
                        break;

                }
            }

            foreach (Control control in Controls)
            {
                //Form üzerindeki herhangi bir controle(button, text vb.) focuslanılsa bile aşağıdaki event çalışacak. 
                control.KeyDown += Control_KeyDown;
            }

            xtraTabbedMdiManager.PageAdded += XtraTabbedMdiManager_PageAdded;
            xtraTabbedMdiManager.PageRemoved += XtraTabbedMdiManager_PageRemoved;
        }

        private void SubeDonemSecimi(bool subeSecimButonunaBasildi)
        {
            ShowEditForms<SubeDonemSecimiEditForm>.ShowDialogEditForm(null, KullaniciId, subeSecimButonunaBasildi, SubeId, DonemId);
            barDonemAdi.Caption = DonemAdi;
            btnSubeAdi.Caption = SubeAdi;
        }

        #endregion

        #region  Events

        private void AnaForm_Load(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            barKullaniciAdi.Caption = $"{KullaniciAdi} + ( {KullaniciRolAdi} )";
            barKurumAdi.Caption = KurumAdi;
            SubeDonemSecimi(false);

            if (DonemParametreleri == null)
            {
                Messages.HataMesaji("Dönem parametreleri girilmemiş. Lütfen sistem yöneticisine başvurunuz.");
                Application.ExitThread();
                return;
            }

            if (!DonemParametreleri.YetkiKontroluAnlikYapilacak)
            {
                using (var bll = new RolYetkileriBll())
                {
                    RolYetkileri = bll.List(x => x.RolId == KullaniciRolId).EntityListConvert<RolYetkileriList>();
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan çıkmak istiyor musunuz?", "Çıkış Onayı") == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Gallery_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var gallery = sender as InRibbonGallery;
            var key = "";

            if (gallery.OwnerItem.GetType() == typeof(SkinRibbonGalleryBarItem))
            {
                key = "Skin";
            }
            else if (gallery.OwnerItem.GetType() == typeof(SkinPaletteRibbonGalleryBarItem))
            {
                key = "Palette";
            }

            Functions.GeneralFunctions.AppSettingWrite(key, e.Item.Caption);
        }

        private void Btnlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnOkulKartlari)
            {
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
            }
            else if (e.Item == btnIlKartlari)
            {
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            }
            else if (e.Item == btnAileBilgiKartlari)
            {
                ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            }
            else if (e.Item == btnIptalNedeniKartlari)
            {
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            }
            else if (e.Item == btnYabanciDilKartlari)
            {
                ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
            }
            else if (e.Item == btnTesvikKartlari)
            {
                ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            }
            else if (e.Item == btnKontenjanKartlari)
            {
                ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            }
            else if (e.Item == btnRehberKartlari)
            {
                ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            }
            else if (e.Item == btnSinifGrupKartlari)
            {
                ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            }
            else if (e.Item == btnMeslekKartlari)
            {
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            }
            else if (e.Item == btnYakinlikKartlari)
            {
                ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            }
            else if (e.Item == btnIsyeriKartlari)
            {
                ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            }
            else if (e.Item == btnGorevKartlari)
            {
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            }
            else if (e.Item == btnIndirimTuruKartlari)
            {
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            }
            else if (e.Item == btnEvrakKartlari)
            {
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            }
            else if (e.Item == btnPromosyonKartlari)
            {
                ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            }
            else if (e.Item == btnServisYerikKartlari)
            {
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            }
            else if (e.Item == btnSinifKartlari)
            {
                ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            }
            else if (e.Item == btnHizmetTuruKartlari)
            {
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            }
            else if (e.Item == btnHizmetKartlari)
            {
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            }
            else if (e.Item == btnKasaKartlari)
            {
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            }
            else if (e.Item == btnBankaKartlari)
            {
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            }
            else if (e.Item == btnAvukatkartlari)
            {
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            }
            else if (e.Item == btnCariKartlari)
            {
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            }
            else if (e.Item == btnOdemeTuruKartlari)
            {
                ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
            }
            else if (e.Item == btnBankaHesapKartlari)
            {
                ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            }
            else if (e.Item == btnIletisimKartlari)
            {
                ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
            }
            else if (e.Item == btnOgrenciKartlari)
            {
                ShowListForms<OgrenciListForm>.ShowListForm(KartTuru.Ogrenci);
            }
            else if (e.Item == btnIndirimKartlari)
            {
                ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            }
            else if (e.Item == btnTahakkukKartlari)
            {
                ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
            }
            else if (e.Item == btnMakbuzKartlari)
            {
                ShowListForms<MakbuzListForm>.ShowListForm(KartTuru.Makbuz);
            }
            else if (e.Item == btnFaturaKartlari)
            {
                ShowListForms<FaturaPlaniListForm>.ShowListForm(KartTuru.Fatura);
            }
            else if (e.Item == btnFaturaTahakkukKartlari)
            {
                ShowEditForms<FaturaTahakkukEditForm>.ShowDialogEditForm(KartTuru.Fatura);
            }
            else if (e.Item == btnGenelAmacliRapor)
            {
                ShowEditReports<GenelAmacliRapor>.ShowEditReport(KartTuru.GenelAmacliRapor);
            }
            else if (e.Item == btnSinifRaporlari)
            {
                ShowEditReports<SinifRaporlari>.ShowEditReport(KartTuru.SinifRaporlari);
            }
            else if (e.Item == btnHizmetAlimRaporu)
            {
                ShowEditReports<HizmetAlimRaporu>.ShowEditReport(KartTuru.HizmetAlimRaporu);
            }
            else if (e.Item == btnNetUcretRaporu)
            {
                ShowEditReports<NetUcretRaporu>.ShowEditReport(KartTuru.NetUcretRaporu);
            }
            else if (e.Item == btnUcretVeOdemeRaporu)
            {
                ShowEditReports<UcretVeOdemeRaporu>.ShowEditReport(KartTuru.UcretVeOdemeRaporu);
            }
            else if (e.Item == btnIndirimDagilimRaporu)
            {
                ShowEditReports<IndirimDagilimRaporu>.ShowEditReport(KartTuru.IndirimDagilimRaporu);
            }
            else if (e.Item == btnMesleklereGoreKayitRaporu)
            {
                ShowEditReports<MesleklereGoreKayitRaporu>.ShowEditReport(KartTuru.MesleklereGoreKayitRaporu);
            }
            else if (e.Item == btnAylikKayitRaporu)
            {
                ShowEditReports<AylikKayitRaporu>.ShowEditReport(KartTuru.AylikKayitRaporu);
            }
            else if (e.Item == btnGelirDagilimRaporu)
            {
                ShowEditReports<GelirDagilimRaporu>.ShowEditReport(KartTuru.GelirDagilimRaporu);
            }
            else if (e.Item == btnUcretOrtalamalariRaporu)
            {
                ShowEditReports<UcretOrtalamalariRaporu>.ShowEditReport(KartTuru.UcretOrtalamalariRaporu);
            }
            else if (e.Item == btnOdemeBelgeleriRaporu)
            {
                ShowEditReports<OdemeBelgeleriRaporu>.ShowEditReport(KartTuru.OdemeBelgeleriRaporu);
            }
            else if (e.Item == btnTahsilatRaporu)
            {
                ShowEditReports<TahsilatRaporu>.ShowEditReport(KartTuru.TahsilatRaporu);
            }
            else if (e.Item == btnGecikenAlacaklarRaporu)
            {
                ShowEditReports<OdemesiGecikenAlacaklarRaporu>.ShowEditReport(KartTuru.OdemesiGecikenAlacaklarRaporu);
            }
            else if (e.Item == btnKullaniciParametreleri)
            {
                var entity = ShowEditForms<KullaniciParametreEditForm>.ShowDialogEditForm<KullaniciParametreSingle>(KullaniciId);

                if (entity == null) return;

                KullaniciParametreleri = entity;
                imgArkaPlanResmi.EditValue = entity.ArkaPlanResmi;
            }
            else if (e.Item == btnHesapMakinesi)
            {
                try
                {
                    Process.Start("calc.exe");
                }
                catch
                {
                    Messages.HataMesaji("Hesap makinesi bulunamadı.");
                }
            }
            else if (e.Item == btnSubeAdi)
            {
                //sube değişince açık olan formlar kapanır
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    //eğer açık olan formlar anaform ve girisform ise atla diğer satıra geç. Yani kapatma
                    if (Application.OpenForms[i] is GirisForm || Application.OpenForms[i] is AnaForm) continue;
                    Application.OpenForms[i].Close();
                    i--;
                }

                SubeDonemSecimi(true);
            }
            else if (e.Item == btnSifreDegistir)
            {
                ShowEditForms<SifreDegistirEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate);
            }

            Cursor.Current = Cursors.Default;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void XtraTabbedMdiManager_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            imgArkaPlanResmi.SendToBack();
        }

        private void XtraTabbedMdiManager_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            if (((XtraTabbedMdiManager)sender).Pages.Count == 0)
            {
                imgArkaPlanResmi.BringToFront();
            }
        }

        #endregion
    }
}