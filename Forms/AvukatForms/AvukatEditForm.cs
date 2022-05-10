using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;

namespace OgrenciTakip.UI.Win.Forms.AvukatForms
{
    public partial class AvukatEditForm : BaseEditForm
    {
        public AvukatEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new AvukatBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Avukat;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AvukatSingle() : ((AvukatBll)Bll).Single(FilterFunctions.Filter<Avukat>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AvukatBll)Bll).YeniKodVer();
            txtAdiSoyadi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AvukatSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtAdiSoyadi.Text = entity.AdiSoyadi;
            txtSozlesmeNo.Text = entity.SozlesmeNo;
            txtBaslamaTarihi.EditValue = entity.SozlesmeBaslamaTarihi;
            txtBitisTarihi.EditValue = entity.SozlesmeBitisTarihi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Avukat
            {
                Id = Id,
                Kod = txtKod.Text,
                AdiSoyadi = txtAdiSoyadi.Text,
                SozlesmeNo = txtSozlesmeNo.Text,
                SozlesmeBaslamaTarihi = (DateTime?)txtBaslamaTarihi.EditValue,
                SozlesmeBitisTarihi = (DateTime?)txtBitisTarihi.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOzelKod1)
                {
                    sec.Sec(txtOzelKod1, KartTuru.Avukat);
                }
                else if(sender == txtOzelKod2)
                {
                    sec.Sec(txtOzelKod2, KartTuru.Avukat);
                }
            }
        }
    }
}