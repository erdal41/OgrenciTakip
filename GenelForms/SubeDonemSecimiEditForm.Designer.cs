
namespace OgrenciTakip.UI.Win.GenelForms
{
    partial class SubeDonemSecimiEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.donemNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.SmallNavigator();
            this.subeNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.SmallNavigator();
            this.donemGrid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.donemView = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colDonemId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDonemAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.subeGrid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.subeView = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colSubeId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(698, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.donemNavigator);
            this.myDataLayoutControl.Controls.Add(this.subeNavigator);
            this.myDataLayoutControl.Controls.Add(this.donemGrid);
            this.myDataLayoutControl.Controls.Add(this.subeGrid);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(698, 216);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // donemNavigator
            // 
            this.donemNavigator.Location = new System.Drawing.Point(351, 191);
            this.donemNavigator.Name = "donemNavigator";
            this.donemNavigator.Size = new System.Drawing.Size(345, 23);
            this.donemNavigator.TabIndex = 8;
            // 
            // subeNavigator
            // 
            this.subeNavigator.Location = new System.Drawing.Point(2, 191);
            this.subeNavigator.Name = "subeNavigator";
            this.subeNavigator.Size = new System.Drawing.Size(345, 23);
            this.subeNavigator.TabIndex = 7;
            // 
            // donemGrid
            // 
            this.donemGrid.Location = new System.Drawing.Point(351, 2);
            this.donemGrid.MainView = this.donemView;
            this.donemGrid.MenuManager = this.ribbonControl;
            this.donemGrid.Name = "donemGrid";
            this.donemGrid.Size = new System.Drawing.Size(345, 185);
            this.donemGrid.TabIndex = 6;
            this.donemGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.donemView});
            // 
            // donemView
            // 
            this.donemView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.donemView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.donemView.Appearance.FooterPanel.Options.UseFont = true;
            this.donemView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.donemView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.donemView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.donemView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.donemView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.donemView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.donemView.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.donemView.Appearance.ViewCaption.Options.UseFont = true;
            this.donemView.Appearance.ViewCaption.Options.UseForeColor = true;
            this.donemView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDonemId,
            this.colDonemAdi});
            this.donemView.GridControl = this.donemGrid;
            this.donemView.Name = "donemView";
            this.donemView.OptionsMenu.EnableColumnMenu = false;
            this.donemView.OptionsMenu.EnableFooterMenu = false;
            this.donemView.OptionsMenu.EnableGroupPanelMenu = false;
            this.donemView.OptionsNavigation.EnterMoveNextColumn = true;
            this.donemView.OptionsPrint.AutoWidth = false;
            this.donemView.OptionsPrint.PrintFooter = false;
            this.donemView.OptionsPrint.PrintGroupFooter = false;
            this.donemView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.donemView.OptionsView.RowAutoHeight = true;
            this.donemView.OptionsView.ShowColumnHeaders = false;
            this.donemView.OptionsView.ShowGroupPanel = false;
            this.donemView.OptionsView.ShowViewCaption = true;
            this.donemView.StatusBarAciklama = "Kullanıcının Yetkili Olduğu Dönemler";
            this.donemView.StatusBarKisaYol = null;
            this.donemView.StatusBarKisaYolAciklama = null;
            this.donemView.ViewCaption = "DÖNEM KARTLARI";
            // 
            // colDonemId
            // 
            this.colDonemId.Caption = "Id";
            this.colDonemId.FieldName = "DonemId";
            this.colDonemId.Name = "colDonemId";
            this.colDonemId.OptionsColumn.AllowEdit = false;
            this.colDonemId.OptionsColumn.AllowFocus = false;
            this.colDonemId.OptionsColumn.FixedWidth = true;
            this.colDonemId.OptionsColumn.ShowInCustomizationForm = false;
            this.colDonemId.StatusBarAciklama = null;
            this.colDonemId.StatusBarKisaYol = null;
            this.colDonemId.StatusBarKisaYolAciklama = null;
            this.colDonemId.Width = 100;
            // 
            // colDonemAdi
            // 
            this.colDonemAdi.Caption = "Donem Adı";
            this.colDonemAdi.FieldName = "DonemAdi";
            this.colDonemAdi.Name = "colDonemAdi";
            this.colDonemAdi.OptionsColumn.AllowEdit = false;
            this.colDonemAdi.StatusBarAciklama = null;
            this.colDonemAdi.StatusBarKisaYol = null;
            this.colDonemAdi.StatusBarKisaYolAciklama = null;
            this.colDonemAdi.Visible = true;
            this.colDonemAdi.VisibleIndex = 0;
            // 
            // subeGrid
            // 
            this.subeGrid.Location = new System.Drawing.Point(2, 2);
            this.subeGrid.MainView = this.subeView;
            this.subeGrid.MenuManager = this.ribbonControl;
            this.subeGrid.Name = "subeGrid";
            this.subeGrid.Size = new System.Drawing.Size(345, 185);
            this.subeGrid.TabIndex = 5;
            this.subeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.subeView});
            // 
            // subeView
            // 
            this.subeView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.subeView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.subeView.Appearance.FooterPanel.Options.UseFont = true;
            this.subeView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.subeView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.subeView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.subeView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.subeView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.subeView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.subeView.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.subeView.Appearance.ViewCaption.Options.UseFont = true;
            this.subeView.Appearance.ViewCaption.Options.UseForeColor = true;
            this.subeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubeId,
            this.colSubeAdi});
            this.subeView.GridControl = this.subeGrid;
            this.subeView.Name = "subeView";
            this.subeView.OptionsMenu.EnableColumnMenu = false;
            this.subeView.OptionsMenu.EnableFooterMenu = false;
            this.subeView.OptionsMenu.EnableGroupPanelMenu = false;
            this.subeView.OptionsNavigation.EnterMoveNextColumn = true;
            this.subeView.OptionsPrint.AutoWidth = false;
            this.subeView.OptionsPrint.PrintFooter = false;
            this.subeView.OptionsPrint.PrintGroupFooter = false;
            this.subeView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.subeView.OptionsView.RowAutoHeight = true;
            this.subeView.OptionsView.ShowColumnHeaders = false;
            this.subeView.OptionsView.ShowGroupPanel = false;
            this.subeView.OptionsView.ShowViewCaption = true;
            this.subeView.StatusBarAciklama = "Kullanıcının Yetkili Olduğu Şubeler";
            this.subeView.StatusBarKisaYol = null;
            this.subeView.StatusBarKisaYolAciklama = null;
            this.subeView.ViewCaption = "ŞUBE KARTLARI";
            // 
            // colSubeId
            // 
            this.colSubeId.Caption = "Id";
            this.colSubeId.FieldName = "SubeId";
            this.colSubeId.Name = "colSubeId";
            this.colSubeId.OptionsColumn.AllowEdit = false;
            this.colSubeId.OptionsColumn.FixedWidth = true;
            this.colSubeId.OptionsColumn.ShowInCustomizationForm = false;
            this.colSubeId.StatusBarAciklama = null;
            this.colSubeId.StatusBarKisaYol = null;
            this.colSubeId.StatusBarKisaYolAciklama = null;
            this.colSubeId.Width = 100;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.OptionsColumn.AllowFocus = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisaYol = null;
            this.colSubeAdi.StatusBarKisaYolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 27D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(698, 216);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.subeGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(349, 189);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.donemGrid;
            this.layoutControlItem3.Location = new System.Drawing.Point(349, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(349, 189);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.subeNavigator;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(349, 27);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.donemNavigator;
            this.layoutControlItem4.Location = new System.Drawing.Point(349, 189);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(349, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // SubeDonemSecimiEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 349);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "SubeDonemSecimiEditForm";
            this.Text = "Şube ve Dönem Seçimi";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Navigators.SmallNavigator donemNavigator;
        private UserControls.Navigators.SmallNavigator subeNavigator;
        private UserControls.Grids.MyGridControl donemGrid;
        private UserControls.Grids.MyGridView donemView;
        private UserControls.Grids.MyGridColumn colDonemId;
        private UserControls.Grids.MyGridControl subeGrid;
        private UserControls.Grids.MyGridView subeView;
        private UserControls.Grids.MyGridColumn colSubeId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private UserControls.Grids.MyGridColumn colSubeAdi;
        private UserControls.Grids.MyGridColumn colDonemAdi;
    }
}