
namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class IletisimBilgileriTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridView();
            this.colVeli = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemVeli = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFaturaAdresi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemAdresTuru = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colYakinlikAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemYakinlik = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colMeslekAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvTelefonu = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsTelefonu1 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCepTelefonu1 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvAdresi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvAdresiIlAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEvAdresiIlceAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsAdresi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsAdresiIlAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsAdresiIlceAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIsyeriAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGorevAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colYakinlikId = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemVeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAdresTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYakinlik)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 266);
            this.insUpNavigator.Size = new System.Drawing.Size(828, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemYakinlik,
            this.repositoryItemAdresTuru,
            this.repositoryItemVeli});
            this.grid.Size = new System.Drawing.Size(828, 266);
            this.grid.TabIndex = 5;
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
            this.view.BandPanelRowHeight = 20;
            this.view.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colVeli,
            this.colFaturaAdresi,
            this.colYakinlikId,
            this.colYakinlikAdi,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colEvTelefonu,
            this.colIsTelefonu1,
            this.colCepTelefonu1,
            this.colEvAdresi,
            this.colEvAdresiIlAdi,
            this.colEvAdresiIlceAdi,
            this.colIsAdresi,
            this.colIsAdresiIlAdi,
            this.colIsAdresiIlceAdi,
            this.colMeslekAdi,
            this.colIsyeriAdi,
            this.colGorevAdi});
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
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = "İletişim bilgileri seçiniz.";
            this.view.StatusBarKisaYol = "Shift+Insert";
            this.view.StatusBarKisaYolAciklama = "Seçim Yap";
            this.view.ViewCaption = "İLETİŞİM BİLGİLERİ";
            // 
            // colVeli
            // 
            this.colVeli.Caption = "Veli";
            this.colVeli.ColumnEdit = this.repositoryItemVeli;
            this.colVeli.FieldName = "Veli";
            this.colVeli.Name = "colVeli";
            this.colVeli.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVeli.OptionsFilter.AllowAutoFilter = false;
            this.colVeli.OptionsFilter.AllowFilter = false;
            this.colVeli.StatusBarAciklama = "Kişi öğrenci velisi ise işaretleyiniz.";
            this.colVeli.StatusBarKisaYol = "Space : ";
            this.colVeli.StatusBarKisaYolAciklama = "İşaretle";
            this.colVeli.Visible = true;
            // 
            // repositoryItemVeli
            // 
            this.repositoryItemVeli.AutoHeight = false;
            this.repositoryItemVeli.Name = "repositoryItemVeli";
            // 
            // colFaturaAdresi
            // 
            this.colFaturaAdresi.Caption = "Fatura Adresi";
            this.colFaturaAdresi.ColumnEdit = this.repositoryItemAdresTuru;
            this.colFaturaAdresi.FieldName = "FaturaAdresi";
            this.colFaturaAdresi.Name = "colFaturaAdresi";
            this.colFaturaAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFaturaAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colFaturaAdresi.OptionsFilter.AllowFilter = false;
            this.colFaturaAdresi.StatusBarAciklama = "Adres türü seçiniz.";
            this.colFaturaAdresi.StatusBarKisaYol = "F4 : ";
            this.colFaturaAdresi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colFaturaAdresi.Visible = true;
            this.colFaturaAdresi.Width = 90;
            // 
            // repositoryItemAdresTuru
            // 
            this.repositoryItemAdresTuru.AutoHeight = false;
            this.repositoryItemAdresTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemAdresTuru.Name = "repositoryItemAdresTuru";
            // 
            // colYakinlikAdi
            // 
            this.colYakinlikAdi.Caption = "Yakınlık";
            this.colYakinlikAdi.ColumnEdit = this.repositoryItemYakinlik;
            this.colYakinlikAdi.FieldName = "YakinlikAdi";
            this.colYakinlikAdi.Name = "colYakinlikAdi";
            this.colYakinlikAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikAdi.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikAdi.OptionsFilter.AllowFilter = false;
            this.colYakinlikAdi.StatusBarAciklama = "Yakınlık türü seçiniz.";
            this.colYakinlikAdi.StatusBarKisaYol = "F4 : ";
            this.colYakinlikAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colYakinlikAdi.Visible = true;
            this.colYakinlikAdi.Width = 85;
            // 
            // repositoryItemYakinlik
            // 
            this.repositoryItemYakinlik.AutoHeight = false;
            this.repositoryItemYakinlik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemYakinlik.Name = "repositoryItemYakinlik";
            this.repositoryItemYakinlik.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "T.C. Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTcKimlikNo.OptionsFilter.AllowAutoFilter = false;
            this.colTcKimlikNo.OptionsFilter.AllowFilter = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 100;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 100;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 100;
            // 
            // colMeslekAdi
            // 
            this.colMeslekAdi.Caption = "Meslek";
            this.colMeslekAdi.FieldName = "MeslekAdi";
            this.colMeslekAdi.Name = "colMeslekAdi";
            this.colMeslekAdi.OptionsColumn.AllowEdit = false;
            this.colMeslekAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMeslekAdi.OptionsFilter.AllowAutoFilter = false;
            this.colMeslekAdi.OptionsFilter.AllowFilter = false;
            this.colMeslekAdi.StatusBarAciklama = null;
            this.colMeslekAdi.StatusBarKisaYol = null;
            this.colMeslekAdi.StatusBarKisaYolAciklama = null;
            this.colMeslekAdi.Visible = true;
            this.colMeslekAdi.Width = 100;
            // 
            // colEvTelefonu
            // 
            this.colEvTelefonu.Caption = "Ev Telefonu";
            this.colEvTelefonu.FieldName = "EvTelefonu";
            this.colEvTelefonu.Name = "colEvTelefonu";
            this.colEvTelefonu.OptionsColumn.AllowEdit = false;
            this.colEvTelefonu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvTelefonu.OptionsFilter.AllowAutoFilter = false;
            this.colEvTelefonu.OptionsFilter.AllowFilter = false;
            this.colEvTelefonu.StatusBarAciklama = null;
            this.colEvTelefonu.StatusBarKisaYol = null;
            this.colEvTelefonu.StatusBarKisaYolAciklama = null;
            this.colEvTelefonu.Visible = true;
            this.colEvTelefonu.Width = 100;
            // 
            // colIsTelefonu1
            // 
            this.colIsTelefonu1.Caption = "İş Telefonu-1";
            this.colIsTelefonu1.FieldName = "IsTelefonu1";
            this.colIsTelefonu1.Name = "colIsTelefonu1";
            this.colIsTelefonu1.OptionsColumn.AllowEdit = false;
            this.colIsTelefonu1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsTelefonu1.OptionsFilter.AllowAutoFilter = false;
            this.colIsTelefonu1.OptionsFilter.AllowFilter = false;
            this.colIsTelefonu1.StatusBarAciklama = null;
            this.colIsTelefonu1.StatusBarKisaYol = null;
            this.colIsTelefonu1.StatusBarKisaYolAciklama = null;
            this.colIsTelefonu1.Visible = true;
            this.colIsTelefonu1.Width = 100;
            // 
            // colCepTelefonu1
            // 
            this.colCepTelefonu1.Caption = "Cep Telefonu-1";
            this.colCepTelefonu1.FieldName = "CepTelefonu1";
            this.colCepTelefonu1.Name = "colCepTelefonu1";
            this.colCepTelefonu1.OptionsColumn.AllowEdit = false;
            this.colCepTelefonu1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCepTelefonu1.OptionsFilter.AllowAutoFilter = false;
            this.colCepTelefonu1.OptionsFilter.AllowFilter = false;
            this.colCepTelefonu1.StatusBarAciklama = null;
            this.colCepTelefonu1.StatusBarKisaYol = null;
            this.colCepTelefonu1.StatusBarKisaYolAciklama = null;
            this.colCepTelefonu1.Visible = true;
            this.colCepTelefonu1.Width = 100;
            // 
            // colEvAdresi
            // 
            this.colEvAdresi.Caption = "Ev Adresi";
            this.colEvAdresi.FieldName = "EvAdresi";
            this.colEvAdresi.Name = "colEvAdresi";
            this.colEvAdresi.OptionsColumn.AllowEdit = false;
            this.colEvAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresi.OptionsFilter.AllowFilter = false;
            this.colEvAdresi.StatusBarAciklama = null;
            this.colEvAdresi.StatusBarKisaYol = null;
            this.colEvAdresi.StatusBarKisaYolAciklama = null;
            this.colEvAdresi.Visible = true;
            this.colEvAdresi.Width = 100;
            // 
            // colEvAdresiIlAdi
            // 
            this.colEvAdresiIlAdi.Caption = "İl";
            this.colEvAdresiIlAdi.CustomizationCaption = "Ev Adresi İl Adı";
            this.colEvAdresiIlAdi.FieldName = "EvAdresiIlAdi";
            this.colEvAdresiIlAdi.Name = "colEvAdresiIlAdi";
            this.colEvAdresiIlAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresiIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresiIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresiIlAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresiIlAdi.StatusBarAciklama = null;
            this.colEvAdresiIlAdi.StatusBarKisaYol = null;
            this.colEvAdresiIlAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresiIlAdi.Visible = true;
            this.colEvAdresiIlAdi.Width = 100;
            // 
            // colEvAdresiIlceAdi
            // 
            this.colEvAdresiIlceAdi.Caption = "İlçe";
            this.colEvAdresiIlceAdi.CustomizationCaption = "Ev Adresi İlçe Adı";
            this.colEvAdresiIlceAdi.FieldName = "EvAdresiIlceAdi";
            this.colEvAdresiIlceAdi.Name = "colEvAdresiIlceAdi";
            this.colEvAdresiIlceAdi.OptionsColumn.AllowEdit = false;
            this.colEvAdresiIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEvAdresiIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colEvAdresiIlceAdi.OptionsFilter.AllowFilter = false;
            this.colEvAdresiIlceAdi.StatusBarAciklama = null;
            this.colEvAdresiIlceAdi.StatusBarKisaYol = null;
            this.colEvAdresiIlceAdi.StatusBarKisaYolAciklama = null;
            this.colEvAdresiIlceAdi.Visible = true;
            this.colEvAdresiIlceAdi.Width = 100;
            // 
            // colIsAdresi
            // 
            this.colIsAdresi.Caption = "İş Adresi";
            this.colIsAdresi.FieldName = "IsAdresi";
            this.colIsAdresi.Name = "colIsAdresi";
            this.colIsAdresi.OptionsColumn.AllowEdit = false;
            this.colIsAdresi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresi.OptionsFilter.AllowFilter = false;
            this.colIsAdresi.StatusBarAciklama = null;
            this.colIsAdresi.StatusBarKisaYol = null;
            this.colIsAdresi.StatusBarKisaYolAciklama = null;
            this.colIsAdresi.Visible = true;
            this.colIsAdresi.Width = 100;
            // 
            // colIsAdresiIlAdi
            // 
            this.colIsAdresiIlAdi.Caption = "İl";
            this.colIsAdresiIlAdi.CustomizationCaption = "İş Adresi İl Adı";
            this.colIsAdresiIlAdi.FieldName = "IsAdresiIlAdi";
            this.colIsAdresiIlAdi.Name = "colIsAdresiIlAdi";
            this.colIsAdresiIlAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresiIlAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresiIlAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresiIlAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresiIlAdi.StatusBarAciklama = null;
            this.colIsAdresiIlAdi.StatusBarKisaYol = null;
            this.colIsAdresiIlAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresiIlAdi.Visible = true;
            this.colIsAdresiIlAdi.Width = 100;
            // 
            // colIsAdresiIlceAdi
            // 
            this.colIsAdresiIlceAdi.Caption = "İlçe";
            this.colIsAdresiIlceAdi.CustomizationCaption = "İş Adresi İlçe Adı";
            this.colIsAdresiIlceAdi.FieldName = "IsAdresiIlceAdi";
            this.colIsAdresiIlceAdi.Name = "colIsAdresiIlceAdi";
            this.colIsAdresiIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIsAdresiIlceAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsAdresiIlceAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdresiIlceAdi.OptionsFilter.AllowFilter = false;
            this.colIsAdresiIlceAdi.StatusBarAciklama = null;
            this.colIsAdresiIlceAdi.StatusBarKisaYol = null;
            this.colIsAdresiIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIsAdresiIlceAdi.Visible = true;
            this.colIsAdresiIlceAdi.Width = 100;
            // 
            // colIsyeriAdi
            // 
            this.colIsyeriAdi.Caption = "Adı";
            this.colIsyeriAdi.FieldName = "IsyeriAdi";
            this.colIsyeriAdi.Name = "colIsyeriAdi";
            this.colIsyeriAdi.OptionsColumn.AllowEdit = false;
            this.colIsyeriAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsyeriAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIsyeriAdi.OptionsFilter.AllowFilter = false;
            this.colIsyeriAdi.StatusBarAciklama = null;
            this.colIsyeriAdi.StatusBarKisaYol = null;
            this.colIsyeriAdi.StatusBarKisaYolAciklama = null;
            this.colIsyeriAdi.Visible = true;
            this.colIsyeriAdi.Width = 100;
            // 
            // colGorevAdi
            // 
            this.colGorevAdi.Caption = "Görevi";
            this.colGorevAdi.FieldName = "GorevAdi";
            this.colGorevAdi.Name = "colGorevAdi";
            this.colGorevAdi.OptionsColumn.AllowEdit = false;
            this.colGorevAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGorevAdi.OptionsFilter.AllowAutoFilter = false;
            this.colGorevAdi.OptionsFilter.AllowFilter = false;
            this.colGorevAdi.StatusBarAciklama = null;
            this.colGorevAdi.StatusBarKisaYol = null;
            this.colGorevAdi.StatusBarKisaYolAciklama = null;
            this.colGorevAdi.Visible = true;
            this.colGorevAdi.Width = 100;
            // 
            // colYakinlikId
            // 
            this.colYakinlikId.Caption = "YakinlikId";
            this.colYakinlikId.FieldName = "YakinlikId";
            this.colYakinlikId.Name = "colYakinlikId";
            this.colYakinlikId.OptionsColumn.AllowEdit = false;
            this.colYakinlikId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYakinlikId.OptionsColumn.ShowInCustomizationForm = false;
            this.colYakinlikId.OptionsFilter.AllowAutoFilter = false;
            this.colYakinlikId.OptionsFilter.AllowFilter = false;
            this.colYakinlikId.StatusBarAciklama = null;
            this.colYakinlikId.StatusBarKisaYol = null;
            this.colYakinlikId.StatusBarKisaYolAciklama = null;
            this.colYakinlikId.Width = 100;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colVeli);
            this.gridBand1.Columns.Add(this.colFaturaAdresi);
            this.gridBand1.Columns.Add(this.colYakinlikAdi);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 250;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Kimlik Bilgileri";
            this.gridBand2.Columns.Add(this.colTcKimlikNo);
            this.gridBand2.Columns.Add(this.colAdi);
            this.gridBand2.Columns.Add(this.colSoyadi);
            this.gridBand2.Columns.Add(this.colMeslekAdi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 400;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Telefon";
            this.gridBand3.Columns.Add(this.colEvTelefonu);
            this.gridBand3.Columns.Add(this.colIsTelefonu1);
            this.gridBand3.Columns.Add(this.colCepTelefonu1);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 300;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ev Adresi";
            this.gridBand4.Columns.Add(this.colEvAdresi);
            this.gridBand4.Columns.Add(this.colEvAdresiIlAdi);
            this.gridBand4.Columns.Add(this.colEvAdresiIlceAdi);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 300;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "İş Adresi";
            this.gridBand5.Columns.Add(this.colIsAdresi);
            this.gridBand5.Columns.Add(this.colIsAdresiIlAdi);
            this.gridBand5.Columns.Add(this.colIsAdresiIlceAdi);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 300;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Çalıştığı veya Sahibi Olduğu İşyeri Bilgisi";
            this.gridBand6.Columns.Add(this.colIsyeriAdi);
            this.gridBand6.Columns.Add(this.colGorevAdi);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 200;
            // 
            // IletisimBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IletisimBilgileriTable";
            this.Size = new System.Drawing.Size(828, 290);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemVeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAdresTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYakinlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyBandedGridControl grid;
        private Grids.MyBandedGridView view;
        private Grids.MyBandedGridColumn colVeli;
        private Grids.MyBandedGridColumn colFaturaAdresi;
        private Grids.MyBandedGridColumn colYakinlikId;
        private Grids.MyBandedGridColumn colYakinlikAdi;
        private Grids.MyBandedGridColumn colTcKimlikNo;
        private Grids.MyBandedGridColumn colAdi;
        private Grids.MyBandedGridColumn colSoyadi;
        private Grids.MyBandedGridColumn colEvTelefonu;
        private Grids.MyBandedGridColumn colCepTelefonu1;
        private Grids.MyBandedGridColumn colIsTelefonu1;
        private Grids.MyBandedGridColumn colEvAdresi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemVeli;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemAdresTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemYakinlik;
        private Grids.MyBandedGridColumn colMeslekAdi;
        private Grids.MyBandedGridColumn colEvAdresiIlAdi;
        private Grids.MyBandedGridColumn colEvAdresiIlceAdi;
        private Grids.MyBandedGridColumn colIsAdresi;
        private Grids.MyBandedGridColumn colIsAdresiIlAdi;
        private Grids.MyBandedGridColumn colIsAdresiIlceAdi;
        private Grids.MyBandedGridColumn colIsyeriAdi;
        private Grids.MyBandedGridColumn colGorevAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}
