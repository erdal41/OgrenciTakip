using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.RaporForms
{
    public partial class RaporEditForm : BaseEditForm
    {
        #region Variables

        private readonly KartTuru _raporTuru;
        private readonly RaporBolumTuru _raporBolumTuru;
        private readonly byte[] _dosya;

        #endregion

        public RaporEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new RaporBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Rapor;    //Kartturu form isimleri için
            EventsLoad();

            _raporTuru = (KartTuru)prm[0];
            _raporBolumTuru = (RaporBolumTuru)prm[1];
            _dosya = (byte[])prm[2];
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rapor() : ((RaporBll)Bll).Single(FilterFunctions.Filter<Rapor>(Id));
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((RaporBll)Bll).YeniKodVer(x => x.RaporBolumTuru == _raporBolumTuru && x.RaporTuru == _raporTuru);

            //txte focuslanır
            txtRaporAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rapor)OldEntity;

            txtKod.Text = entity.Kod;
            txtRaporAdi.Text = entity.RaporAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Rapor
            {
                Id = Id,
                Kod = txtKod.Text,
                RaporAdi = txtRaporAdi.Text,
                RaporTuru = _raporTuru,
                RaporBolumTuru = _raporBolumTuru,
                Dosya = _dosya,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((RaporBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.RaporBolumTuru == _raporBolumTuru && x.RaporTuru == _raporTuru);
        }

        protected override bool EntityUpdate()
        {
            return ((RaporBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.RaporBolumTuru == _raporBolumTuru && x.RaporTuru == _raporTuru);
        }
    }
}