using DevExpress.XtraEditors;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Data.Contexts;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;
using System.Security;

namespace OgrenciTakip.UI.Yonetim.Forms.GenelForms
{
    public partial class KurumEditForm : BaseEditForm
    {
        #region Variables

        //readonly olan değişkenler saltokunur yani contractor harici bir yerde  veri ataması yapamayız. Sadece okuma işlemi yaparız.
        private readonly string _server;
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;
        private readonly YetkilendirmeTuru _yetkilendirmeTuru;

        #endregion

        public KurumEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KurumBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Kurum;    //Kartturu form isimleri için
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();

            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];
            txtYetkilendirmeTuru.SelectedItem = _yetkilendirmeTuru.ToName();
        }

        #region Functions

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kurum() : ((KurumBll)Bll).Single(FilterFunctions.Filter<Kurum>(Id));
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = "Yeni_Kurum";
            txtKod.Enabled = true;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kurum)OldEntity;

            txtKod.Text = entity.Kod;
            txtKurumAdi.Text = entity.KurumAdi;
            txtServer.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _server : entity.Server;
            txtYetkilendirmeTuru.SelectedItem = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>();
            txtKullaniciAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _kullaniciAdi.ConvertToUnSecureString() : entity.KullaniciAdi.Decrypt(entity.Id + entity.Kod);
            txtSifre.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _sifre.ConvertToUnSecureString() : entity.Sifre.Decrypt(entity.Id + entity.Kod);
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Kurum
            {
                Id = Id,
                Kod = txtKod.Text,
                KurumAdi = txtKurumAdi.Text,
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
            };
            ((Kurum)NewEntity).KullaniciAdi = txtKullaniciAdi.Text.Encrypt(NewEntity.Id + NewEntity.Kod);
            ((Kurum)NewEntity).Sifre = txtSifre.Text.Encrypt(NewEntity.Id + NewEntity.Kod);

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            //SqlServer bağlantı kontrolü
            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>())) return false;
            Win.Functions.GeneralFunctions.CreateConnectionString(txtKod.Text, txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            //Sqlserver database oluşturma işlemi
            if (!Functions.GeneralFunctions.CreateDatabase<OgrenciTakipContext>("Lütfen Bekleyiniz", "Kurum veritabanı oluşturuluyor...", $"'{txtKurumAdi.Text}' isimli kurum veritabanı oluşturulucaktır. Onaylıyor musunuz?", $"'{txtKurumAdi.Text}' isimli kurum veritabanı başarılı bir şekilde oluşturuldu.")) return false;
            Win.Functions.GeneralFunctions.CreateConnectionString("OgrenciTakipYonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            return base.EntityInsert();
        }

        protected override bool EntityUpdate()
        {
            //SqlServer bağlantı kontrolü
            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>())) return false;

            Win.Functions.GeneralFunctions.CreateConnectionString("OgrenciTakipYonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            return base.EntityUpdate();
        }

        #endregion

        #region Events

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;

            var yetkilendirmeTuru = edit.Text.GetEnum<YetkilendirmeTuru>();

            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        #endregion
    }
}