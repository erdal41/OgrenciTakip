using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraReports;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Forms.RaporForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Reports.XtraReports.Fatura;
using OgrenciTakip.UI.Win.Reports.XtraReports.Makbuz;
using OgrenciTakip.UI.Win.Reports.XtraReports.Tahakkuk;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.GenelForms
{
    public partial class RaporSecim : BaseListForm
    {
        #region Variables

        private readonly OgrenciRapor _ogrenciBilgileri;
        private readonly IEnumerable<IletisimBilgileriRapor> _iletisimBilgileri;
        private readonly IEnumerable<HizmetBilgileriRapor> _hizmetBilgileri;
        private readonly IEnumerable<IndirimBilgileriRapor> _indirimBilgileri;
        private readonly IEnumerable<OdemeBilgileriRapor> _odemeBilgileri;
        private readonly IEnumerable<GeriOdemeBilgileriRapor> _geriOdemeBilgileri;
        private readonly IEnumerable<EposBilgileriRapor> _eposBilgileri;
        private readonly IEnumerable<MakbuzHareketleriRapor> _makbuzBilgileri;
        private readonly IEnumerable<FaturaRapor> _faturaBilgileri;
        private readonly RaporBolumTuru _raporBolumTuru;

        #endregion

        public RaporSecim(params object[] prm)
        {
            InitializeComponent();
            Bll = new RaporBll();
            ShowItems = new BarItem[] { btnYeniRapor, btnBaskiOnizleme };
            HideItems = new BarItem[] { btnYeni, btnSec, btnFiltrele, btnKolonlar, barFiltrele, barFiltreleAciklama, barKolonlar, barKolonlarAciklama };

            btnDuzelt.CreateDropDownMenu(new BarItem[] { btnTasarimDegistir });
            btnYazdir.CreateDropDownMenu(new BarItem[] { btnYazdir });

            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
            txtYazdirmaSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaSekli>());
            txtYazdirmaSekli.SelectedItem = YazdirmaSekli.TekTekYazdir.ToName();
            _raporBolumTuru = (RaporBolumTuru)prm[0];

            if (_raporBolumTuru == RaporBolumTuru.TahakkukRaporlari)
            {
                _ogrenciBilgileri = (OgrenciRapor)prm[1];
                _iletisimBilgileri = (IEnumerable<IletisimBilgileriRapor>)prm[2];
                _hizmetBilgileri = (IEnumerable<HizmetBilgileriRapor>)prm[3];
                _indirimBilgileri = (IEnumerable<IndirimBilgileriRapor>)prm[4];
                _odemeBilgileri = (IEnumerable<OdemeBilgileriRapor>)prm[5];
                _geriOdemeBilgileri = (IEnumerable<GeriOdemeBilgileriRapor>)prm[6];
                _eposBilgileri = (IEnumerable<EposBilgileriRapor>)prm[7];
            }
            else if (_raporBolumTuru == RaporBolumTuru.MakbuzRaporlari)
            {
                _makbuzBilgileri = (List<MakbuzHareketleriRapor>)prm[1];
            }
            else if (_raporBolumTuru == RaporBolumTuru.FaturaDonemRaporlari || _raporBolumTuru == RaporBolumTuru.FaturaGenelRaporlari)
            {
                _faturaBilgileri = (List<FaturaRapor>)prm[1];
            }
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Rapor;
            Navigator = smallNavigator.Navigator;

            if (_raporBolumTuru == RaporBolumTuru.FaturaDonemRaporlari || _raporBolumTuru == RaporBolumTuru.FaturaGenelRaporlari || _raporBolumTuru == RaporBolumTuru.MakbuzRaporlari)
            {
                switch (_raporBolumTuru)
                {
                    case RaporBolumTuru.MakbuzRaporlari:
                        {
                            var showItems = new BarItem[] { btnGenelMakbuz, btnTahsilatMakbuzu, btnTeslimatMakbuzu, btnGeriIadeMakbuzu };
                            ShowItems = ShowItems.Concat(showItems).ToArray();
                            break;
                        }
                    case RaporBolumTuru.FaturaDonemRaporlari:
                        {
                            var showItems = new BarItem[] { btnFatura, btnDonemIcmalRaporu };
                            ShowItems = ShowItems.Concat(showItems).ToArray();
                            break;
                        }
                    case RaporBolumTuru.FaturaGenelRaporlari:
                        {
                            var showItems = new BarItem[] { btnOgrenciIcmalRaporu };
                            ShowItems = ShowItems.Concat(showItems).ToArray();
                            break;
                        }
                }

                var hideItems = new BarItem[]
                {
                    btnBosRapor, btnOgrenciKarti, btnBankaOdemePlani, btnIndirimTalepDilekcesi, btnMebKayitSozlesmesi,
                    btnKayitSozlesmesi, btnKrediKartliOdemeTalimati, btnOdemeSenedi
                };
                HideItems = HideItems.Concat(hideItems).ToArray();
            }
        }

        protected override void Listele()
        {
            //secilmiş olan satırların seçimini temizler.
            RowSelect?.ClearSelection();
            Tablo.GridControl.DataSource = ((RaporBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.RaporBolumTuru == _raporBolumTuru);
        }

        protected override void Duzelt()
        {
            if (Messages.RaporuTasarimaGonderMesaji() != DialogResult.Yes) return;

            Cursor.Current = Cursors.WaitCursor;

            var row = Tablo.GetRow<RaporList>();
            if (row == null) return;

            var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
            var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarim, entity);
            ShowEditFormDefault(result);

            Cursor.Current = DefaultCursor;
        }

        protected override void ShowEditForm(long id)
        {
            var row = Tablo.GetRow<RaporList>();
            if (row == null) return;
            var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
            var result = ShowEditForms<RaporEditForm>.ShowDialogEditForm(KartTuru.Rapor, id, entity.RaporTuru, entity.RaporBolumTuru, entity.Dosya);
            ShowEditFormDefault(result);
        }

        private IList<MyXtraReport> RaporHazirla()
        {
            var raporlar = new List<MyXtraReport>();

            var topluRapor = new MyXtraReport();
            topluRapor.CreateDocument();
            topluRapor.Baslik = "Toplu Rapor";
            topluRapor.PrintingSystem.ContinuousPageNumbering = false;

            foreach (var row in RowSelect.GetSelectedRows())
            {
                var entity = (Rapor)((RaporBll)Bll).Single(x => x.Id == row.Id);
                var rapor = entity.Dosya.ByteToStream().StreamToReport();
                ReportDataSource(rapor);
                rapor.CreateDocument();

                switch (txtYazdirmaSekli.Text.GetEnum<YazdirmaSekli>())
                {
                    case YazdirmaSekli.TekTekYazdir:
                        raporlar.Add(rapor);
                        break;
                    case YazdirmaSekli.TopluYazdir:
                        topluRapor.Pages.AddRange(rapor.Pages);
                        break;
                }
            }

            if (topluRapor.Pages.Count == 0) return raporlar;
            raporlar.Add(topluRapor);

            return raporlar;
        }

        private void ReportDataSource(IReport rapor)
        {
            switch (rapor)
            {
                case OgrenciKartiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Iletisim_Bilgileri.DataSource = _iletisimBilgileri;
                    rpr.Hizmet_Bilgileri.DataSource = _hizmetBilgileri;
                    rpr.Indirim_Bilgileri.DataSource = _indirimBilgileri
                        .GroupBy(x => new
                        {
                            x.IndirimAdi,
                            x.IptalTarihi,
                            x.IslemTarihi
                        })
                        .Select(x => new
                        {
                            x.Key.IndirimAdi,
                            x.Key.IptalTarihi,
                            x.Key.IslemTarihi,
                            BrutIndirim = x.Sum(y => y.BrutIndirim),
                            KistDonemDusulenIndirim = x.Sum(y => y.KistDonemDusulenIndirim),
                            NetIndirim = x.Sum(y => y.NetIndirim),
                        });
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri;
                    rpr.GeriOdeme_Bilgileri.DataSource = _geriOdemeBilgileri;
                    break;
                case BankaOdemePlaniRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    var secilenOdemeler = _odemeBilgileri.Where(x => x.OdemeTipi == OdemeTipi.Ots);
                    rpr.toplamTutarYazi.Text = secilenOdemeler.Sum(x => x.Tutar).YaziIleTutar();
                    rpr.Odeme_Bilgileri.DataSource = secilenOdemeler;
                    break;
                case MebKayitSozlemesiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    break;
                case IndirimDilekcesiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Indirim_Bilgileri.DataSource = _indirimBilgileri.GroupBy(x => x.IndirimAdi).Select(x => new
                    {
                        IndirimAdi = x.Key,
                        BrutIndirim = x.Sum(y => y.BrutIndirim),
                        KistDonemDusulenIndirim = x.Sum(y => y.KistDonemDusulenIndirim),
                        NetIndirim = x.Sum(y => y.NetIndirim)
                    });
                    break;
                case KayitSozlemesiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    break;
                case KrediKartliOdemeTalimatiRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Epos_Bilgileri.DataSource = _eposBilgileri;
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri.Where(x => x.OdemeTipi == OdemeTipi.Epos).OrderBy(x => x.Vade);
                    break;
                case OdemeSenediRaporu rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri.Where(x => x.OdemeTipi == OdemeTipi.Senet).OrderBy(x => x.Vade);
                    break;
                case KullaniciTanimliRapor rpr:
                    rpr.Ogrenci_Bilgileri.DataSource = _ogrenciBilgileri;
                    rpr.Iletisim_Bilgileri.DataSource = _iletisimBilgileri;
                    rpr.Hizmet_Bilgileri.DataSource = _hizmetBilgileri;
                    rpr.Indirim_Bilgileri.DataSource = _indirimBilgileri
                        .GroupBy(x => new
                        {
                            x.IndirimAdi,
                            x.IptalTarihi,
                            x.IslemTarihi
                        })
                        .Select(x => new
                        {
                            x.Key.IndirimAdi,
                            x.Key.IptalTarihi,
                            x.Key.IslemTarihi,
                            BrutIndirim = x.Sum(y => y.BrutIndirim),
                            KistDonemDusulenIndirim = x.Sum(y => y.KistDonemDusulenIndirim),
                            NetIndirim = x.Sum(y => y.NetIndirim),
                        });
                    rpr.Odeme_Bilgileri.DataSource = _odemeBilgileri;
                    rpr.GeriOdeme_Bilgileri.DataSource = _geriOdemeBilgileri;
                    rpr.Epos_Bilgileri.DataSource = _eposBilgileri;
                    break;
                case TahsilatMakbuzuRaporu rpr:
                    rpr.Makbuz_Bilgileri.DataSource = _makbuzBilgileri;
                    break;
                case TeslimatMakbuzuRaporu rpr:
                    rpr.Makbuz_Bilgileri.DataSource = _makbuzBilgileri;
                    break;
                case GeriIadeMakbuzuRaporu rpr:
                    rpr.Makbuz_Bilgileri.DataSource = _makbuzBilgileri;
                    break;
                case GenelMakbuzRaporu rpr:
                    rpr.Makbuz_Bilgileri.DataSource = _makbuzBilgileri;
                    break;
                case FaturaRaporu rpr:
                    rpr.Fatura_Bilgileri.DataSource = _faturaBilgileri;
                    break;
                case FaturaDonemIcmalRaporu rpr:
                    rpr.Fatura_Bilgileri.DataSource = _faturaBilgileri;
                    break;
                case FaturaOgrenciIcmalRaporu rpr:
                    rpr.Fatura_Bilgileri.DataSource = _faturaBilgileri;
                    break;

            }
        }

        protected override void Yazdir()
        {
            if (Messages.EvetSeciliEvetHayir("Rapor yazdırılmak üzere seçtiğiniz yazıcıya gönderilecektir. Onaylıyor musunuz?", "Onay") != DialogResult.Yes) return;
            var raporlar = RaporHazirla();

            for (int i = 0; i < txtYazdirilacakAdet.Value; i++)
            {
                raporlar.ForEach(x => x.Print(txtYaziciAdi.Text));
            }
        }

        protected override void BaskiOnizleme()
        {
            var raporlar = RaporHazirla();
            raporlar.ForEach(x => ShowRibbonForms<RaporOnizleme>.ShowForm(false, x.PrintingSystem, x.Baslik));
        }

        #endregion

        #region Events

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Button_ItemClick(sender, e);

            void RaporOlustur(KartTuru raporTuru, RaporBolumTuru raporBolumTuru, MyXtraReport rapor)
            {
                if (Messages.RaporuTasarimaGonderMesaji() != DialogResult.Yes) return;

                Cursor.Current = Cursors.WaitCursor;

                var entity = new Rapor
                {
                    Kod = ((RaporBll)Bll).YeniKodVer(x => x.RaporTuru == raporTuru),
                    RaporTuru = raporTuru,
                    RaporBolumTuru = raporBolumTuru,
                    RaporAdi = raporTuru.ToName(),
                    Dosya = rapor.ReportToStream().GetBuffer(),
                    Durum = true,
                };

                var result = ShowRibbonForms<RaporTasarim>.ShowDialogForm(KartTuru.RaporTasarim, entity);
                ShowEditFormDefault(result);

                Cursor.Current = DefaultCursor;
            }

            if (e.Item == btnYeniRapor)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnOgrenciKarti)
            {
                RaporOlustur(KartTuru.OgrenciKartiRaporu, RaporBolumTuru.TahakkukRaporlari, new OgrenciKartiRaporu());
            }
            else if (e.Item == btnBankaOdemePlani)
            {
                RaporOlustur(KartTuru.BankaOdemePlaniRaporu, RaporBolumTuru.TahakkukRaporlari, new BankaOdemePlaniRaporu());
            }
            else if (e.Item == btnMebKayitSozlesmesi)
            {
                RaporOlustur(KartTuru.MebKayitSozlesmesiRaporu, RaporBolumTuru.TahakkukRaporlari, new MebKayitSozlemesiRaporu());
            }
            else if (e.Item == btnIndirimTalepDilekcesi)
            {
                RaporOlustur(KartTuru.IndirimDilekcesiRaporu, RaporBolumTuru.TahakkukRaporlari, new IndirimDilekcesiRaporu());
            }
            else if (e.Item == btnKayitSozlesmesi)
            {
                RaporOlustur(KartTuru.KayitSozlesmesiRaporu, RaporBolumTuru.TahakkukRaporlari, new KayitSozlemesiRaporu());
            }
            else if (e.Item == btnKrediKartliOdemeTalimati)
            {
                RaporOlustur(KartTuru.KrediKartliOdemeTalimatiRaporu, RaporBolumTuru.TahakkukRaporlari, new KrediKartliOdemeTalimatiRaporu());
            }
            else if (e.Item == btnOdemeSenedi)
            {
                RaporOlustur(KartTuru.OdemeSenediRaporu, RaporBolumTuru.TahakkukRaporlari, new OdemeSenediRaporu());
            }
            else if (e.Item == btnBosRapor)
            {
                RaporOlustur(KartTuru.KullaniciTanimliRapor, RaporBolumTuru.TahakkukRaporlari, new KullaniciTanimliRapor());
            }
            else if (e.Item == btnTahsilatMakbuzu)
            {
                RaporOlustur(KartTuru.TahsilatMakbuzu, RaporBolumTuru.MakbuzRaporlari, new TahsilatMakbuzuRaporu());
            }
            else if (e.Item == btnTeslimatMakbuzu)
            {
                RaporOlustur(KartTuru.TeslimatMakbuzu, RaporBolumTuru.MakbuzRaporlari, new TeslimatMakbuzuRaporu());
            }
            else if (e.Item == btnGeriIadeMakbuzu)
            {
                RaporOlustur(KartTuru.GeriIadeMakbuzu, RaporBolumTuru.MakbuzRaporlari, new GeriIadeMakbuzuRaporu());
            }
            else if (e.Item == btnGenelMakbuz)
            {
                RaporOlustur(KartTuru.GenelMakbuz, RaporBolumTuru.MakbuzRaporlari, new GenelMakbuzRaporu());
            }
            else if (e.Item == btnFatura)
            {
                RaporOlustur(KartTuru.FaturaRaporu, RaporBolumTuru.FaturaDonemRaporlari, new FaturaRaporu());
            }
            else if (e.Item == btnDonemIcmalRaporu)
            {
                RaporOlustur(KartTuru.FaturaDonemIcmalRaporu, RaporBolumTuru.FaturaDonemRaporlari, new FaturaDonemIcmalRaporu());
            }
            else if (e.Item == btnOgrenciIcmalRaporu)
            {
                RaporOlustur(KartTuru.FaturaOgrenciIcmalRaporu, RaporBolumTuru.FaturaGenelRaporlari, new FaturaOgrenciIcmalRaporu());
            }
        }

        #endregion
    }
}