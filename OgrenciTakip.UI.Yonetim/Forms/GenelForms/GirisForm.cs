using DevExpress.XtraEditors;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using OgrenciTakip.Data.Contexts;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.Bll.Functions;

namespace OgrenciTakip.UI.Yonetim.Forms.GenelForms
{
    public partial class GirisForm : XtraForm
    {
        #region Variables

        private Point mouseLocation; 

        #endregion

        public GirisForm()
        {
            InitializeComponent();
            txtYetkilendirme.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();
        }

        #region Functions

        private void EventsLoad()
        {
            //Control Events
            foreach (Control control in Controls)
            {
                if (!(control is MyDataLayoutControl)) continue;
                control.MouseDown += Control_MouseDown;
                control.MouseMove += Control_MouseMove;

                foreach (Control ctrl in control.Controls)
                {
                    ctrl.KeyDown += Control_KeyDown;

                    switch (ctrl)
                    {
                        case MySimpleButton btn:
                            btn.Click += Control_Click;
                            break;
                        case MyComboboxEdit edit:
                            edit.SelectedValueChanged += Control_SelectedValueChanged;
                            break;
                    }
                }
            }

            //Form Events
            Shown += GirisForm_Shown;
        }

        private void Yukle()
        {
            txtVersion.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";

            var connectionStringArray = GeneralFunctions.GetConnectionString().Split(';');

            //parçalanan veriyi tekrar ikiye böldükten sonra Dictionary'a atarsak solda kalan kısım Key, sağdaki ise Value değerimiz olur.
            var dictionary = new Dictionary<string, string>();

            connectionStringArray.ForEach(x =>
            {
                var row = x.Split('=');

                //row[0] key, row[1] value
                dictionary.Add(row[0], row[1]);
            });

            txtServer.Text = dictionary.GetValueOrDefault("Data Source", "");
            txtYetkilendirme.SelectedItem = dictionary.ContainsKey("Password") ? YetkilendirmeTuru.SqlServer.ToName() : YetkilendirmeTuru.Windows.ToName();

            if (txtYetkilendirme.Text.GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer)
            {
                txtKullaniciAdi.Focus();
            }
            else
            {
                btnGiris.Focus();
            }
        }

        private void Giris()
        {
            //SqlServer bağlantı kontrolü
            if (!Win.Functions.GeneralFunctions.BaglantiKontrolu(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirme.Text.GetEnum<YetkilendirmeTuru>())) return;
            Win.Functions.GeneralFunctions.CreateConnectionString("OgrenciTakipYonetim", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirme.Text.GetEnum<YetkilendirmeTuru>());

            if (!Functions.GeneralFunctions.CreateDatabase<OgrenciTakipYonetimContext>("Lütfen Bekleyiniz", "Program ilk kurulum için hazırlanıyor...", "Programın ilk kurulum işlemi yapılacaktır. Onaylıyor musunuz?", "İlk kurulum işlemi başarılı bir şekilde oluşturuldu.")) return;

            Hide();

            ShowRibbonForms<AnaForm>.ShowForm(false, txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirme.Text.GetEnum<YetkilendirmeTuru>());
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        } 

        #endregion

        #region Events

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            //Mouse'un koordinatlarını aldık.
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var position = MousePosition;
            position.Offset(mouseLocation.X, mouseLocation.Y);
            Location = position;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if (!(sender is MySimpleButton button)) return;

            if (button == btnGiris)
            {
                Giris();
            }
            else if (button == btnVazgec)
            {
                Close();
            }
        }

        private void Control_SelectedValueChanged(object sender, EventArgs e)
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

        private void GirisForm_Shown(object sender, EventArgs e)
        {
            Yukle();
        }

        #endregion
    }
}