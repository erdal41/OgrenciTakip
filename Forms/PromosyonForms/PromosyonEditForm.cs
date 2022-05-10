using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;

namespace OgrenciTakip.UI.Win.Forms.PromosyonForms
{
    public partial class PromosyonEditForm : BaseEditForm
    {
        public PromosyonEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PromosyonBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Promosyon;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Promosyon() : ((PromosyonBll)Bll).Single(FilterFunctions.Filter<Promosyon>(Id));
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur -- Promosyon için sube ve donem idleri eşitse o donem ve şubeye ait Promosyonlar gelecektir.
            txtKod.Text = ((PromosyonBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

            //txte focuslanır
            txtPromosyonAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Promosyon)OldEntity;

            txtKod.Text = entity.Kod;
            txtPromosyonAdi.Text = entity.PromosyonAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Promosyon
            {
                Id = Id,
                Kod = txtKod.Text,
                PromosyonAdi = txtPromosyonAdi.Text,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((PromosyonBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((PromosyonBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}