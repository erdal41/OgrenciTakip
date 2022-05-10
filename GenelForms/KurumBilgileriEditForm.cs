using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;

namespace OgrenciTakip.UI.Win.GenelForms
{
    public partial class KurumBilgileriEditForm : BaseEditForm
    {
        #region Variables

        private readonly string _kod;
        private readonly string _kurumAdi;

        #endregion

        public KurumBilgileriEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KurumBilgileriBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            HideItems = new BarItem[] { btnYeni, btnSil };
            EventsLoad();

            _kod = prm[0].ToString();
            _kurumAdi = prm[1].ToString();
        }

        #region Functions

        public override void Yukle()
        {
            //Bu form direk edit olarak açıldığı için farklı bir sorgulama metodu yaptık. OldEntity bağlı olan Bll'deki kullaniciId parametresi giriş yapan kullanıcının Id'sine eşit ise o kullanıcının verilerini yukler. Ama yeni kullanıcı kayıt olup giriş yapmışsa yani null ise KullaniciParametreSingle'deki varsayılan verileri çeker.
            OldEntity = ((KurumBilgileriBll)Bll).Single(null) ?? new KurumBilgileriSingle();

            // OldEntity bağlı olan Bll'deki kullaniciId parametresi giriş yapan kullanıcının Id'sine eşit ise OldEntity sıfır(0) gelmeyecek ve güncelleme yapacak. Ama yeni kullanıcı kayıt olup giriş yapmışsa sıfır(0) gelecek ve kaydetme işlemini yapacak.
            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            txtKod.Text = _kod;
            txtKurumAdi.Text = _kurumAdi;
            txtKurumAdi.Focus();
        }

        //Kontrollere Kayıt çek
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KurumBilgileriSingle)OldEntity;

            Id = entity.Id;
            txtKod.Text = entity.Kod;
            txtKurumAdi.Text = entity.KurumAdi;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtVergiNo.Text = entity.VergiNo;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
        }

        //Kayıt Ekle
        protected override void GuncelNesneOlustur()
        {
            NewEntity = new KurumBilgileri
            {
                Id = Id,
                Kod = txtKod.Text,
                KurumAdi = txtKurumAdi.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
            };

            ButtonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtIl)
                {
                    sec.Sec(txtIl);
                }
                else if (sender == txtIlce)
                {
                    sec.Sec(txtIlce, txtIl);
                }
            }
        }

        #endregion

        #region Events

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtIl) return;

            txtIl.ControlEnabledChange(txtIlce);
        }

        #endregion
    }
}