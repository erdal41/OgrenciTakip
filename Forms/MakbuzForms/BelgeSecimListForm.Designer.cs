
namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    partial class BelgeSecimListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BelgeSecimListForm));
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridView();
            this.bndSecim = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOgrenciNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSinifAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOgrenciSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPortfoyNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBelgeSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOdemeTuruAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankaHesapAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTakipNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGirisTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colVade = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colHesabaGecisTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTutar = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colTahsil = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIade = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKalan = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBelgeDurumu = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSonIslemTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.bndBelgeDetayBilgileri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSonIslemYeri = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankaAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBankaSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBelgeNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colHesapNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAsilBorclu = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCiranta = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(998, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnSubeIslemleri
            // 
            this.btnSubeIslemleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubeIslemleri.ImageOptions.Image")));
            // 
            // btnYeniMakbuz
            // 
            this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 451);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(998, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDecimal,
            this.repositoryItemTarih});
            this.grid.Size = new System.Drawing.Size(998, 342);
            this.grid.TabIndex = 6;
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
            this.bndSecim,
            this.gridBand1,
            this.gridBand2,
            this.bndBelgeDetayBilgileri});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOgrenciNo,
            this.colAdi,
            this.colSoyadi,
            this.colSinifAdi,
            this.colOgrenciSubeAdi,
            this.colBelgeSubeAdi,
            this.colOdemeTuruAdi,
            this.colBankaHesapAdi,
            this.colTakipNo,
            this.colPortfoyNo,
            this.colGirisTarihi,
            this.colVade,
            this.colHesabaGecisTarihi,
            this.colTutar,
            this.colTahsil,
            this.colIade,
            this.colKalan,
            this.colSonIslemTarihi,
            this.colSonIslemYeri,
            this.colBankaAdi,
            this.colBankaSubeAdi,
            this.colBelgeNo,
            this.colHesapNo,
            this.colAsilBorclu,
            this.colCiranta,
            this.colBelgeDurumu,
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
            this.view.ViewCaption = "ÖDEME BİLGİLERİ";
            // 
            // bndSecim
            // 
            this.bndSecim.Caption = "Seç";
            this.bndSecim.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.bndSecim.Name = "bndSecim";
            this.bndSecim.Visible = false;
            this.bndSecim.VisibleIndex = -1;
            this.bndSecim.Width = 35;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colOgrenciNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colSinifAdi);
            this.gridBand1.Columns.Add(this.colOgrenciSubeAdi);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 511;
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.Caption = "No";
            this.colOgrenciNo.CustomizationCaption = "Öğrenci No";
            this.colOgrenciNo.FieldName = "OgrenciNo";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.StatusBarAciklama = null;
            this.colOgrenciNo.StatusBarKisaYol = null;
            this.colOgrenciNo.StatusBarKisaYolAciklama = null;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 61;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.CustomizationCaption = "Öğrenci Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 100;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.CustomizationCaption = "Öğrenci Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 100;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisaYol = null;
            this.colSinifAdi.StatusBarKisaYolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.Width = 100;
            // 
            // colOgrenciSubeAdi
            // 
            this.colOgrenciSubeAdi.Caption = "Şube Adı";
            this.colOgrenciSubeAdi.CustomizationCaption = "Öğrenci Şube Adı";
            this.colOgrenciSubeAdi.FieldName = "OgrenciSubeAdi";
            this.colOgrenciSubeAdi.Name = "colOgrenciSubeAdi";
            this.colOgrenciSubeAdi.OptionsColumn.AllowEdit = false;
            this.colOgrenciSubeAdi.StatusBarAciklama = null;
            this.colOgrenciSubeAdi.StatusBarKisaYol = null;
            this.colOgrenciSubeAdi.StatusBarKisaYolAciklama = null;
            this.colOgrenciSubeAdi.Visible = true;
            this.colOgrenciSubeAdi.Width = 150;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Belge Genel Bilgileri";
            this.gridBand2.Columns.Add(this.colPortfoyNo);
            this.gridBand2.Columns.Add(this.colBelgeSubeAdi);
            this.gridBand2.Columns.Add(this.colOdemeTuruAdi);
            this.gridBand2.Columns.Add(this.colBankaHesapAdi);
            this.gridBand2.Columns.Add(this.colTakipNo);
            this.gridBand2.Columns.Add(this.colGirisTarihi);
            this.gridBand2.Columns.Add(this.colVade);
            this.gridBand2.Columns.Add(this.colHesabaGecisTarihi);
            this.gridBand2.Columns.Add(this.colTutar);
            this.gridBand2.Columns.Add(this.colTahsil);
            this.gridBand2.Columns.Add(this.colIade);
            this.gridBand2.Columns.Add(this.colKalan);
            this.gridBand2.Columns.Add(this.colBelgeDurumu);
            this.gridBand2.Columns.Add(this.colAciklama);
            this.gridBand2.Columns.Add(this.colSonIslemTarihi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1819;
            // 
            // colPortfoyNo
            // 
            this.colPortfoyNo.Caption = "Portföy No";
            this.colPortfoyNo.FieldName = "OdemeBilgileriId";
            this.colPortfoyNo.Name = "colPortfoyNo";
            this.colPortfoyNo.OptionsColumn.AllowEdit = false;
            this.colPortfoyNo.StatusBarAciklama = null;
            this.colPortfoyNo.StatusBarKisaYol = null;
            this.colPortfoyNo.StatusBarKisaYolAciklama = null;
            this.colPortfoyNo.Visible = true;
            this.colPortfoyNo.Width = 101;
            // 
            // colBelgeSubeAdi
            // 
            this.colBelgeSubeAdi.Caption = "Şube Adı";
            this.colBelgeSubeAdi.CustomizationCaption = "Belge Şube Adı";
            this.colBelgeSubeAdi.FieldName = "BelgeSubeAdi";
            this.colBelgeSubeAdi.Name = "colBelgeSubeAdi";
            this.colBelgeSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBelgeSubeAdi.StatusBarAciklama = null;
            this.colBelgeSubeAdi.StatusBarKisaYol = null;
            this.colBelgeSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBelgeSubeAdi.Visible = true;
            this.colBelgeSubeAdi.Width = 152;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.StatusBarAciklama = null;
            this.colOdemeTuruAdi.StatusBarKisaYol = null;
            this.colOdemeTuruAdi.StatusBarKisaYolAciklama = null;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.Width = 101;
            // 
            // colBankaHesapAdi
            // 
            this.colBankaHesapAdi.Caption = "Hesap Adı";
            this.colBankaHesapAdi.CustomizationCaption = "Banka Hesap Adı";
            this.colBankaHesapAdi.FieldName = "BankaHesapAdi";
            this.colBankaHesapAdi.Name = "colBankaHesapAdi";
            this.colBankaHesapAdi.OptionsColumn.AllowEdit = false;
            this.colBankaHesapAdi.StatusBarAciklama = null;
            this.colBankaHesapAdi.StatusBarKisaYol = null;
            this.colBankaHesapAdi.StatusBarKisaYolAciklama = null;
            this.colBankaHesapAdi.Visible = true;
            this.colBankaHesapAdi.Width = 152;
            // 
            // colTakipNo
            // 
            this.colTakipNo.Caption = "Takip No";
            this.colTakipNo.FieldName = "TakipNo";
            this.colTakipNo.Name = "colTakipNo";
            this.colTakipNo.OptionsColumn.AllowEdit = false;
            this.colTakipNo.StatusBarAciklama = null;
            this.colTakipNo.StatusBarKisaYol = null;
            this.colTakipNo.StatusBarKisaYolAciklama = null;
            this.colTakipNo.Visible = true;
            this.colTakipNo.Width = 101;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.Caption = "Giriş Tarihi";
            this.colGirisTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colGirisTarihi.StatusBarAciklama = null;
            this.colGirisTarihi.StatusBarKisaYol = null;
            this.colGirisTarihi.StatusBarKisaYolAciklama = null;
            this.colGirisTarihi.Visible = true;
            this.colGirisTarihi.Width = 101;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTarih.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colVade
            // 
            this.colVade.AppearanceCell.Options.UseTextOptions = true;
            this.colVade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVade.Caption = "Vade";
            this.colVade.ColumnEdit = this.repositoryItemTarih;
            this.colVade.FieldName = "Vade";
            this.colVade.Name = "colVade";
            this.colVade.OptionsColumn.AllowEdit = false;
            this.colVade.StatusBarAciklama = null;
            this.colVade.StatusBarKisaYol = null;
            this.colVade.StatusBarKisaYolAciklama = null;
            this.colVade.Visible = true;
            this.colVade.Width = 101;
            // 
            // colHesabaGecisTarihi
            // 
            this.colHesabaGecisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colHesabaGecisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesabaGecisTarihi.Caption = "H. G. Tarihi";
            this.colHesabaGecisTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colHesabaGecisTarihi.CustomizationCaption = "Hesaba Geçiş Tarihi";
            this.colHesabaGecisTarihi.FieldName = "HesabaGecisTarihi";
            this.colHesabaGecisTarihi.Name = "colHesabaGecisTarihi";
            this.colHesabaGecisTarihi.OptionsColumn.AllowEdit = false;
            this.colHesabaGecisTarihi.StatusBarAciklama = null;
            this.colHesabaGecisTarihi.StatusBarKisaYol = null;
            this.colHesabaGecisTarihi.StatusBarKisaYolAciklama = null;
            this.colHesabaGecisTarihi.Visible = true;
            this.colHesabaGecisTarihi.Width = 101;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.StatusBarAciklama = null;
            this.colTutar.StatusBarKisaYol = null;
            this.colTutar.StatusBarKisaYolAciklama = null;
            this.colTutar.Visible = true;
            this.colTutar.Width = 101;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Mask.EditMask = "n2";
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colTahsil
            // 
            this.colTahsil.Caption = "Tahsil";
            this.colTahsil.ColumnEdit = this.repositoryItemDecimal;
            this.colTahsil.FieldName = "Tahsil";
            this.colTahsil.Name = "colTahsil";
            this.colTahsil.OptionsColumn.AllowEdit = false;
            this.colTahsil.StatusBarAciklama = null;
            this.colTahsil.StatusBarKisaYol = null;
            this.colTahsil.StatusBarKisaYolAciklama = null;
            this.colTahsil.Visible = true;
            this.colTahsil.Width = 101;
            // 
            // colIade
            // 
            this.colIade.Caption = "İade";
            this.colIade.ColumnEdit = this.repositoryItemDecimal;
            this.colIade.FieldName = "Iade";
            this.colIade.Name = "colIade";
            this.colIade.OptionsColumn.AllowEdit = false;
            this.colIade.StatusBarAciklama = null;
            this.colIade.StatusBarKisaYol = null;
            this.colIade.StatusBarKisaYolAciklama = null;
            this.colIade.Visible = true;
            this.colIade.Width = 101;
            // 
            // colKalan
            // 
            this.colKalan.Caption = "Kalan";
            this.colKalan.ColumnEdit = this.repositoryItemDecimal;
            this.colKalan.FieldName = "Kalan";
            this.colKalan.Name = "colKalan";
            this.colKalan.OptionsColumn.AllowEdit = false;
            this.colKalan.StatusBarAciklama = null;
            this.colKalan.StatusBarKisaYol = null;
            this.colKalan.StatusBarKisaYolAciklama = null;
            this.colKalan.Visible = true;
            this.colKalan.Width = 100;
            // 
            // colBelgeDurumu
            // 
            this.colBelgeDurumu.Caption = "Durum";
            this.colBelgeDurumu.FieldName = "BelgeDurumu";
            this.colBelgeDurumu.Name = "colBelgeDurumu";
            this.colBelgeDurumu.OptionsColumn.AllowEdit = false;
            this.colBelgeDurumu.StatusBarAciklama = null;
            this.colBelgeDurumu.StatusBarKisaYol = null;
            this.colBelgeDurumu.StatusBarKisaYolAciklama = null;
            this.colBelgeDurumu.Visible = true;
            this.colBelgeDurumu.Width = 152;
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
            this.colAciklama.Width = 254;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSonIslemTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSonIslemTarihi.Caption = "Son İşlem Tarihi";
            this.colSonIslemTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colSonIslemTarihi.StatusBarAciklama = null;
            this.colSonIslemTarihi.StatusBarKisaYol = null;
            this.colSonIslemTarihi.StatusBarKisaYolAciklama = null;
            this.colSonIslemTarihi.Visible = true;
            this.colSonIslemTarihi.Width = 100;
            // 
            // bndBelgeDetayBilgileri
            // 
            this.bndBelgeDetayBilgileri.Caption = "Belge Detay Bilgileri";
            this.bndBelgeDetayBilgileri.Columns.Add(this.colSonIslemYeri);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBankaAdi);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBankaSubeAdi);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colBelgeNo);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colHesapNo);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colAsilBorclu);
            this.bndBelgeDetayBilgileri.Columns.Add(this.colCiranta);
            this.bndBelgeDetayBilgileri.Name = "bndBelgeDetayBilgileri";
            this.bndBelgeDetayBilgileri.VisibleIndex = 2;
            this.bndBelgeDetayBilgileri.Width = 800;
            // 
            // colSonIslemYeri
            // 
            this.colSonIslemYeri.Caption = "Son İşlem Yeri";
            this.colSonIslemYeri.FieldName = "SonIslemYeri";
            this.colSonIslemYeri.Name = "colSonIslemYeri";
            this.colSonIslemYeri.OptionsColumn.AllowEdit = false;
            this.colSonIslemYeri.StatusBarAciklama = null;
            this.colSonIslemYeri.StatusBarKisaYol = null;
            this.colSonIslemYeri.StatusBarKisaYolAciklama = null;
            this.colSonIslemYeri.Visible = true;
            this.colSonIslemYeri.Width = 100;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka";
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowEdit = false;
            this.colBankaAdi.StatusBarAciklama = null;
            this.colBankaAdi.StatusBarKisaYol = null;
            this.colBankaAdi.StatusBarKisaYolAciklama = null;
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.Width = 150;
            // 
            // colBankaSubeAdi
            // 
            this.colBankaSubeAdi.Caption = "Banka Şube";
            this.colBankaSubeAdi.FieldName = "BankaSubeAdi";
            this.colBankaSubeAdi.Name = "colBankaSubeAdi";
            this.colBankaSubeAdi.OptionsColumn.AllowEdit = false;
            this.colBankaSubeAdi.StatusBarAciklama = null;
            this.colBankaSubeAdi.StatusBarKisaYol = null;
            this.colBankaSubeAdi.StatusBarKisaYolAciklama = null;
            this.colBankaSubeAdi.Visible = true;
            this.colBankaSubeAdi.Width = 150;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.StatusBarAciklama = null;
            this.colBelgeNo.StatusBarKisaYol = null;
            this.colBelgeNo.StatusBarKisaYolAciklama = null;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.Width = 100;
            // 
            // colHesapNo
            // 
            this.colHesapNo.Caption = "Hesap No";
            this.colHesapNo.FieldName = "HesapNo";
            this.colHesapNo.Name = "colHesapNo";
            this.colHesapNo.OptionsColumn.AllowEdit = false;
            this.colHesapNo.StatusBarAciklama = null;
            this.colHesapNo.StatusBarKisaYol = null;
            this.colHesapNo.StatusBarKisaYolAciklama = null;
            this.colHesapNo.Visible = true;
            this.colHesapNo.Width = 100;
            // 
            // colAsilBorclu
            // 
            this.colAsilBorclu.Caption = "Asıl Borçlu";
            this.colAsilBorclu.FieldName = "AsilBorclu";
            this.colAsilBorclu.Name = "colAsilBorclu";
            this.colAsilBorclu.OptionsColumn.AllowEdit = false;
            this.colAsilBorclu.StatusBarAciklama = null;
            this.colAsilBorclu.StatusBarKisaYol = null;
            this.colAsilBorclu.StatusBarKisaYolAciklama = null;
            this.colAsilBorclu.Visible = true;
            this.colAsilBorclu.Width = 100;
            // 
            // colCiranta
            // 
            this.colCiranta.Caption = "Ciranta";
            this.colCiranta.FieldName = "Ciranta";
            this.colCiranta.Name = "colCiranta";
            this.colCiranta.OptionsColumn.AllowEdit = false;
            this.colCiranta.StatusBarAciklama = null;
            this.colCiranta.StatusBarKisaYol = null;
            this.colCiranta.StatusBarKisaYolAciklama = null;
            this.colCiranta.Visible = true;
            this.colCiranta.Width = 100;
            // 
            // BelgeSecimListFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 499);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "BelgeSecimListFormu";
            this.Text = "Belge Seçim";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView view;
        private UserControls.Grids.MyBandedGridColumn colOgrenciNo;
        private UserControls.Grids.MyBandedGridColumn colAdi;
        private UserControls.Grids.MyBandedGridColumn colSoyadi;
        private UserControls.Grids.MyBandedGridColumn colSinifAdi;
        private UserControls.Grids.MyBandedGridColumn colOgrenciSubeAdi;
        private UserControls.Grids.MyBandedGridColumn colPortfoyNo;
        private UserControls.Grids.MyBandedGridColumn colBelgeSubeAdi;
        private UserControls.Grids.MyBandedGridColumn colOdemeTuruAdi;
        private UserControls.Grids.MyBandedGridColumn colBankaHesapAdi;
        private UserControls.Grids.MyBandedGridColumn colTakipNo;
        private UserControls.Grids.MyBandedGridColumn colGirisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private UserControls.Grids.MyBandedGridColumn colVade;
        private UserControls.Grids.MyBandedGridColumn colHesabaGecisTarihi;
        private UserControls.Grids.MyBandedGridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private UserControls.Grids.MyBandedGridColumn colTahsil;
        private UserControls.Grids.MyBandedGridColumn colIade;
        private UserControls.Grids.MyBandedGridColumn colBelgeDurumu;
        private UserControls.Grids.MyBandedGridColumn colBankaAdi;
        private UserControls.Grids.MyBandedGridColumn colBankaSubeAdi;
        private UserControls.Grids.MyBandedGridColumn colBelgeNo;
        private UserControls.Grids.MyBandedGridColumn colHesapNo;
        private UserControls.Grids.MyBandedGridColumn colAsilBorclu;
        private UserControls.Grids.MyBandedGridColumn colCiranta;
        private UserControls.Grids.MyBandedGridColumn colKalan;
        private UserControls.Grids.MyBandedGridColumn colAciklama;
        private UserControls.Grids.MyBandedGridColumn colSonIslemTarihi;
        private UserControls.Grids.MyBandedGridColumn colSonIslemYeri;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSecim;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndBelgeDetayBilgileri;
    }
}