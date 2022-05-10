
namespace OgrenciTakip.UI.Win.Forms.CariForms
{
    partial class CariListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariListForm));
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridView();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCariAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTelefon1 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTelefon2 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod1 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod2 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTelefon3 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTelefon4 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colFax = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colWeb = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colEmail = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colVergiDairesi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colVergiNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdres = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
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
            this.ribbonControl.Size = new System.Drawing.Size(1055, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 417);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1055, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1055, 308);
            this.grid.TabIndex = 4;
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
            this.view.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.view.Appearance.ViewCaption.Options.UseForeColor = true;
            this.view.BandPanelRowHeight = 40;
            this.view.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colTcKimlikNo,
            this.colCariAdi,
            this.colTelefon1,
            this.colTelefon2,
            this.colTelefon3,
            this.colTelefon4,
            this.colFax,
            this.colWeb,
            this.colEmail,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colAdres,
            this.colOzelKod1,
            this.colOzelKod2,
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
            this.view.ViewCaption = "CARİ KARTLARI";
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
            this.colKod.Width = 109;
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
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.StatusBarAciklama = null;
            this.colCariAdi.StatusBarKisaYol = null;
            this.colCariAdi.StatusBarKisaYolAciklama = null;
            this.colCariAdi.Visible = true;
            this.colCariAdi.Width = 180;
            // 
            // colTelefon1
            // 
            this.colTelefon1.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon1.Caption = "Telefon-1";
            this.colTelefon1.FieldName = "Telefon1";
            this.colTelefon1.Name = "colTelefon1";
            this.colTelefon1.OptionsColumn.AllowEdit = false;
            this.colTelefon1.StatusBarAciklama = null;
            this.colTelefon1.StatusBarKisaYol = null;
            this.colTelefon1.StatusBarKisaYolAciklama = null;
            this.colTelefon1.Visible = true;
            this.colTelefon1.Width = 110;
            // 
            // colTelefon2
            // 
            this.colTelefon2.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon2.Caption = "Telefon-2";
            this.colTelefon2.FieldName = "Telefon2";
            this.colTelefon2.Name = "colTelefon2";
            this.colTelefon2.OptionsColumn.AllowEdit = false;
            this.colTelefon2.StatusBarAciklama = null;
            this.colTelefon2.StatusBarKisaYol = null;
            this.colTelefon2.StatusBarKisaYolAciklama = null;
            this.colTelefon2.Visible = true;
            this.colTelefon2.Width = 110;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1Adi";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            this.colOzelKod1.StatusBarAciklama = null;
            this.colOzelKod1.StatusBarKisaYol = null;
            this.colOzelKod1.StatusBarKisaYolAciklama = null;
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.Width = 170;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2Adi";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            this.colOzelKod2.StatusBarAciklama = null;
            this.colOzelKod2.StatusBarKisaYol = null;
            this.colOzelKod2.StatusBarKisaYolAciklama = null;
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.Width = 170;
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
            this.colAciklama.Width = 400;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colTelefon3
            // 
            this.colTelefon3.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon3.Caption = "Telefon-3";
            this.colTelefon3.FieldName = "Telefon3";
            this.colTelefon3.Name = "colTelefon3";
            this.colTelefon3.OptionsColumn.AllowEdit = false;
            this.colTelefon3.StatusBarAciklama = null;
            this.colTelefon3.StatusBarKisaYol = null;
            this.colTelefon3.StatusBarKisaYolAciklama = null;
            // 
            // colTelefon4
            // 
            this.colTelefon4.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon4.Caption = "Telefon-4";
            this.colTelefon4.FieldName = "Telefon4";
            this.colTelefon4.Name = "colTelefon4";
            this.colTelefon4.OptionsColumn.AllowEdit = false;
            this.colTelefon4.StatusBarAciklama = null;
            this.colTelefon4.StatusBarKisaYol = null;
            this.colTelefon4.StatusBarKisaYolAciklama = null;
            // 
            // colFax
            // 
            this.colFax.AppearanceCell.Options.UseTextOptions = true;
            this.colFax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.StatusBarAciklama = null;
            this.colFax.StatusBarKisaYol = null;
            this.colFax.StatusBarKisaYolAciklama = null;
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
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email Adresi";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.StatusBarAciklama = null;
            this.colEmail.StatusBarKisaYol = null;
            this.colEmail.StatusBarKisaYolAciklama = null;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "Vergi Dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            this.colVergiDairesi.StatusBarAciklama = null;
            this.colVergiDairesi.StatusBarKisaYol = null;
            this.colVergiDairesi.StatusBarKisaYolAciklama = null;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "Vergi No";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            this.colVergiNo.StatusBarAciklama = null;
            this.colVergiNo.StatusBarKisaYol = null;
            this.colVergiNo.StatusBarKisaYolAciklama = null;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.StatusBarAciklama = null;
            this.colAdres.StatusBarKisaYol = null;
            this.colAdres.StatusBarKisaYolAciklama = null;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Cari Bilgileri";
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colCariAdi);
            this.gridBand1.Columns.Add(this.colTelefon1);
            this.gridBand1.Columns.Add(this.colTelefon2);
            this.gridBand1.Columns.Add(this.colTelefon3);
            this.gridBand1.Columns.Add(this.colTelefon4);
            this.gridBand1.Columns.Add(this.colFax);
            this.gridBand1.Columns.Add(this.colWeb);
            this.gridBand1.Columns.Add(this.colEmail);
            this.gridBand1.Columns.Add(this.colVergiDairesi);
            this.gridBand1.Columns.Add(this.colVergiNo);
            this.gridBand1.Columns.Add(this.colAdres);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 619;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Özel Kod Bilgileri";
            this.gridBand2.Columns.Add(this.colOzelKod1);
            this.gridBand2.Columns.Add(this.colOzelKod2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 340;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Ek Bilgiler";
            this.gridBand3.Columns.Add(this.colAciklama);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 400;
            // 
            // CariListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 465);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CariListForm";
            this.Text = "Cari Kartları";
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
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView view;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Grids.MyBandedGridColumn colCariAdi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod1;
        private UserControls.Grids.MyBandedGridColumn colOzelKod2;
        private UserControls.Grids.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private UserControls.Grids.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grids.MyBandedGridColumn colTelefon1;
        private UserControls.Grids.MyBandedGridColumn colTelefon2;
        private UserControls.Grids.MyBandedGridColumn colTelefon3;
        private UserControls.Grids.MyBandedGridColumn colTelefon4;
        private UserControls.Grids.MyBandedGridColumn colFax;
        private UserControls.Grids.MyBandedGridColumn colWeb;
        private UserControls.Grids.MyBandedGridColumn colEmail;
        private UserControls.Grids.MyBandedGridColumn colVergiDairesi;
        private UserControls.Grids.MyBandedGridColumn colVergiNo;
        private UserControls.Grids.MyBandedGridColumn colAdres;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}