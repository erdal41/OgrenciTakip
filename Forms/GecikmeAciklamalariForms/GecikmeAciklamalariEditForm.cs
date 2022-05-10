using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    public partial class GecikmeAciklamalariEditForm : BaseEditForm
    {
        #region Variables

        private readonly int _odemeBilgileriId;

        #endregion

        public GecikmeAciklamalariEditForm(params object[] prm)
        {
            InitializeComponent();
            _odemeBilgileriId = (int)prm[0];

            DataLayoutControl = myDataLayoutControl;
            Bll = new GecikmeAciklamalariBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.GecikmeAciklamalari;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new GecikmeAciklamalariSingle() : ((GecikmeAciklamalariBll)Bll).Single(FilterFunctions.Filter<GecikmeAciklamalari>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((GecikmeAciklamalariBll)Bll).YeniKodVer(x => x.OdemeBilgileriId == _odemeBilgileriId);
            txtAciklama.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (GecikmeAciklamalariSingle)OldEntity;
            txtKod.Text = entity.Kod;
            txtKullaniciAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciAdi : entity.KullaniciAdi;
            txtTarihSaat.DateTime = BaseIslemTuru == IslemTuru.EntityInsert ? DateTime.Now : entity.TarihSaat;
            txtAciklama.Text = entity.Aciklama;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new GecikmeAciklamalari
            {
                Id = Id,
                Kod = txtKod.Text,
                OdemeBilgileriId = _odemeBilgileriId,
                KullaniciId = BaseIslemTuru == IslemTuru.EntityInsert ? AnaForm.KullaniciId : 0,
                TarihSaat = txtTarihSaat.DateTime,
                Aciklama = txtAciklama.Text,
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((GecikmeAciklamalariBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.OdemeBilgileriId == _odemeBilgileriId);
        }

        protected override bool EntityUpdate()
        {
            return ((GecikmeAciklamalariBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.OdemeBilgileriId == _odemeBilgileriId);
        }
    }
}