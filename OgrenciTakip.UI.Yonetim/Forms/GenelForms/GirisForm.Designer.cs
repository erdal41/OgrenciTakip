
namespace OgrenciTakip.UI.Yonetim.Forms.GenelForms
{
    partial class GirisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.txtVersion = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem4 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.txtServer = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtYetkilendirme = new OgrenciTakip.UI.Win.UserControls.Controls.MyComboboxEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtKullaniciAdi = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSifre = new OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnGiris = new OgrenciTakip.UI.Win.UserControls.Controls.MySimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnVazgec = new OgrenciTakip.UI.Win.UserControls.Controls.MySimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkilendirme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.BackColor = System.Drawing.Color.Transparent;
            this.myDataLayoutControl.Controls.Add(this.btnVazgec);
            this.myDataLayoutControl.Controls.Add(this.btnGiris);
            this.myDataLayoutControl.Controls.Add(this.txtSifre);
            this.myDataLayoutControl.Controls.Add(this.txtKullaniciAdi);
            this.myDataLayoutControl.Controls.Add(this.txtYetkilendirme);
            this.myDataLayoutControl.Controls.Add(this.txtServer);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(382, 176);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.simpleLabelItem2,
            this.txtVersion,
            this.simpleLabelItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 85D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 90D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 10D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 90D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition5.Width = 85D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5});
            rowDefinition1.Height = 19D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 17D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7});
            this.Root.Size = new System.Drawing.Size(382, 176);
            this.Root.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.simpleLabelItem1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Gold;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.simpleLabelItem1.Size = new System.Drawing.Size(175, 19);
            this.simpleLabelItem1.Text = "Abc Yazılım";
            this.simpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleLabelItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Gold;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 19);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.OptionsTableLayoutItem.ColumnSpan = 2;
            this.simpleLabelItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.simpleLabelItem2.Size = new System.Drawing.Size(175, 17);
            this.simpleLabelItem2.Text = "Öğrenci Takip-2020";
            this.simpleLabelItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(171, 13);
            // 
            // txtVersion
            // 
            this.txtVersion.AllowHotTrack = false;
            this.txtVersion.AppearanceItemCaption.ForeColor = System.Drawing.Color.Moccasin;
            this.txtVersion.AppearanceItemCaption.Options.UseForeColor = true;
            this.txtVersion.AppearanceItemCaption.Options.UseTextOptions = true;
            this.txtVersion.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtVersion.Location = new System.Drawing.Point(185, 0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.OptionsTableLayoutItem.ColumnIndex = 3;
            this.txtVersion.OptionsTableLayoutItem.ColumnSpan = 2;
            this.txtVersion.Size = new System.Drawing.Size(177, 19);
            this.txtVersion.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.txtVersion.TextSize = new System.Drawing.Size(171, 13);
            // 
            // simpleLabelItem4
            // 
            this.simpleLabelItem4.AllowHotTrack = false;
            this.simpleLabelItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.simpleLabelItem4.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleLabelItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Moccasin;
            this.simpleLabelItem4.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem4.Location = new System.Drawing.Point(185, 19);
            this.simpleLabelItem4.Name = "simpleLabelItem4";
            this.simpleLabelItem4.OptionsTableLayoutItem.ColumnIndex = 3;
            this.simpleLabelItem4.OptionsTableLayoutItem.ColumnSpan = 2;
            this.simpleLabelItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.simpleLabelItem4.Size = new System.Drawing.Size(177, 17);
            this.simpleLabelItem4.Text = "Program Yönetim Modülü Giriş";
            this.simpleLabelItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem4.TextSize = new System.Drawing.Size(171, 13);
            // 
            // txtServer
            // 
            this.txtServer.EnterMoveNextControl = true;
            this.txtServer.Location = new System.Drawing.Point(97, 48);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtServer.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtServer.Properties.MaxLength = 50;
            this.txtServer.Size = new System.Drawing.Size(273, 20);
            this.txtServer.StatusBarAciklama = null;
            this.txtServer.StyleController = this.myDataLayoutControl;
            this.txtServer.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtServer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 5;
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem1.Text = "Server";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // txtYetkilendirme
            // 
            this.txtYetkilendirme.EnterMoveNextControl = true;
            this.txtYetkilendirme.Location = new System.Drawing.Point(97, 72);
            this.txtYetkilendirme.Name = "txtYetkilendirme";
            this.txtYetkilendirme.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtYetkilendirme.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYetkilendirme.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYetkilendirme.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtYetkilendirme.Size = new System.Drawing.Size(186, 20);
            this.txtYetkilendirme.StatusBarAciklama = null;
            this.txtYetkilendirme.StatusBarKisaYol = "F4 :";
            this.txtYetkilendirme.StatusBarKisaYolAciklama = null;
            this.txtYetkilendirme.StyleController = this.myDataLayoutControl;
            this.txtYetkilendirme.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtYetkilendirme;
            this.layoutControlItem2.CustomizationFormText = "Yetkilendirme";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem2.Size = new System.Drawing.Size(275, 24);
            this.layoutControlItem2.Text = "Yetkilendirme Türü";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.EnterMoveNextControl = true;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(97, 96);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKullaniciAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKullaniciAdi.Properties.MaxLength = 50;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(186, 20);
            this.txtKullaniciAdi.StatusBarAciklama = null;
            this.txtKullaniciAdi.StyleController = this.myDataLayoutControl;
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtKullaniciAdi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem3.Size = new System.Drawing.Size(275, 24);
            this.layoutControlItem3.Text = "Kullanıcı Adı";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.EnterMoveNextControl = true;
            this.txtSifre.Location = new System.Drawing.Point(97, 120);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSifre.Properties.MaxLength = 50;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(186, 20);
            this.txtSifre.StatusBarAciklama = null;
            this.txtSifre.StyleController = this.myDataLayoutControl;
            this.txtSifre.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtSifre;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem4.Size = new System.Drawing.Size(275, 24);
            this.layoutControlItem4.Text = "Şifre";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.Location = new System.Drawing.Point(97, 144);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(86, 20);
            this.btnGiris.StatusBarAciklama = null;
            this.btnGiris.StyleController = this.myDataLayoutControl;
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.btnGiris;
            this.layoutControlItem5.Location = new System.Drawing.Point(85, 132);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem5.Size = new System.Drawing.Size(90, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnVazgec.Appearance.Options.UseForeColor = true;
            this.btnVazgec.Location = new System.Drawing.Point(197, 144);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(86, 20);
            this.btnVazgec.StatusBarAciklama = null;
            this.btnVazgec.StyleController = this.myDataLayoutControl;
            this.btnVazgec.TabIndex = 9;
            this.btnVazgec.Text = "Vazgeç";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.btnVazgec;
            this.layoutControlItem6.Location = new System.Drawing.Point(185, 132);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem6.Size = new System.Drawing.Size(90, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // GirisForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 176);
            this.ControlBox = false;
            this.Controls.Add(this.myDataLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkilendirme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Win.UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem txtVersion;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem4;
        private Win.UserControls.Controls.MyTextEdit txtSifre;
        private Win.UserControls.Controls.MyTextEdit txtKullaniciAdi;
        private Win.UserControls.Controls.MyComboboxEdit txtYetkilendirme;
        private Win.UserControls.Controls.MyTextEdit txtServer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Win.UserControls.Controls.MySimpleButton btnVazgec;
        private Win.UserControls.Controls.MySimpleButton btnGiris;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}