using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
    public partial class IndirimTuruEditForm : BaseEditForm
    {
        public IndirimTuruEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IndirimTuruBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.IndirimTuru;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IndirimTuru() : ((IndirimTuruBll)Bll).Single(FilterFunctions.Filter<IndirimTuru>(Id)); 
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((IndirimTuruBll)Bll).YeniKodVer();

            //txte focuslanır
            txtIndirimTuruAdi.Focus(); 
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IndirimTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtIndirimTuruAdi.Text = entity.IndirimTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new IndirimTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                IndirimTuruAdi = txtIndirimTuruAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }
    }
}