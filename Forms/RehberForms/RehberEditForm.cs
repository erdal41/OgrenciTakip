using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.RehberForms
{
    public partial class RehberEditForm : BaseEditForm
    {
        public RehberEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new RehberBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Rehber;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rehber() : ((RehberBll)Bll).Single(FilterFunctions.Filter<Rehber>(Id)); 
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((RehberBll)Bll).YeniKodVer();

            //txte focuslanır
            txtAdiSoyadi.Focus(); 
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rehber)OldEntity;

            txtKod.Text = entity.Kod;
            txtAdiSoyadi.Text = entity.AdiSoyadi;
            txtTelefon1.Text = entity.Telefon1;
            txtTelefon2.Text = entity.Telefon2;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Rehber
            {
                Id = Id,
                Kod = txtKod.Text,
                AdiSoyadi = txtAdiSoyadi.Text,
                Telefon1 = txtTelefon1.Text,
                Telefon2 =txtTelefon2.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }
    }
}