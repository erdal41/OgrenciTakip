using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.IsyeriForms
{
    public partial class IsyeriEditForm : BaseEditForm
    {
        public IsyeriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IsyeriBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Isyeri;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Isyeri() : ((IsyeriBll)Bll).Single(FilterFunctions.Filter<Isyeri>(Id)); 
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((IsyeriBll)Bll).YeniKodVer();

            //txte focuslanır
            txtIsyeriAdi.Focus(); 
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Isyeri)OldEntity;

            txtKod.Text = entity.Kod;
            txtIsyeriAdi.Text = entity.IsyeriAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Isyeri
            {
                Id = Id,
                Kod = txtKod.Text,
                IsyeriAdi = txtIsyeriAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }
    }
}