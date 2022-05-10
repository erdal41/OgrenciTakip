using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace OgrenciTakip.UI.Win.Forms.SubeForms
{
    public partial class SubeEditForm : BaseEditForm
    {
        public SubeEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SubeBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Sube;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SubeSingle() : ((SubeBll)Bll).Single(FilterFunctions.Filter<Sube>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SubeBll)Bll).YeniKodVer();
            txtSubeAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SubeSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtSubeAdi.Text = entity.SubeAdi;
            txtGrupAdi.Text = entity.GrupAdi;
            txtSiraNo.EditValue = entity.SiraNo;
            txtTelefon.Text = entity.Telefon;
            txtFax.Text = entity.Fax;
            txtIbanNo.Text = entity.IbanNo;
            txtAdres.Text = entity.Adres;
            txtAdresIl.Id = entity.AdresIlId;
            txtAdresIl.Text = entity.AdresIlAdi;
            txtAdresIlce.Id = entity.AdresIlceId;
            txtAdresIlce.Text = entity.AdresIlceAdi;
            imgLogo.EditValue = entity.Logo;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Sube
            {
                Id = Id,
                Kod = txtKod.Text,
                SubeAdi = txtSubeAdi.Text,
                GrupAdi = txtGrupAdi.Text,
                SiraNo = (int)txtSiraNo.Value,
                Telefon = txtTelefon.Text,
                Fax = txtFax.Text,
                IbanNo = txtIbanNo.Text,
                Adres = txtAdres.Text,
                AdresIlId = Convert.ToInt64(txtAdresIl.Id),
                AdresIlceId = Convert.ToInt64(txtAdresIlce.Id),
                Logo = (byte[])imgLogo.EditValue,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtAdresIl)
                {
                    sec.Sec(txtAdresIl);
                }
                else if (sender == txtAdresIlce)
                {
                    sec.Sec(txtAdresIlce, txtAdresIl);
                }
            }
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtAdresIl) return;
            txtAdresIl.ControlEnabledChange(txtAdresIlce);
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }
    }
}