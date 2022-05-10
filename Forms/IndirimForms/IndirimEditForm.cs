using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.IndirimForms
{
    public partial class IndirimEditForm : BaseEditForm
    {
        public IndirimEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IndirimBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Indirim;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IndirimSingle() : ((IndirimBll)Bll).Single(FilterFunctions.Filter<Indirim>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IndirimBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtIndirimAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IndirimSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtIndirimAdi.Text = entity.IndirimAdi;
            txtIndirimTuru.Id = entity.IndirimTuruId;
            txtIndirimTuru.Text = entity.IndirimTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Indirim
            {
                Id = Id,
                Kod = txtKod.Text,
                IndirimAdi = txtIndirimAdi.Text,
                IndirimTuruId = Convert.ToInt64(txtIndirimTuru.Id),
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, NewEntity, hizmetTablo.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            if (hizmetTablo.HataliGiris()) return false;
            return ((IndirimBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && hizmetTablo.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (hizmetTablo.HataliGiris()) return false;
            return ((IndirimBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && hizmetTablo.Kaydet();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtIndirimTuru)
                {
                    sec.Sec(txtIndirimTuru);
                }
            }
        }

        protected override void TabloYukle()
        {
            hizmetTablo.OwnerForm = this;
            hizmetTablo.Yukle();
        }
    }
}