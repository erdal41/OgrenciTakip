using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.BankaHesapForms
{
    public partial class BankaHesapEditForm : BaseEditForm
    {
        public BankaHesapEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankaHesapBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            txtHesapTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankaHesapTuru>());
            BaseKartTuru = KartTuru.BankaHesap;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaHesapSingle() : ((BankaHesapBll)Bll).Single(FilterFunctions.Filter<BankaHesap>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaHesapBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtHesapAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaHesapSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtHesapAdi.Text = entity.HesapAdi;
            txtHesapTuru.SelectedItem = entity.HesapTuru.ToName();
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdi;
            txtBankaSube.Id = entity.BankaSubeId;
            txtBankaSube.Text = entity.BankaSubeAdi;
            txtHesapAcilisTarihi.DateTime = entity.HesapAcilisTarihi;
            txtHesapNo.Text = entity.HesapNo;
            txtIbanNo.Text = entity.IbanNo;
            txtBlokeGunSayisi.Value = entity.BlokeGunSayisi;
            txtIsyeriNo.Text = entity.IsyeriNo;
            txtTerminalNo.Text = entity.TerminalNo;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new BankaHesap
            {
                Id = Id,
                Kod = txtKod.Text,
                HesapAdi = txtHesapAdi.Text,
                HesapTuru = txtHesapTuru.Text.GetEnum<BankaHesapTuru>(),
                BankaId = Convert.ToInt64(txtBanka.Id),
                BankaSubeId = Convert.ToInt64(txtBankaSube.Id),
                HesapAcilisTarihi = txtHesapAcilisTarihi.DateTime.Date,
                HesapNo = txtHesapNo.Text,
                IbanNo = txtIbanNo.Text,
                BlokeGunSayisi = (byte)txtBlokeGunSayisi.Value,
                IsyeriNo = txtIsyeriNo.Text,
                TerminalNo = txtTerminalNo.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                SubeId = AnaForm.SubeId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((BankaHesapBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override bool EntityUpdate()
        {
            return ((BankaHesapBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtBanka)
                {
                    sec.Sec(txtBanka);
                }
                else if (sender == txtBankaSube)
                {
                    sec.Sec(txtBankaSube, txtBanka);
                }
                else if (sender == txtOzelKod1)
                {
                    sec.Sec(txtOzelKod1, KartTuru.BankaHesap);
                }
                else if (sender == txtOzelKod2)
                {
                    sec.Sec(txtOzelKod2, KartTuru.BankaHesap);
                }
            }
        }

        //Ctrl+Alt+Delete yapıldığında banka içeriği siliniyor. Bu durumda banka şubenin içeriği silinip enabled durumu false oluyor.
        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtBanka) return;

            txtBanka.ControlEnabledChange(txtBankaSube);
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;

            var hesapTuru = edit.Text.GetEnum<BankaHesapTuru>();

            if (hesapTuru == BankaHesapTuru.EposBlokeHesabi || hesapTuru == BankaHesapTuru.OtsBlokeHesabi || hesapTuru == BankaHesapTuru.PosBlokeHesabi)
            {
                txtBlokeGunSayisi.Enabled = true;
                txtIsyeriNo.Enabled = true;
                txtTerminalNo.Enabled = true;
            }
            else
            {
                txtBlokeGunSayisi.Enabled = false;
                txtIsyeriNo.Enabled = false;
                txtTerminalNo.Enabled = false;
                txtBlokeGunSayisi.Value = 0;
                txtIsyeriNo.Text = null;
                txtTerminalNo.Text = null;
            }
        }
    }
}