using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeEditForm : BaseEditForm
    {
        #region Variables

        private readonly long _bankaId;
        private readonly string _bankaAdi; 

        #endregion

        public BankaSubeEditForm(params object[] prm)
        {
            InitializeComponent();

            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankaSubeBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.BankaSube;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaSube() : ((BankaSubeBll)Bll).Single(FilterFunctions.Filter<BankaSube>(Id));
            NesneyiKontrollereBagla();

            Text += $" - ( {_bankaAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaSubeBll)Bll).YeniKodVer(x => x.BankaId == _bankaId);
            txtBankaSubeAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaSube)OldEntity;
            txtKod.Text = entity.Kod;
            txtBankaSubeAdi.Text = entity.BankaSubeAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new BankaSube
            {
                Id = Id,
                Kod = txtKod.Text,
                BankaSubeAdi = txtBankaSubeAdi.Text,
                BankaId = _bankaId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((BankaSubeBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.BankaId == _bankaId);
        }

        protected override bool EntityUpdate()
        {
            return ((BankaSubeBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.BankaId == _bankaId);
        }
    }
}