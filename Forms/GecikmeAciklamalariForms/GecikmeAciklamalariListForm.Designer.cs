
namespace OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    partial class GecikmeAciklamalariListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GecikmeAciklamalariListForm));
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colKullaniciAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTarihSaat = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarihSaat = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemAciklama = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarihSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarihSaat.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAciklama)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(750, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 417);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(750, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarihSaat,
            this.repositoryItemAciklama});
            this.grid.Size = new System.Drawing.Size(750, 308);
            this.grid.TabIndex = 4;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view});
            // 
            // view
            // 
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
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKullaniciAdi,
            this.colTarihSaat,
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
            this.view.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.view.OptionsView.RowAutoHeight = true;
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = null;
            this.view.StatusBarKisaYol = null;
            this.view.StatusBarKisaYolAciklama = null;
            this.view.ViewCaption = "AÇIKLAMA KARTLARI";
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colKullaniciAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKullaniciAdi.Caption = "Kullanıcı";
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.OptionsColumn.FixedWidth = true;
            this.colKullaniciAdi.StatusBarAciklama = null;
            this.colKullaniciAdi.StatusBarKisaYol = null;
            this.colKullaniciAdi.StatusBarKisaYolAciklama = null;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 0;
            this.colKullaniciAdi.Width = 120;
            // 
            // colTarihSaat
            // 
            this.colTarihSaat.AppearanceCell.Options.UseTextOptions = true;
            this.colTarihSaat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarihSaat.AppearanceHeader.Options.UseTextOptions = true;
            this.colTarihSaat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarihSaat.Caption = "Tarih - Saat";
            this.colTarihSaat.ColumnEdit = this.repositoryItemTarihSaat;
            this.colTarihSaat.FieldName = "TarihSaat";
            this.colTarihSaat.Name = "colTarihSaat";
            this.colTarihSaat.OptionsColumn.AllowEdit = false;
            this.colTarihSaat.OptionsColumn.FixedWidth = true;
            this.colTarihSaat.StatusBarAciklama = null;
            this.colTarihSaat.StatusBarKisaYol = null;
            this.colTarihSaat.StatusBarKisaYolAciklama = null;
            this.colTarihSaat.Visible = true;
            this.colTarihSaat.VisibleIndex = 1;
            this.colTarihSaat.Width = 120;
            // 
            // repositoryItemTarihSaat
            // 
            this.repositoryItemTarihSaat.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTarihSaat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTarihSaat.AutoHeight = false;
            this.repositoryItemTarihSaat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarihSaat.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarihSaat.DisplayFormat.FormatString = "g";
            this.repositoryItemTarihSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTarihSaat.EditFormat.FormatString = "g";
            this.repositoryItemTarihSaat.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTarihSaat.Mask.EditMask = "g";
            this.repositoryItemTarihSaat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarihSaat.Name = "repositoryItemTarihSaat";
            // 
            // colAciklama
            // 
            this.colAciklama.AppearanceHeader.Options.UseTextOptions = true;
            this.colAciklama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.ColumnEdit = this.repositoryItemAciklama;
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            // 
            // repositoryItemAciklama
            // 
            this.repositoryItemAciklama.Name = "repositoryItemAciklama";
            // 
            // GecikmeAciklamalariListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 465);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "GecikmeAciklamalariListForm";
            this.Text = "Açıklama Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarihSaat.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarihSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAciklama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView view;
        private UserControls.Grids.MyGridColumn colKullaniciAdi;
        private UserControls.Grids.MyGridColumn colTarihSaat;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarihSaat;
        private UserControls.Grids.MyGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemAciklama;
    }
}