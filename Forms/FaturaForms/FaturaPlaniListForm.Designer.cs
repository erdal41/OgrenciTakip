
namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    partial class FaturaPlaniListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaPlaniListForm));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOkulNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSinifAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colVeliAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colVeliSoyadi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colVeliYakinlikAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colVeliMeslekAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKayitTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colKayitSekli = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIptalDurumu = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colHizmetTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colHizmetIndirimTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colHizmetNetTutar = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPlanTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPlanIndirimTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPlanNetTutar = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOzelKod1 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod2 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod3 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod4 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod5 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
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
            // btnSubeIslemleri
            // 
            this.btnSubeIslemleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubeIslemleri.ImageOptions.Image")));
            // 
            // btnYeniMakbuz
            // 
            this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // btnYeniRapor
            // 
            this.btnYeniRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.Image")));
            this.btnYeniRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.LargeImage")));
            // 
            // barSubItem2
            // 
            this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
            // 
            // btnOnTanimliRaporlar
            // 
            this.btnOnTanimliRaporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnTanimliRaporlar.ImageOptions.Image")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 372);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(898, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih,
            this.repositoryItemDecimal});
            this.grid.Size = new System.Drawing.Size(898, 263);
            this.grid.TabIndex = 3;
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
            this.gridBand1,
            this.gridBand3,
            this.gridBand2,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOkulNo,
            this.colAdi,
            this.colSoyadi,
            this.colSinifAdi,
            this.colKayitTarihi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colIptalDurumu,
            this.colVeliAdi,
            this.colVeliSoyadi,
            this.colVeliYakinlikAdi,
            this.colVeliMeslekAdi,
            this.colHizmetTutari,
            this.colHizmetIndirimTutari,
            this.colHizmetNetTutar,
            this.colPlanTutari,
            this.colPlanIndirimTutari,
            this.colPlanNetTutar,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colOzelKod5});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colHizmetNetTutar;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.IndianRed;
            formatConditionRuleExpression1.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[HizmetNetTutar]<>[PlanNetTutar]";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colHizmetNetTutar;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            formatConditionRuleExpression2.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[HizmetNetTutar] ==0";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.view.FormatRules.Add(gridFormatRule1);
            this.view.FormatRules.Add(gridFormatRule2);
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
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = null;
            this.view.StatusBarKisaYol = null;
            this.view.StatusBarKisaYolAciklama = null;
            this.view.ViewCaption = "FATURA PLANI KARTLARI";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colOkulNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colSinifAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 400;
            // 
            // colOkulNo
            // 
            this.colOkulNo.Caption = "No";
            this.colOkulNo.CustomizationCaption = "Okul No";
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.OptionsColumn.AllowEdit = false;
            this.colOkulNo.StatusBarAciklama = null;
            this.colOkulNo.StatusBarKisaYol = null;
            this.colOkulNo.StatusBarKisaYolAciklama = null;
            this.colOkulNo.Visible = true;
            this.colOkulNo.Width = 100;
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
            this.colAdi.Width = 100;
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
            this.colSoyadi.Width = 100;
            // 
            // colSinifAdi
            // 
            this.colSinifAdi.Caption = "Sınıf Adı";
            this.colSinifAdi.FieldName = "SinifAdi";
            this.colSinifAdi.Name = "colSinifAdi";
            this.colSinifAdi.OptionsColumn.AllowEdit = false;
            this.colSinifAdi.StatusBarAciklama = null;
            this.colSinifAdi.StatusBarKisaYol = null;
            this.colSinifAdi.StatusBarKisaYolAciklama = null;
            this.colSinifAdi.Visible = true;
            this.colSinifAdi.Width = 100;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Veli Bilgileri";
            this.gridBand3.Columns.Add(this.colVeliAdi);
            this.gridBand3.Columns.Add(this.colVeliSoyadi);
            this.gridBand3.Columns.Add(this.colVeliYakinlikAdi);
            this.gridBand3.Columns.Add(this.colVeliMeslekAdi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 1;
            this.gridBand3.Width = 400;
            // 
            // colVeliAdi
            // 
            this.colVeliAdi.Caption = "Adı";
            this.colVeliAdi.CustomizationCaption = "Veli Adı";
            this.colVeliAdi.FieldName = "VeliAdi";
            this.colVeliAdi.Name = "colVeliAdi";
            this.colVeliAdi.OptionsColumn.AllowEdit = false;
            this.colVeliAdi.StatusBarAciklama = null;
            this.colVeliAdi.StatusBarKisaYol = null;
            this.colVeliAdi.StatusBarKisaYolAciklama = null;
            this.colVeliAdi.Visible = true;
            this.colVeliAdi.Width = 100;
            // 
            // colVeliSoyadi
            // 
            this.colVeliSoyadi.Caption = "Soyadı";
            this.colVeliSoyadi.CustomizationCaption = "Veli Soyadı";
            this.colVeliSoyadi.FieldName = "VeliSoyadi";
            this.colVeliSoyadi.Name = "colVeliSoyadi";
            this.colVeliSoyadi.OptionsColumn.AllowEdit = false;
            this.colVeliSoyadi.StatusBarAciklama = null;
            this.colVeliSoyadi.StatusBarKisaYol = null;
            this.colVeliSoyadi.StatusBarKisaYolAciklama = null;
            this.colVeliSoyadi.Visible = true;
            this.colVeliSoyadi.Width = 100;
            // 
            // colVeliYakinlikAdi
            // 
            this.colVeliYakinlikAdi.Caption = "Yakınlık";
            this.colVeliYakinlikAdi.FieldName = "VeliYakinlikAdi";
            this.colVeliYakinlikAdi.Name = "colVeliYakinlikAdi";
            this.colVeliYakinlikAdi.OptionsColumn.AllowEdit = false;
            this.colVeliYakinlikAdi.StatusBarAciklama = null;
            this.colVeliYakinlikAdi.StatusBarKisaYol = null;
            this.colVeliYakinlikAdi.StatusBarKisaYolAciklama = null;
            this.colVeliYakinlikAdi.Visible = true;
            this.colVeliYakinlikAdi.Width = 100;
            // 
            // colVeliMeslekAdi
            // 
            this.colVeliMeslekAdi.Caption = "Meslek";
            this.colVeliMeslekAdi.FieldName = "VeliMeslekAdi";
            this.colVeliMeslekAdi.Name = "colVeliMeslekAdi";
            this.colVeliMeslekAdi.OptionsColumn.AllowEdit = false;
            this.colVeliMeslekAdi.StatusBarAciklama = null;
            this.colVeliMeslekAdi.StatusBarKisaYol = null;
            this.colVeliMeslekAdi.StatusBarKisaYolAciklama = null;
            this.colVeliMeslekAdi.Visible = true;
            this.colVeliMeslekAdi.Width = 100;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Kayıt Bilgileri";
            this.gridBand2.Columns.Add(this.colKayitTarihi);
            this.gridBand2.Columns.Add(this.colKayitSekli);
            this.gridBand2.Columns.Add(this.colKayitDurumu);
            this.gridBand2.Columns.Add(this.colIptalDurumu);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 400;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisaYol = null;
            this.colKayitTarihi.StatusBarKisaYolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.Width = 100;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTarih.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colKayitSekli
            // 
            this.colKayitSekli.Caption = "Kayıt Şekli";
            this.colKayitSekli.FieldName = "KayitSekli";
            this.colKayitSekli.Name = "colKayitSekli";
            this.colKayitSekli.OptionsColumn.AllowEdit = false;
            this.colKayitSekli.StatusBarAciklama = null;
            this.colKayitSekli.StatusBarKisaYol = null;
            this.colKayitSekli.StatusBarKisaYolAciklama = null;
            this.colKayitSekli.Visible = true;
            this.colKayitSekli.Width = 100;
            // 
            // colKayitDurumu
            // 
            this.colKayitDurumu.Caption = "Kayıt Durumu";
            this.colKayitDurumu.FieldName = "KayitDurumu";
            this.colKayitDurumu.Name = "colKayitDurumu";
            this.colKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colKayitDurumu.StatusBarAciklama = null;
            this.colKayitDurumu.StatusBarKisaYol = null;
            this.colKayitDurumu.StatusBarKisaYolAciklama = null;
            this.colKayitDurumu.Visible = true;
            this.colKayitDurumu.Width = 100;
            // 
            // colIptalDurumu
            // 
            this.colIptalDurumu.Caption = "İptal Durumu";
            this.colIptalDurumu.FieldName = "IptalDurumu";
            this.colIptalDurumu.Name = "colIptalDurumu";
            this.colIptalDurumu.OptionsColumn.AllowEdit = false;
            this.colIptalDurumu.StatusBarAciklama = null;
            this.colIptalDurumu.StatusBarKisaYol = null;
            this.colIptalDurumu.StatusBarKisaYolAciklama = null;
            this.colIptalDurumu.Visible = true;
            this.colIptalDurumu.Width = 100;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Hizmet Bilgileri";
            this.gridBand4.Columns.Add(this.colHizmetTutari);
            this.gridBand4.Columns.Add(this.colHizmetIndirimTutari);
            this.gridBand4.Columns.Add(this.colHizmetNetTutar);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 300;
            // 
            // colHizmetTutari
            // 
            this.colHizmetTutari.Caption = "Tutar";
            this.colHizmetTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colHizmetTutari.CustomizationCaption = "Brüt Tutar";
            this.colHizmetTutari.FieldName = "HizmetTutari";
            this.colHizmetTutari.Name = "colHizmetTutari";
            this.colHizmetTutari.OptionsColumn.AllowEdit = false;
            this.colHizmetTutari.StatusBarAciklama = null;
            this.colHizmetTutari.StatusBarKisaYol = null;
            this.colHizmetTutari.StatusBarKisaYolAciklama = null;
            this.colHizmetTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HizmetTutari", "{0:n2}")});
            this.colHizmetTutari.Visible = true;
            this.colHizmetTutari.Width = 100;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colHizmetIndirimTutari
            // 
            this.colHizmetIndirimTutari.Caption = "İndirim";
            this.colHizmetIndirimTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colHizmetIndirimTutari.FieldName = "HizmetIndirimTutari";
            this.colHizmetIndirimTutari.Name = "colHizmetIndirimTutari";
            this.colHizmetIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colHizmetIndirimTutari.StatusBarAciklama = null;
            this.colHizmetIndirimTutari.StatusBarKisaYol = null;
            this.colHizmetIndirimTutari.StatusBarKisaYolAciklama = null;
            this.colHizmetIndirimTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HizmetIndirimTutari", "{0:n2}")});
            this.colHizmetIndirimTutari.Visible = true;
            this.colHizmetIndirimTutari.Width = 100;
            // 
            // colHizmetNetTutar
            // 
            this.colHizmetNetTutar.Caption = "Net Tutar";
            this.colHizmetNetTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colHizmetNetTutar.FieldName = "HizmetNetTutar";
            this.colHizmetNetTutar.Name = "colHizmetNetTutar";
            this.colHizmetNetTutar.OptionsColumn.AllowEdit = false;
            this.colHizmetNetTutar.StatusBarAciklama = null;
            this.colHizmetNetTutar.StatusBarKisaYol = null;
            this.colHizmetNetTutar.StatusBarKisaYolAciklama = null;
            this.colHizmetNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HizmetNetTutar", "{0:n2}")});
            this.colHizmetNetTutar.Visible = true;
            this.colHizmetNetTutar.Width = 100;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Fatura Planı";
            this.gridBand5.Columns.Add(this.colPlanTutari);
            this.gridBand5.Columns.Add(this.colPlanIndirimTutari);
            this.gridBand5.Columns.Add(this.colPlanNetTutar);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 300;
            // 
            // colPlanTutari
            // 
            this.colPlanTutari.Caption = "Tutar";
            this.colPlanTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colPlanTutari.CustomizationCaption = "Plan Tutar";
            this.colPlanTutari.FieldName = "PlanTutari";
            this.colPlanTutari.Name = "colPlanTutari";
            this.colPlanTutari.OptionsColumn.AllowEdit = false;
            this.colPlanTutari.StatusBarAciklama = null;
            this.colPlanTutari.StatusBarKisaYol = null;
            this.colPlanTutari.StatusBarKisaYolAciklama = null;
            this.colPlanTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanTutari", "{0:n2}")});
            this.colPlanTutari.Visible = true;
            this.colPlanTutari.Width = 100;
            // 
            // colPlanIndirimTutari
            // 
            this.colPlanIndirimTutari.Caption = "İndirim";
            this.colPlanIndirimTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colPlanIndirimTutari.CustomizationCaption = "Plan Indirim";
            this.colPlanIndirimTutari.FieldName = "PlanIndirimTutari";
            this.colPlanIndirimTutari.Name = "colPlanIndirimTutari";
            this.colPlanIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colPlanIndirimTutari.StatusBarAciklama = null;
            this.colPlanIndirimTutari.StatusBarKisaYol = null;
            this.colPlanIndirimTutari.StatusBarKisaYolAciklama = null;
            this.colPlanIndirimTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanIndirimTutari", "{0:n2}")});
            this.colPlanIndirimTutari.Visible = true;
            this.colPlanIndirimTutari.Width = 100;
            // 
            // colPlanNetTutar
            // 
            this.colPlanNetTutar.Caption = "Net Tutar";
            this.colPlanNetTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colPlanNetTutar.CustomizationCaption = "Plan Net Tutar";
            this.colPlanNetTutar.FieldName = "PlanNetTutar";
            this.colPlanNetTutar.Name = "colPlanNetTutar";
            this.colPlanNetTutar.OptionsColumn.AllowEdit = false;
            this.colPlanNetTutar.StatusBarAciklama = null;
            this.colPlanNetTutar.StatusBarKisaYol = null;
            this.colPlanNetTutar.StatusBarKisaYolAciklama = null;
            this.colPlanNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanNetTutar", "{0:n2}")});
            this.colPlanNetTutar.Visible = true;
            this.colPlanNetTutar.Width = 100;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Özel Kod Bilgileri";
            this.gridBand6.Columns.Add(this.colOzelKod1);
            this.gridBand6.Columns.Add(this.colOzelKod2);
            this.gridBand6.Columns.Add(this.colOzelKod3);
            this.gridBand6.Columns.Add(this.colOzelKod4);
            this.gridBand6.Columns.Add(this.colOzelKod5);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 550;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            this.colOzelKod1.StatusBarAciklama = null;
            this.colOzelKod1.StatusBarKisaYol = null;
            this.colOzelKod1.StatusBarKisaYolAciklama = null;
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.Width = 110;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            this.colOzelKod2.StatusBarAciklama = null;
            this.colOzelKod2.StatusBarKisaYol = null;
            this.colOzelKod2.StatusBarKisaYolAciklama = null;
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.Width = 110;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod-3";
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            this.colOzelKod3.StatusBarAciklama = null;
            this.colOzelKod3.StatusBarKisaYol = null;
            this.colOzelKod3.StatusBarKisaYolAciklama = null;
            this.colOzelKod3.Visible = true;
            this.colOzelKod3.Width = 110;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod-4";
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            this.colOzelKod4.StatusBarAciklama = null;
            this.colOzelKod4.StatusBarKisaYol = null;
            this.colOzelKod4.StatusBarKisaYolAciklama = null;
            this.colOzelKod4.Visible = true;
            this.colOzelKod4.Width = 110;
            // 
            // colOzelKod5
            // 
            this.colOzelKod5.Caption = "Özel Kod-5";
            this.colOzelKod5.FieldName = "OzelKod5";
            this.colOzelKod5.Name = "colOzelKod5";
            this.colOzelKod5.OptionsColumn.AllowEdit = false;
            this.colOzelKod5.StatusBarAciklama = null;
            this.colOzelKod5.StatusBarKisaYol = null;
            this.colOzelKod5.StatusBarKisaYolAciklama = null;
            this.colOzelKod5.Visible = true;
            this.colOzelKod5.Width = 110;
            // 
            // progressBarControl
            // 
            this.progressBarControl.Location = new System.Drawing.Point(272, 212);
            this.progressBarControl.MenuManager = this.ribbonControl;
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.ShowTitle = true;
            this.progressBarControl.Size = new System.Drawing.Size(343, 30);
            this.progressBarControl.TabIndex = 4;
            this.progressBarControl.Visible = false;
            // 
            // FaturaPlaniListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 420);
            this.Controls.Add(this.progressBarControl);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "FaturaPlaniListForm";
            this.Text = "Fatura Planı Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.progressBarControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView view;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Grids.MyBandedGridColumn colOkulNo;
        private UserControls.Grids.MyBandedGridColumn colAdi;
        private UserControls.Grids.MyBandedGridColumn colSoyadi;
        private UserControls.Grids.MyBandedGridColumn colSinifAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private UserControls.Grids.MyBandedGridColumn colVeliAdi;
        private UserControls.Grids.MyBandedGridColumn colVeliSoyadi;
        private UserControls.Grids.MyBandedGridColumn colVeliYakinlikAdi;
        private UserControls.Grids.MyBandedGridColumn colVeliMeslekAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private UserControls.Grids.MyBandedGridColumn colKayitTarihi;
        private UserControls.Grids.MyBandedGridColumn colKayitSekli;
        private UserControls.Grids.MyBandedGridColumn colKayitDurumu;
        private UserControls.Grids.MyBandedGridColumn colIptalDurumu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private UserControls.Grids.MyBandedGridColumn colHizmetTutari;
        private UserControls.Grids.MyBandedGridColumn colHizmetIndirimTutari;
        private UserControls.Grids.MyBandedGridColumn colHizmetNetTutar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private UserControls.Grids.MyBandedGridColumn colPlanTutari;
        private UserControls.Grids.MyBandedGridColumn colPlanIndirimTutari;
        private UserControls.Grids.MyBandedGridColumn colPlanNetTutar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private UserControls.Grids.MyBandedGridColumn colOzelKod1;
        private UserControls.Grids.MyBandedGridColumn colOzelKod2;
        private UserControls.Grids.MyBandedGridColumn colOzelKod3;
        private UserControls.Grids.MyBandedGridColumn colOzelKod4;
        private UserControls.Grids.MyBandedGridColumn colOzelKod5;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
    }
}