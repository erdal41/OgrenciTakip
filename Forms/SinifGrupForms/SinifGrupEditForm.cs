using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.SinifGrupForms
{
    public partial class SinifGrupEditForm : BaseEditForm
    {
        public SinifGrupEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SinifGrupBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.SinifGrup;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SinifGrup() : ((SinifGrupBll)Bll).Single(FilterFunctions.Filter<SinifGrup>(Id)); 
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((SinifGrupBll)Bll).YeniKodVer();

            //txte focuslanır
            txtGrupAdi.Focus(); 
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SinifGrup)OldEntity;

            txtKod.Text = entity.Kod;
            txtGrupAdi.Text = entity.GrupAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new SinifGrup
            {
                Id = Id,
                Kod = txtKod.Text,
                GrupAdi = txtGrupAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }
    }
}