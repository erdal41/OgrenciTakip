using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System.Security;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciEditForm : BaseEditForm
    {
        #region Variables

        private string _sifre;
        private string _gizliKelime;
        private SecureString _secureSifre;
        private SecureString _secureGizliKelime;
        private bool _tekrarGonder;

        #endregion

        public KullaniciEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Kullanici;    //Kartturu form isimleri ve yetki için
            ShowItems = new BarItem[] { btnSifreSifirla };
            EventsLoad();
        }

        #region Functions

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KullaniciSingle
                () : ((KullaniciBll)Bll).Single(FilterFunctions.Filter<Kullanici>(Id));
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            txtKullaniciAdi.Focus();

            btnSifreSifirla.Enabled = false;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciSingle)OldEntity;

            txtKullaniciAdi.Text = entity.Kod;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtEmail.Text = entity.Email;
            txtRol.Id = entity.RolId;
            txtRol.Text = entity.RolAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Kullanici
            {
                Id = Id,
                Kod = txtKullaniciAdi.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Email = txtEmail.Text,
                Sifre = _sifre,
                GizliKelime = _gizliKelime,
                RolId = (long)txtRol.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            SifreUret();

            var result = base.EntityInsert();

            if (result)
            {
                txtKullaniciAdi.Text.SifreMailiGonder(txtRol.Text, txtEmail.Text, _secureSifre, _secureGizliKelime);
            }

            return result;
        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();

            if (_tekrarGonder)
            {
                txtKullaniciAdi.Text.SifreMailiGonder(txtRol.Text, txtEmail.Text, _secureSifre, _secureGizliKelime);
            }

            return result;
        }

        private void SifreUret()
        {
            var result = GeneralFunctions.SifreUret();

            _sifre = result.sifre;
            _gizliKelime = result.gizliKelime;
            _secureSifre = result.secureSifre;
            _secureGizliKelime = result.secureGizliKelime;

            GuncelNesneOlustur();
        }

        public override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayMesaji() != DialogResult.Yes) return;

            _tekrarGonder = true;
            SifreUret();
            btnKaydet.PerformClick();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtRol)
                {
                    sec.Sec(txtRol);
                }
            }
        }

        #endregion
    }
}