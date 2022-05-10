
namespace OgrenciTakip.UI.Win.Forms.IletisimForms
{
    partial class IletisimListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IletisimListForm));
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridView();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colMeslek = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWeb = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEmail = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvTelefonu = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsTelefonu1 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCepTelefonu1 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvAdresi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvAdresiIlAdı = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvAdresiIlceAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsAdresi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsAdresiIlAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsAdresiIlceAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsyeriAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGorevAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod1Adi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod2Adi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.bndSecim = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(898, 356);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
            this.view.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.view.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.view.Appearance.BandPanel.Options.UseFont = true;
            this.view.Appearance.BandPanel.Options.UseForeColor = true;
            this.view.Appearance.BandPanel.Options.UseTextOptions = true;
            this.view.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.view.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.view.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.view.Appearance.FooterPanel.Options.UseFont = true;
            this.view.Appearance.FooterPanel.Options.UseForeColor = true;
            this.view.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.view.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.view.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.view.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.view.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.view.Appearance.ViewCaption.Options.UseFont = true;
            this.view.Appearance.ViewCaption.Options.UseForeColor = true;
            this.view.BandPanelRowHeight = 40;
            this.view.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bndSecim,
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colMeslek,
            this.colWeb,
            this.colEmail,
            this.colEvTelefonu,
            this.colIsTelefonu1,
            this.colCepTelefonu1,
            this.colEvAdresi,
            this.colEvAdresiIlAdı,
            this.colEvAdresiIlceAdi,
            this.colIsAdresi,
            this.colIsAdresiIlAdi,
            this.colIsAdresiIlceAdi,
            this.colIsyeriAdi,
            this.colGorevAdi,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colAciklama});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsMenu.EnableColumnMenu = false;
            this.view.OptionsMenu.EnableFooterMenu = false;
            this.view.OptionsMenu.EnableGroupPanelMenu = false;
            this.view.OptionsNavigation.EnterMoveNextColumn = true;
            this.view.OptionsPrint.AutoWidth = false;
            this.view.OptionsPrint.PrintFooter = false;
            this.view.OptionsPrint.PrintGroupFooter = false;
            this.view.OptionsView.ColumnAutoWidth = false;
            this.view.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = null;
            this.view.StatusBarKisaYol = null;
            this.view.StatusBarKisaYolAciklama = null;
            this.view.ViewCaption = "İLETİŞİM KARTLARI";
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            this.colKod.Width = 110;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "T.C. Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 110;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 110;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 110;
            // 
            // colMeslek
            // 
            this.colMeslek.Caption = "Meslek";
            this.colMeslek.FieldName = "MeslekAdi";
            this.colMeslek.Name = "colMeslek";
            this.colMeslek.OptionsColumn.AllowEdit = false;
            this.colMeslek.StatusBarAciklama = null;
            this.colMeslek.StatusBarKisaYol = null;
            this.colMeslek.StatusBarKisaYolAciklama = null;
            this.colMeslek.Visible = true;
            this.colMeslek.Width = 110;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web Adresi";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.StatusBarAciklama = null;
            this.colWeb.StatusBarKisaYol = null;
            this.colWeb.StatusBarKisaYolAciklama = null;
            this.colWeb.Visible = true;
            this.colWeb.Width = 110;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-mail Adresi";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.StatusBarAciklama = null;
            this.colEmail.StatusBarKisaYol = null;
            this.colEmail.StatusBarKisaYolAciklama = null;
            this.colEmail.Visible = true;
            this.colEmail.Width = 110;
            // 
            // colEvTelefonu
            // 
            this.colEvTelefonu.Caption = "Ev";
            this.colEvTelefonu.CustomizationCaption = "Ev Telefonu";
            this.colEvTelefonu.FieldName = "EvTelefonu";
            this.colEvTelefonu.Name = "colEvTelefonu";
            this.colEvTelefonu.OptionsColumn.AllowEdit = false;
            this.colEvTelefonu.StatusBarAciklama = null;
            this.colEvTelefonu.StatusBarKisaYol = null;
            this.colEvTelefonu.StatusBarKisaYolAciklama = null;
            this.colEvTelefonu.Visible = true;
            this.colEvTelefonu.Width = 110;
            // 
            // colIsTelefonu1
            // 
            this.colIsTelefonu1.Caption = "İş";
            this.colIsTelefonu1.CustomizationCaption = "İş Telefonu-1";
            this.colIsTelefonu1.FieldName = "IsTelefonu1";
            this.colIsTelefonu1.Name = "colIsTelefonu1";
            this.colIsTelefonu1.OptionsColumn.AllowEdit = false;
            this.colIsTelefonu1.StatusBarAciklama = null;
            this.colIsTelefonu1.StatusBarKisaYol = null;
            this.colIsTelefonu1.StatusBarKisaYolAciklama = null;
            this.colIsTelefonu1.Visible = true;
            this.colIsTelefonu1.Width = 110;
            // 
            // colCepTelefonu1
            // 
            this.colCepTelefonu1.Caption = "Cep";
            this.colCepTelefonu1.CustomizationCaption = "Cep Telefonu-1";
            this.colCepTelefonu1.FieldName = "CepTelefonu1";
            this.colCepTelefonu1.Name = "colCepTelefonu1";
            this.colCepTelefonu1.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu1.StatusBarAciklama = null;
            this.colCepTelefonu1.StatusBarKisaYol = null;
            this.colCepTelefonu1.StatusBarKisaYolAciklama = null;
            this.colCepTelefonu1.Visible = true;
            this.colCepTelefonu1.Width = 110;
            // 
            // colEvAdresi
            // 
            this.colEvAdresi.Caption = "Ev";
            this.colEvAdresi.CustomizationCaption = "Ev Adresi";
            this.colEvAdresi.FieldName = "EvAdresi";
            this.colEvAdresi.Name = "colEvAdresi";
            this.colEvAdresi.OptionsColumn.AllowEdit = false;
            this.colEvAdresi.StatusBarAciklama = null;
            this.colEvAdresi.StatusBarKisaYol = null;
            this.colEvAdresi.StatusBarKisaYolAciklama = null;
            this.colEvAdresi.Visible = true;
            this.colEvAdresi.Width = 110;
            // 
            // colEvAdresiIlAdı
            // 
            this.colEvAdresiIlAdı.Caption = "İl";
            this.colEvAdresiIlAdı.CustomizationCaption = "Ev Adresi İl Adı";
            this.colEvAdresiIlAdı.FieldName = "EvAdresiIlAdi";
            this.colEvAdresiIlAdı.Name = "colEvAdresiIlAdı";
            this.colEvAdresiIlAdı.OptionsColumn.AllowEdit = false;
            this.colEvAdresiIlAdı.StatusBarAciklama = null;
            this.colEvAdresiIlAdı.StatusBarKisaYol = null;
            this.colEvAdresiIlAdı.StatusBarKisaYolAciklama = null;
            this.colEvAdresiIlAdı.Visible = true;
            this.colEvAdresiIlAdı.Width = 110;
            // 
            // colEvAdresiIlceAdi
            // 
            this.colEvAdresiIlceAdi.Caption = "İlçe";
            this.colEvAdresiIlceAdi.CustomizationCaption = "Ev Adresi İlçe Adı";
            this.colEvAdresiIlceAdi.FieldName = "EvAdresiIlceAdi";
            this.colEvAdresiIlceAdi.Name = "colEvAdresiIlceAdi";
            this.colEvAdresiIlceAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresiIlceAdi.StatusBarAciklama = null;
            this.colEvAdresiIlceAdi.StatusBarKisaYol = null;
            this.colEvAdresiIlceAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresiIlceAdi.Visible = true;
            this.colEvAdresiIlceAdi.Width = 110;
            // 
            // colIsAdresi
            // 
            this.colIsAdresi.Caption = "İş";
            this.colIsAdresi.CustomizationCaption = "İş Adresi";
            this.colIsAdresi.FieldName = "IsAdresi";
            this.colIsAdresi.Name = "colIsAdresi";
            this.colIsAdresi.OptionsColumn.AllowEdit = false;
            this.colIsAdresi.StatusBarAciklama = null;
            this.colIsAdresi.StatusBarKisaYol = null;
            this.colIsAdresi.StatusBarKisaYolAciklama = null;
            this.colIsAdresi.Visible = true;
            this.colIsAdresi.Width = 110;
            // 
            // colIsAdresiIlAdi
            // 
            this.colIsAdresiIlAdi.Caption = "İl";
            this.colIsAdresiIlAdi.CustomizationCaption = "İş Adresi İl Adı";
            this.colIsAdresiIlAdi.FieldName = "IsAdresiIlAdi";
            this.colIsAdresiIlAdi.Name = "colIsAdresiIlAdi";
            this.colIsAdresiIlAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresiIlAdi.StatusBarAciklama = null;
            this.colIsAdresiIlAdi.StatusBarKisaYol = null;
            this.colIsAdresiIlAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresiIlAdi.Visible = true;
            this.colIsAdresiIlAdi.Width = 110;
            // 
            // colIsAdresiIlceAdi
            // 
            this.colIsAdresiIlceAdi.Caption = "İlçe";
            this.colIsAdresiIlceAdi.CustomizationCaption = "İş Adresi İlçe Adı";
            this.colIsAdresiIlceAdi.FieldName = "IsAdresiIlceAdi";
            this.colIsAdresiIlceAdi.Name = "colIsAdresiIlceAdi";
            this.colIsAdresiIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresiIlceAdi.StatusBarAciklama = null;
            this.colIsAdresiIlceAdi.StatusBarKisaYol = null;
            this.colIsAdresiIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresiIlceAdi.Visible = true;
            this.colIsAdresiIlceAdi.Width = 110;
            // 
            // colIsyeriAdi
            // 
            this.colIsyeriAdi.Caption = "Adı";
            this.colIsyeriAdi.CustomizationCaption = "İşyeri Adı";
            this.colIsyeriAdi.FieldName = "IsyeriAdi";
            this.colIsyeriAdi.Name = "colIsyeriAdi";
            this.colIsyeriAdi.OptionsColumn.AllowEdit = false;
            this.colIsyeriAdi.StatusBarAciklama = null;
            this.colIsyeriAdi.StatusBarKisaYol = null;
            this.colIsyeriAdi.StatusBarKisaYolAciklama = null;
            this.colIsyeriAdi.Visible = true;
            this.colIsyeriAdi.Width = 110;
            // 
            // colGorevAdi
            // 
            this.colGorevAdi.Caption = "Görevi";
            this.colGorevAdi.CustomizationCaption = "Görev Adı";
            this.colGorevAdi.FieldName = "GorevAdi";
            this.colGorevAdi.Name = "colGorevAdi";
            this.colGorevAdi.OptionsColumn.AllowEdit = false;
            this.colGorevAdi.StatusBarAciklama = null;
            this.colGorevAdi.StatusBarKisaYol = null;
            this.colGorevAdi.StatusBarKisaYolAciklama = null;
            this.colGorevAdi.Visible = true;
            this.colGorevAdi.Width = 110;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod-1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisaYol = null;
            this.colOzelKod1Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            this.colOzelKod1Adi.Width = 110;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod 2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisaYol = null;
            this.colOzelKod2Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            this.colOzelKod2Adi.Width = 110;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.Width = 250;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 465);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(898, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // bndSecim
            // 
            this.bndSecim.Caption = "Seç";
            this.bndSecim.Name = "bndSecim";
            this.bndSecim.Visible = false;
            this.bndSecim.VisibleIndex = -1;
            this.bndSecim.Width = 38;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colMeslek);
            this.gridBand1.Columns.Add(this.colWeb);
            this.gridBand1.Columns.Add(this.colEmail);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 770;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Telefon";
            this.gridBand2.Columns.Add(this.colEvTelefonu);
            this.gridBand2.Columns.Add(this.colIsTelefonu1);
            this.gridBand2.Columns.Add(this.colCepTelefonu1);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 330;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Adres";
            this.gridBand3.Columns.Add(this.colEvAdresi);
            this.gridBand3.Columns.Add(this.colEvAdresiIlAdı);
            this.gridBand3.Columns.Add(this.colEvAdresiIlceAdi);
            this.gridBand3.Columns.Add(this.colIsAdresi);
            this.gridBand3.Columns.Add(this.colIsAdresiIlAdi);
            this.gridBand3.Columns.Add(this.colIsAdresiIlceAdi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 660;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "İşyeri / Ünvan";
            this.gridBand4.Columns.Add(this.colIsyeriAdi);
            this.gridBand4.Columns.Add(this.colGorevAdi);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 220;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Özel Kod";
            this.gridBand5.Columns.Add(this.colOzelKod1Adi);
            this.gridBand5.Columns.Add(this.colOzelKod2Adi);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 220;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Ek Bilgiler";
            this.gridBand6.Columns.Add(this.colAciklama);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 250;
            // 
            // IletisimListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 513);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "IletisimListForm";
            this.Text = "İletişim Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView view;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Grids.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grids.MyBandedGridColumn colAdi;
        private UserControls.Grids.MyBandedGridColumn colSoyadi;
        private UserControls.Grids.MyBandedGridColumn colMeslek;
        private UserControls.Grids.MyBandedGridColumn colWeb;
        private UserControls.Grids.MyBandedGridColumn colEmail;
        private UserControls.Grids.MyBandedGridColumn colEvTelefonu;
        private UserControls.Grids.MyBandedGridColumn colIsTelefonu1;
        private UserControls.Grids.MyBandedGridColumn colCepTelefonu1;
        private UserControls.Grids.MyBandedGridColumn colEvAdresi;
        private UserControls.Grids.MyBandedGridColumn colEvAdresiIlAdı;
        private UserControls.Grids.MyBandedGridColumn colEvAdresiIlceAdi;
        private UserControls.Grids.MyBandedGridColumn colIsAdresi;
        private UserControls.Grids.MyBandedGridColumn colIsAdresiIlAdi;
        private UserControls.Grids.MyBandedGridColumn colIsAdresiIlceAdi;
        private UserControls.Grids.MyBandedGridColumn colIsyeriAdi;
        private UserControls.Grids.MyBandedGridColumn colGorevAdi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod2Adi;
        private UserControls.Grids.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private UserControls.Navigators.LongNavigator longNavigator;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSecim;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}