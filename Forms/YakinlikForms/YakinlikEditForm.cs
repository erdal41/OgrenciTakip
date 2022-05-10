using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.YakinlikForms
{
    public partial class YakinlikEditForm : BaseEditForm
    {
        public YakinlikEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new YakinlikBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Yakinlik;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Yakinlik() : ((YakinlikBll)Bll).Single(FilterFunctions.Filter<Yakinlik>(Id)); 
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((YakinlikBll)Bll).YeniKodVer();

            //txte focuslanır
            txtYakinlikAdi.Focus(); 
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Yakinlik)OldEntity;

            txtKod.Text = entity.Kod;
            txtYakinlikAdi.Text = entity.YakinlikAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Yakinlik
            {
                Id = Id,
                Kod = txtKod.Text,
                YakinlikAdi = txtYakinlikAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }
    }
}