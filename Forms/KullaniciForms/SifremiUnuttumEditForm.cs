using DevExpress.XtraBars;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class SifremiUnuttumEditForm : BaseEditForm
    {
        #region Variables

        private readonly string _kullaniciAdi;

        #endregion

        public SifremiUnuttumEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnGerial, btnSil };
            ShowItems = new BarItem[] { btnSifreSifirla };
            EventsLoad();

            _kullaniciAdi = prm[0].ToString();
        }

        #region Functions

        public override void Yukle()
        {
            txtKullaniciAdi.Text = _kullaniciAdi;
        }

        public override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayMesaji() != DialogResult.Yes) return;

            var entity = ((KullaniciBll)Bll).SingleDetail(x => x.Kod == txtKullaniciAdi.Text).EntityConvert<KullaniciSingle>();
            if (entity == null)
            {
                Messages.HataMesaji("Veritabanında böyle bir kullanıcı kaydı bulunmamaktadır.");
                return;
            }

            if (txtAdi.Text == entity.Adi && txtSoyadi.Text == entity.Soyadi && txtEmail.Text == entity.Email && txtGizliKelime.Text.Md5Sifrele() == entity.GizliKelime)
            {
                var result = Functions.GeneralFunctions.SifreUret();

                var newEntity = new Kullanici
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    Email = entity.Email,
                    RolId = entity.RolId,
                    Aciklama = entity.Aciklama,
                    Durum = entity.Durum,
                    Sifre = result.sifre,
                    GizliKelime = result.gizliKelime,
                };

                if (!((KullaniciBll)Bll).Update(entity, newEntity)) return;

                var sonuc = txtKullaniciAdi.Text.SifreMailiGonder(entity.RolAdi, entity.Email, result.secureSifre, result.secureGizliKelime);

                if (sonuc)
                {
                    Messages.BilgiMesaji("Şifre sıfırlama işlemi başarılı bir şekilde gerçekleşti.");
                    Close();
                }
                else
                {
                    Messages.HataMesaji("Şifre sıfırlama işlemi başarılı bir şekilde gerçekleşti. Ama E-Mail gönderilemedi. Lütfen tekrar deneyiniz.");
                }
            }
            else
            {
                Messages.HataMesaji("Girilen bilgiler mevcut bilgilerle uyuşmuyor. Lütfen kontrol edip tekrar deneyiniz.");
            }
        } 

        #endregion
    }
}