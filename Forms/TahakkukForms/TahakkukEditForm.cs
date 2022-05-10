using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable;
using System;
using System.Drawing;
using System.Linq;

namespace OgrenciTakip.UI.Win.Forms.TahakkukForms
{
    public partial class TahakkukEditForm : BaseEditForm
    {
        #region Variables

        private readonly Ogrenci _ogrenci;
        private BaseTablo _kardesBilgileriTable;
        private BaseTablo _aileBilgileriTable;
        private BaseTablo _sinavBilgileriTable;
        private BaseTablo _evrakBilgileriTable;
        private BaseTablo _promosyonBilgileriTable;
        private BaseTablo _iletisimBilgileriTable;
        private BaseTablo _eposBilgileriTable;
        private BaseTablo _bilgiNotlariTable;

        #endregion

        #region Functions
        public TahakkukEditForm()
        {
            InitializeComponent();
            DataLayoutControls = new[] { dataLayoutGenel, dataLayoutGenelBilgiler };
            Bll = new TahakkukBll(dataLayoutGenelBilgiler); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Tahakkuk;    //Kartturu form isimleri için
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            ShowItems = new BarItem[] { btnYazdir };

            txtKayitSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitSekli>());
            txtKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitDurumu>());
            txtSonrakiDonemKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<SonrakiDonemKayitDurumu>());

            txtKayitTarihi.Properties.MinValue = AnaForm.DonemParametreleri.DonemBaslamaTarihi;
            txtKayitTarihi.Properties.MaxValue = AnaForm.DonemParametreleri.DonemBitisTarihi;

            btnYazdir.Caption = "Kayıt Evrakları";
            KayitSonrasiFormuKapat = false;
        }

        public TahakkukEditForm(params object[] prm) : this()
        {
            //bu forma gelen "prm[0]" parametresi "ogrenci" tablosundan geliyorsa ogrenci olarak al. "bool" olarak geliyorsa bool olarak al
            if (prm[0] is Ogrenci ogr)
            {
                _ogrenci = ogr;
            }
            else if (prm[0] is bool b)
            {
                FarkliSubeIslemi = b;
            }
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new TahakkukSingle() : ((TahakkukBll)Bll).Single(FilterFunctions.Filter<Tahakkuk>(Id));
            NesneyiKontrollereBagla();
            BagliTablolariYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((TahakkukBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override void BagliTablolariYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }

            if (_kardesBilgileriTable != null && TableValueChanged(_kardesBilgileriTable))
            {
                _kardesBilgileriTable.Yukle();
            }

            if (_aileBilgileriTable != null && TableValueChanged(_aileBilgileriTable))
            {
                _aileBilgileriTable.Yukle();
            }

            if (_sinavBilgileriTable != null && TableValueChanged(_sinavBilgileriTable))
            {
                _sinavBilgileriTable.Yukle();
            }

            if (_evrakBilgileriTable != null && TableValueChanged(_evrakBilgileriTable))
            {
                _evrakBilgileriTable.Yukle();
            }

            if (_promosyonBilgileriTable != null && TableValueChanged(_promosyonBilgileriTable))
            {
                _promosyonBilgileriTable.Yukle();
            }

            if (_iletisimBilgileriTable != null && TableValueChanged(_iletisimBilgileriTable))
            {
                _iletisimBilgileriTable.Yukle();
            }

            if (_eposBilgileriTable != null && TableValueChanged(_eposBilgileriTable))
            {
                _eposBilgileriTable.Yukle();
            }

            if (_bilgiNotlariTable != null && TableValueChanged(_bilgiNotlariTable))
            {
                _bilgiNotlariTable.Yukle();
            }

            if (hizmetBilgileriTable.OwnerForm == null)
            {
                hizmetBilgileriTable.OwnerForm = this;
                hizmetBilgileriTable.Yukle();
            }
            if (indirimBilgileriTable.OwnerForm == null)
            {
                indirimBilgileriTable.OwnerForm = this;
                indirimBilgileriTable.Yukle();
            }

            if (odemeBilgileriTable.OwnerForm == null)
            {
                odemeBilgileriTable.OwnerForm = this;
                odemeBilgileriTable.Yukle();
                odemeBilgileriTable.insUpNavigator.Navigator.TextLocation = NavigatorButtonsTextLocation.Begin;
                odemeBilgileriTable.insUpNavigator.Navigator.TextStringFormat = "Taksit ( {0} / {1} )";
                odemeBilgileriTable.insUpNavigator.Navigator.Appearance.ForeColor = SystemColors.HotTrack;
            }

            if (geriOdemeBilgileriTable.OwnerForm == null)
            {
                geriOdemeBilgileriTable.OwnerForm = this;
                geriOdemeBilgileriTable.Yukle();
            }

            if (TableValueChanged(hizmetBilgileriTable))
            {
                var rowHandle = hizmetBilgileriTable.Tablo.FocusedRowHandle;
                hizmetBilgileriTable.Yukle();
                hizmetBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }

            if (TableValueChanged(indirimBilgileriTable))
            {
                var rowHandle = indirimBilgileriTable.Tablo.FocusedRowHandle;
                indirimBilgileriTable.Yukle();
                indirimBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }

            if (TableValueChanged(odemeBilgileriTable))
            {
                var rowHandle = odemeBilgileriTable.Tablo.FocusedRowHandle;
                odemeBilgileriTable.Yukle();
                odemeBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }

            if (TableValueChanged(geriOdemeBilgileriTable))
            {
                var rowHandle = geriOdemeBilgileriTable.Tablo.FocusedRowHandle;
                geriOdemeBilgileriTable.Yukle();
                geriOdemeBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }

            Toplamlar();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (TahakkukSingle)OldEntity;

            txtTcKimlikNo.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.TcKimlikNo : entity.TcKimlikNo;
            txtAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Adi : entity.Adi;
            txtSoyadi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Soyadi : entity.Soyadi;
            txtBabaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.BabaAdi : entity.BabaAdi;
            txtAnaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.AnaAdi : entity.AnaAdi;
            txtDurum.Text = entity.Durum ? IptalDurumu.DevamEdiyor.ToName() : IptalDurumu.IptalEdildi.ToName();
            txtKod.Text = entity.Kod;
            txtOkulNo.Text = entity.OkulNo;
            txtKayitTarihi.DateTime = entity.KayitTarihi;
            txtKayitSekli.SelectedItem = entity.KayitSekli.ToName();
            txtKayitDurumu.SelectedItem = entity.KayitDurumu.ToName();
            txtSinif.Id = entity.SinifId;
            txtSinif.Text = entity.SinifAdi;
            txtYabanciDil.Id = entity.YabanciDilId;
            txtYabanciDil.Text = entity.YabanciDilAdi;
            txtGeldigiOkul.Id = entity.GeldigiOkulId;
            txtGeldigiOkul.Text = entity.GeldigiOkulAdi;
            txtKontenjan.Id = entity.KontenjanId;
            txtKontenjan.Text = entity.KontenjanAdi;
            txtTesvik.Id = entity.TesvikId;
            txtTesvik.Text = entity.TesvikAdi;
            txtRehber.Id = entity.RehberId;
            txtRehber.Text = entity.RehberAdi;
            txtSonrakiDonemKayitDurumu.SelectedItem = entity.SonrakiDonemKayitDurumu.ToName();
            txtSonrakiDonemKayitDurumuAciklamasi.Text = entity.SonrakiDonemKayitDurumuAciklamasi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = txtOzelKod2.Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod4.Id = txtOzelKod4.Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Tahakkuk
            {
                Id = Id,
                Kod = txtKod.Text,
                OgrenciId = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Id : ((TahakkukSingle)OldEntity).OgrenciId,
                OkulNo = txtOkulNo.Text,
                KayitTarihi = txtKayitTarihi.DateTime.Date,
                KayitSekli = txtKayitSekli.Text.GetEnum<KayitSekli>(),
                KayitDurumu = txtKayitDurumu.Text.GetEnum<KayitDurumu>(),
                SinifId = Convert.ToInt64(txtSinif.Id),
                YabanciDilId = txtYabanciDil.Id,
                GeldigiOkulId = txtGeldigiOkul.Id,
                KontenjanId = txtKontenjan.Id,
                TesvikId = txtTesvik.Id,
                RehberId = txtRehber.Id,
                SonrakiDonemKayitDurumu = txtSonrakiDonemKayitDurumu.Text.GetEnum<SonrakiDonemKayitDurumu>(),
                SonrakiDonemKayitDurumuAciklamasi = txtSonrakiDonemKayitDurumuAciklamasi.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum = txtDurum.Text.GetEnum<IptalDurumu>() == IptalDurumu.DevamEdiyor,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            if (!DurumKontrol()) return false;

            if (BaglitabloHataliGirisKontrol()) return false;

            var result = ((TahakkukBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
            {
                BagliTablolariYukle();
            }

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (!DurumKontrol()) return false;
            if (BaglitabloHataliGirisKontrol()) return false;

            var result = ((TahakkukBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
            {
                BagliTablolariYukle();
            }

            return result;
        }

        protected override bool BaglitabloHataliGirisKontrol()
        {
            if (_sinavBilgileriTable != null && _sinavBilgileriTable.HataliGiris())
            {
                tabUst.SelectedPage = pageAileSinavBilgileri;  //tab sekmesine focus
                _sinavBilgileriTable.Tablo.GridControl.Focus(); // tabloya focus
                return true;
            }

            if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.HataliGiris())
            {
                tabUst.SelectedPage = pageIletisimBilgileri;  //tab sekmesine focus
                _iletisimBilgileriTable.Tablo.GridControl.Focus(); // tabloya focus
                return true;
            }

            if (_eposBilgileriTable != null && _eposBilgileriTable.HataliGiris())
            {
                tabUst.SelectedPage = pageEposBilgileri;  //tab sekmesine focus
                _eposBilgileriTable.Tablo.GridControl.Focus(); // tabloya focus
                return true;
            }

            if (_bilgiNotlariTable != null && _bilgiNotlariTable.HataliGiris())
            {
                tabUst.SelectedPage = pageNotlar;  //tab sekmesine focus
                _bilgiNotlariTable.Tablo.GridControl.Focus(); // tabloya focus
                return true;
            }

            if (hizmetBilgileriTable.HataliGiris())
            {
                tabAlt.SelectedPage = pageHizmetBilgileri;  //tab sekmesine focus
                hizmetBilgileriTable.Tablo.GridControl.Focus(); // tabloya focus
                return true;
            }

            if (odemeBilgileriTable.HataliGiris())
            {
                tabAlt.SelectedPage = pageOdemeBilgileri;  //tab sekmesine focus
                odemeBilgileriTable.Tablo.GridControl.Focus(); // tabloya focus
                return true;
            }

            if (geriOdemeBilgileriTable.HataliGiris())
            {
                tabAlt.SelectedPage = pageGeriOdemeBilgileri;  //tab sekmesine focus
                geriOdemeBilgileriTable.Tablo.GridControl.Focus(); // tabloya focus
                return true;
            }

            return false;
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtSinif)
                {
                    sec.Sec(txtSinif);
                }
                else if (sender == txtYabanciDil)
                {
                    sec.Sec(txtYabanciDil);
                }
                else if (sender == txtGeldigiOkul)
                {
                    sec.Sec(txtGeldigiOkul);
                }
                else if (sender == txtKontenjan)
                {
                    sec.Sec(txtKontenjan);
                }
                else if (sender == txtTesvik)
                {
                    sec.Sec(txtTesvik);
                }
                else if (sender == txtRehber)
                {
                    sec.Sec(txtRehber);
                }
                else if (sender == txtOzelKod1)
                {
                    sec.Sec(txtOzelKod1, KartTuru.Tahakkuk);
                }
                else if (sender == txtOzelKod2)
                {
                    sec.Sec(txtOzelKod2, KartTuru.Tahakkuk);
                }
                else if (sender == txtOzelKod3)
                {
                    sec.Sec(txtOzelKod3, KartTuru.Tahakkuk);
                }
                else if (sender == txtOzelKod4)
                {
                    sec.Sec(txtOzelKod4, KartTuru.Tahakkuk);
                }
                else if (sender == txtOzelKod5)
                {
                    sec.Sec(txtOzelKod5, KartTuru.Tahakkuk);
                }
            }
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                //eğer _kardesBilgileriTable boş değilse ve _kardesBilgileriTable tablosunda değişiklik olmuş ise true yap. 
                if (_kardesBilgileriTable != null && _kardesBilgileriTable.TableValueChanged) return true;
                if (_aileBilgileriTable != null && _aileBilgileriTable.TableValueChanged) return true;
                if (_sinavBilgileriTable != null && _sinavBilgileriTable.TableValueChanged) return true;
                if (_evrakBilgileriTable != null && _evrakBilgileriTable.TableValueChanged) return true;
                if (_promosyonBilgileriTable != null && _promosyonBilgileriTable.TableValueChanged) return true;
                if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.TableValueChanged) return true;
                if (_eposBilgileriTable != null && _eposBilgileriTable.TableValueChanged) return true;
                if (_bilgiNotlariTable != null && _bilgiNotlariTable.TableValueChanged) return true;
                if (hizmetBilgileriTable.TableValueChanged) return true;
                if (indirimBilgileriTable.TableValueChanged) return true;
                if (odemeBilgileriTable.TableValueChanged) return true;
                if (geriOdemeBilgileriTable.TableValueChanged) return true;

                return false;
            }

            if (hizmetBilgileriTable.TableValueChanged || indirimBilgileriTable.TableValueChanged || odemeBilgileriTable.TableValueChanged || geriOdemeBilgileriTable.TableValueChanged)
            {
                Toplamlar();
            }

            if (FarkliSubeIslemi)
            {
                Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil);
            }
            else
            {
                Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, NewEntity, TableValueChanged());
            }
        }

        protected override bool BagliTabloKaydet()
        {
            if (_kardesBilgileriTable != null && !_kardesBilgileriTable.Kaydet()) return false;
            if (_aileBilgileriTable != null && !_aileBilgileriTable.Kaydet()) return false;
            if (_sinavBilgileriTable != null && !_sinavBilgileriTable.Kaydet()) return false;
            if (_evrakBilgileriTable != null && !_evrakBilgileriTable.Kaydet()) return false;
            if (_promosyonBilgileriTable != null && !_promosyonBilgileriTable.Kaydet()) return false;
            if (_iletisimBilgileriTable != null && !_iletisimBilgileriTable.Kaydet()) return false;
            if (_eposBilgileriTable != null && !_eposBilgileriTable.Kaydet()) return false;
            if (_bilgiNotlariTable != null && !_bilgiNotlariTable.Kaydet()) return false;
            if (!hizmetBilgileriTable.Kaydet()) return false;
            if (!indirimBilgileriTable.Kaydet()) return false;
            if (!odemeBilgileriTable.Kaydet()) return false;
            if (!geriOdemeBilgileriTable.Kaydet()) return false;

            return true;
        }

        private void Toplamlar()
        {
            var hizmetBilgileriToplami = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriList>().Where(x => !x.Delete).Sum(x => x.BrutUcret - x.KistDonemDusulenUcret);
            var indirimBilgileriToplami = indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => !x.Delete).Sum(x => x.BrutIndirim - x.KistDonemDusulenIndirim);
            var odemeBilgileriToplami = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<OdemeBilgileriList>().Where(x => !x.Delete).Sum(x => x.Tutar);
            var geriIadelerToplami = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<OdemeBilgileriList>().Where(x => !x.Delete).Sum(x => x.Iade);
            var geriOdemelerToplami = geriOdemeBilgileriTable.Tablo.DataController.ListSource.Cast<GeriOdemeBilgileriList>().Where(x => !x.Delete).Sum(x => x.Tutar);

            txtHizmetBilgileriToplami.Value = hizmetBilgileriToplami;
            txtIndirimBilgileriToplami.Value = indirimBilgileriToplami;
            txtOdemeBilgileriToplami.Value = odemeBilgileriToplami;
            txtGeriIadelerToplami.Value = geriIadelerToplami;
            txtGeriOdemelerToplami.Value = geriOdemelerToplami;

            txtFark.Value = hizmetBilgileriToplami - indirimBilgileriToplami - (odemeBilgileriToplami - (geriIadelerToplami + geriOdemelerToplami));
            txtFark.Properties.Appearance.BackColor = txtFark.Value != 0 ? Color.IndianRed : Color.GreenYellow;
        }

        private bool DurumKontrol()
        {
            if (txtFark.Value != 0)
            {
                Messages.HataMesaji("Ücret toplamlarının farkı sıfır(0) olmalıdır.");
                return false;
            }

            var source = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriList>();
            if (!source.Any(x => !x.Delete && !x.IptalEdildi && x.HizmetTipi == HizmetTipi.Egitim))
            {
                Messages.UyariMesaji("Eğitim hizmeti alınmadığı için tahakkuk pasif duruma alınacaktır.");
                txtDurum.Text = IptalDurumu.IptalEdildi.ToName();
            }
            else
            {
                txtDurum.Text = IptalDurumu.DevamEdiyor.ToName();
            }
            return true;
        }

        protected override void Yazdir()
        {
            if (pageIletisimBilgileri.Controls.Count == 0)
            {
                _iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
                pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
                _iletisimBilgileriTable.Yukle();
            }

            if (pageEposBilgileri.Controls.Count == 0)
            {
                _eposBilgileriTable = new EposBilgileriTable().AddTable(this);
                pageEposBilgileri.Controls.Add(_eposBilgileriTable);
                _eposBilgileriTable.Yukle();
            }

            var ogrenciBilgileri = ((TahakkukBll)Bll).SingleDetail(x => x.Id == Id);
            var iletisimBilgileri = _iletisimBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<IletisimBilgileriRapor>();
            var hizmetBilgileri = hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<HizmetBilgileriRapor>();
            var indirimBilgileri = indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<IndirimBilgileriRapor>();
            var odemeBilgileri = odemeBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<OdemeBilgileriRapor>();
            var geriOdemeBilgileri = geriOdemeBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<GeriOdemeBilgileriRapor>();
            var eposBilgileri = _eposBilgileriTable.Tablo.DataController.ListSource.Cast<IBaseEntity>().EntityListConvert<EposBilgileriRapor>();
            ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, false, RaporBolumTuru.TahakkukRaporlari, ogrenciBilgileri, iletisimBilgileri, hizmetBilgileri, indirimBilgileri, odemeBilgileri, geriOdemeBilgileri, eposBilgileri);
        }

        #endregion

        #region Events
        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
            {
                txtOkulNo.Focus();
                txtOkulNo.SelectAll();
            }
            else if (e.Page == pageKardesBilgileri)
            {
                if (pageKardesBilgileri.Controls.Count == 0)
                {
                    _kardesBilgileriTable = new KardesBilgileriTable().AddTable(this);
                    pageKardesBilgileri.Controls.Add(_kardesBilgileriTable);
                    _kardesBilgileriTable.Yukle();
                }
                _kardesBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageAileSinavBilgileri)
            {
                if (layoutControlAileSinavBilgileri.Items.Count == 0)
                {
                    _aileBilgileriTable = new AileBilgileriTable().AddTable(this);
                    layoutControlAileSinavBilgileri.LayoutControlInsert(_aileBilgileriTable, 0, 0, 0, 0);
                    _aileBilgileriTable.Yukle();

                    _sinavBilgileriTable = new SinavBilgileriTable().AddTable(this);
                    layoutControlAileSinavBilgileri.LayoutControlInsert(_sinavBilgileriTable, 1, 0, 0, 0);
                    _sinavBilgileriTable.Yukle();
                }
                _aileBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageEvrakPromosyonBilgileri)
            {
                if (layoutControlEvrakPromosyonBilgileri.Items.Count == 0)
                {
                    _evrakBilgileriTable = new EvrakBilgileriTable().AddTable(this);
                    layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_evrakBilgileriTable, 0, 0, 0, 0);
                    _evrakBilgileriTable.Yukle();

                    _promosyonBilgileriTable = new PromosyonBilgileriTable().AddTable(this);
                    layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_promosyonBilgileriTable, 1, 0, 0, 0);
                    _promosyonBilgileriTable.Yukle();
                }
                _evrakBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageIletisimBilgileri)
            {
                if (pageIletisimBilgileri.Controls.Count == 0)
                {
                    _iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
                    pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
                    _iletisimBilgileriTable.Yukle();
                }
                _iletisimBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageEposBilgileri)
            {
                if (pageEposBilgileri.Controls.Count == 0)
                {
                    _eposBilgileriTable = new EposBilgileriTable().AddTable(this);
                    pageEposBilgileri.Controls.Add(_eposBilgileriTable);
                    _eposBilgileriTable.Yukle();
                }
                _eposBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageNotlar)
            {
                if (pageNotlar.Controls.Count == 0)
                {
                    _bilgiNotlariTable = new BilgiNotlariTable().AddTable(this);
                    pageNotlar.Controls.Add(_bilgiNotlariTable);
                    _bilgiNotlariTable.Yukle();
                }
                _bilgiNotlariTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageHizmetBilgileri)
            {
                hizmetBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageIndirimBilgileri)
            {
                indirimBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageOdemeBilgileri)
            {
                odemeBilgileriTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageGeriOdemeBilgileri)
            {
                geriOdemeBilgileriTable.Tablo.GridControl.Focus();
            }
        }

        #endregion
    }
}