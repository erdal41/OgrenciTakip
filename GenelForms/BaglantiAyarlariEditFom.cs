using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Configuration;
using System.Linq;

namespace OgrenciTakip.UI.Win.GenelForms
{
    public partial class BaglantiAyarlariEditFom : BaseEditForm
    {
        public BaglantiAyarlariEditFom()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] { btnYeni, btnSil };
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = new BaglantiAyarlari
            {
                Server = ConfigurationManager.AppSettings["Server"],
                YetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString(),
                Sifre = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer ? "Burası Şifre Alanıdır.".ConvertToSecureString() : "".ConvertToSecureString(),
            };

            NesneyiKontrollereBagla();
        }

        protected override void NesneyiKontrollereBagla()
        {
            txtServer.Text = ConfigurationManager.AppSettings["Server"];
            txtYetkilendirmeTuru.SelectedItem = ConfigurationManager.AppSettings["YetkilendirmeTuru"];
            txtKullaniciAdi.Text = ConfigurationManager.AppSettings["KullaniciAdi"];
            txtSifre.Text = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer ? "Burası Şifre Alanıdır." : "";
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new BaglantiAyarlari
            {
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi = txtKullaniciAdi.Text.ConvertToSecureString(),
                Sifre = txtSifre.Text.ConvertToSecureString(),
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityUpdate()
        {
            var list = GeneralFunctions.DegisenAlanlariGetir(OldEntity, NewEntity).ToList();

            list.ForEach(x =>
            {
                switch (x)
                {
                    case "Server":
                        Functions.GeneralFunctions.AppSettingWrite(x, txtServer.Text);
                        break;
                    case "YetkilendirmeTuru":
                        Functions.GeneralFunctions.AppSettingWrite(x, txtYetkilendirmeTuru.Text);
                        break;
                    case "KullaniciAdi":
                        Functions.GeneralFunctions.AppSettingWrite(x, txtKullaniciAdi.Text);
                        break;
                    case "Sifre":
                        Functions.GeneralFunctions.AppSettingWrite(x, txtSifre.Text);
                        break;
                }
            });

            return true;
        } 

        #endregion

        #region Events

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;

            var yetkilendirmeTuru = edit.Text.GetEnum<YetkilendirmeTuru>();

            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        } 

        #endregion
    }
}