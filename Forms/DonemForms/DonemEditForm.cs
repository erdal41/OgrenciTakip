using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.DonemForms
{
    public partial class DonemEditForm : BaseEditForm
    {
        public DonemEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new DonemBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Donem;    //Kartturu form isimleri ve yetki için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Donem() : ((DonemBll)Bll).Single(FilterFunctions.Filter<Donem>(Id)); 
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((DonemBll)Bll).YeniKodVer();

            //txte focuslanır
            txtDonemAdi.Focus(); 
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Donem)OldEntity;

            txtKod.Text = entity.Kod;
            txtDonemAdi.Text = entity.DonemAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Donem
            {
                Id = Id,
                Kod = txtKod.Text,
                DonemAdi = txtDonemAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }
    }
}