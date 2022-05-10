
namespace OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    partial class OgrenciListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListForm));
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridView();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTelefon = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCinsiyet = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBabaAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAnaAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod1Adi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod2Adi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.colOzelKod3Adi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod4Adi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod5Adi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
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
            this.gridBand1,
            this.gridBand5});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colCinsiyet,
            this.colTelefon,
            this.colBabaAdi,
            this.colAnaAdi,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colOzelKod3Adi,
            this.colOzelKod4Adi,
            this.colOzelKod5Adi});
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
            this.view.ViewCaption = "ÖĞRENCİ KARTLARI";
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
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            // colTelefon
            // 
            this.colTelefon.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.StatusBarAciklama = null;
            this.colTelefon.StatusBarKisaYol = null;
            this.colTelefon.StatusBarKisaYolAciklama = null;
            this.colTelefon.Visible = true;
            this.colTelefon.Width = 110;
            // 
            // colCinsiyet
            // 
            this.colCinsiyet.AppearanceCell.Options.UseTextOptions = true;
            this.colCinsiyet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCinsiyet.Caption = "Cinsiyet";
            this.colCinsiyet.FieldName = "Cinsiyet";
            this.colCinsiyet.Name = "colCinsiyet";
            this.colCinsiyet.OptionsColumn.AllowEdit = false;
            this.colCinsiyet.StatusBarAciklama = null;
            this.colCinsiyet.StatusBarKisaYol = null;
            this.colCinsiyet.StatusBarKisaYolAciklama = null;
            this.colCinsiyet.Visible = true;
            this.colCinsiyet.Width = 110;
            // 
            // colBabaAdi
            // 
            this.colBabaAdi.Caption = "Baba Adı";
            this.colBabaAdi.FieldName = "BabaAdi";
            this.colBabaAdi.Name = "colBabaAdi";
            this.colBabaAdi.OptionsColumn.AllowEdit = false;
            this.colBabaAdi.StatusBarAciklama = null;
            this.colBabaAdi.StatusBarKisaYol = null;
            this.colBabaAdi.StatusBarKisaYolAciklama = null;
            this.colBabaAdi.Visible = true;
            this.colBabaAdi.Width = 110;
            // 
            // colAnaAdi
            // 
            this.colAnaAdi.Caption = "Ana Adı";
            this.colAnaAdi.FieldName = "AnaAdi";
            this.colAnaAdi.Name = "colAnaAdi";
            this.colAnaAdi.OptionsColumn.AllowEdit = false;
            this.colAnaAdi.StatusBarAciklama = null;
            this.colAnaAdi.StatusBarKisaYol = null;
            this.colAnaAdi.StatusBarKisaYolAciklama = null;
            this.colAnaAdi.Visible = true;
            this.colAnaAdi.Width = 110;
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
            // colOzelKod3Adi
            // 
            this.colOzelKod3Adi.Caption = "Özel Kod 3";
            this.colOzelKod3Adi.FieldName = "OzelKod3Adi";
            this.colOzelKod3Adi.Name = "colOzelKod3Adi";
            this.colOzelKod3Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod3Adi.StatusBarAciklama = null;
            this.colOzelKod3Adi.StatusBarKisaYol = null;
            this.colOzelKod3Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod3Adi.Visible = true;
            this.colOzelKod3Adi.Width = 110;
            // 
            // colOzelKod4Adi
            // 
            this.colOzelKod4Adi.Caption = "Özel Kod 4";
            this.colOzelKod4Adi.FieldName = "OzelKod4Adi";
            this.colOzelKod4Adi.Name = "colOzelKod4Adi";
            this.colOzelKod4Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod4Adi.StatusBarAciklama = null;
            this.colOzelKod4Adi.StatusBarKisaYol = null;
            this.colOzelKod4Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod4Adi.Visible = true;
            this.colOzelKod4Adi.Width = 110;
            // 
            // colOzelKod5Adi
            // 
            this.colOzelKod5Adi.Caption = "Özel Kod 5";
            this.colOzelKod5Adi.FieldName = "OzelKod5Adi";
            this.colOzelKod5Adi.Name = "colOzelKod5Adi";
            this.colOzelKod5Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod5Adi.StatusBarAciklama = null;
            this.colOzelKod5Adi.StatusBarKisaYol = null;
            this.colOzelKod5Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod5Adi.Visible = true;
            this.colOzelKod5Adi.Width = 110;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colCinsiyet);
            this.gridBand1.Columns.Add(this.colTelefon);
            this.gridBand1.Columns.Add(this.colAnaAdi);
            this.gridBand1.Columns.Add(this.colBabaAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 880;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Özel Kod";
            this.gridBand5.Columns.Add(this.colOzelKod1Adi);
            this.gridBand5.Columns.Add(this.colOzelKod2Adi);
            this.gridBand5.Columns.Add(this.colOzelKod3Adi);
            this.gridBand5.Columns.Add(this.colOzelKod4Adi);
            this.gridBand5.Columns.Add(this.colOzelKod5Adi);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 1;
            this.gridBand5.Width = 550;
            // 
            // OgrenciListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 513);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "OgrenciListForm";
            this.Text = "Öğrenci Kartları";
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
        private UserControls.Grids.MyBandedGridColumn colTelefon;
        private UserControls.Grids.MyBandedGridColumn colCinsiyet;
        private UserControls.Grids.MyBandedGridColumn colBabaAdi;
        private UserControls.Grids.MyBandedGridColumn colAnaAdi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod2Adi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridColumn colOzelKod3Adi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod4Adi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod5Adi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
    }
}