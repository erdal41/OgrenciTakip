
namespace OgrenciTakip.UI.Win.Forms.IptalNedeniForms
{
    partial class IptalNedeniListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IptalNedeniListForm));
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKod = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalNedeniAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 369);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(898, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 77);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(898, 292);
            this.grid.TabIndex = 3;
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
            this.colId,
            this.colKod,
            this.colIptalNedeniAdi,
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
            this.view.OptionsView.RowAutoHeight = true;
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = null;
            this.view.StatusBarKisaYol = null;
            this.view.StatusBarKisaYolAciklama = null;
            this.view.ViewCaption = "İPTAL NEDENİ KARTLARI";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 120;
            // 
            // colIptalNedeniAdi
            // 
            this.colIptalNedeniAdi.Caption = "Neden Adı";
            this.colIptalNedeniAdi.FieldName = "IptalNedeniAdi";
            this.colIptalNedeniAdi.Name = "colIptalNedeniAdi";
            this.colIptalNedeniAdi.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniAdi.StatusBarAciklama = null;
            this.colIptalNedeniAdi.StatusBarKisaYol = null;
            this.colIptalNedeniAdi.StatusBarKisaYolAciklama = null;
            this.colIptalNedeniAdi.Visible = true;
            this.colIptalNedeniAdi.VisibleIndex = 1;
            this.colIptalNedeniAdi.Width = 250;
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
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 450;
            // 
            // IptalNedeniListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 420);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "IptalNedeniListForm";
            this.Text = "İptal Nedeni Kartları";
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
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView view;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colKod;
        private UserControls.Grids.MyGridColumn colIptalNedeniAdi;
        private UserControls.Grids.MyGridColumn colAciklama;
    }
}