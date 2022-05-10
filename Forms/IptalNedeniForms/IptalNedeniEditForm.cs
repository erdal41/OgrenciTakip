using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.IptalNedeniForms
{
    public partial class IptalNedeniEditForm : BaseEditForm
    {
        public IptalNedeniEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IptalNedeniBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.IptalNedeni;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IptalNedeni() : ((IptalNedeniBll)Bll).Single(FilterFunctions.Filter<IptalNedeni>(Id));
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((IptalNedeniBll)Bll).YeniKodVer();

            //txte focuslanır
            txtIptalNedeniAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IptalNedeni)OldEntity;

            txtKod.Text = entity.Kod;
            txtIptalNedeniAdi.Text = entity.IptalNedeniAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new IptalNedeni
            {
                Id = Id,
                Kod = txtKod.Text,
                IptalNedeniAdi = txtIptalNedeniAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }
    }
}