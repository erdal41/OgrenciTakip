
namespace OgrenciTakip.UI.Win.Forms.HizmetForms
{
    partial class HizmetListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizmetListForm));
            this.ustPanel = new DevExpress.XtraEditors.PanelControl();
            this.txtHizmetBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Controls.MyDateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKod = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetTuruId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetTuruAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBitisTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colUcret = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemUcret = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustPanel)).BeginInit();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemUcret)).BeginInit();
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
            // ustPanel
            // 
            this.ustPanel.Controls.Add(this.txtHizmetBaslamaTarihi);
            this.ustPanel.Controls.Add(this.labelControl1);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 109);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(1055, 32);
            this.ustPanel.TabIndex = 2;
            this.ustPanel.Visible = false;
            // 
            // txtHizmetBaslamaTarihi
            // 
            this.txtHizmetBaslamaTarihi.EditValue = null;
            this.txtHizmetBaslamaTarihi.EnterMoveNextControl = true;
            this.txtHizmetBaslamaTarihi.Location = new System.Drawing.Point(131, 6);
            this.txtHizmetBaslamaTarihi.MenuManager = this.ribbonControl;
            this.txtHizmetBaslamaTarihi.Name = "txtHizmetBaslamaTarihi";
            this.txtHizmetBaslamaTarihi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtHizmetBaslamaTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHizmetBaslamaTarihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHizmetBaslamaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHizmetBaslamaTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtHizmetBaslamaTarihi.Size = new System.Drawing.Size(136, 20);
            this.txtHizmetBaslamaTarihi.StatusBarAciklama = null;
            this.txtHizmetBaslamaTarihi.StatusBarKisaYol = "F4 :";
            this.txtHizmetBaslamaTarihi.StatusBarKisaYolAciklama = "Tarih Seç";
            this.txtHizmetBaslamaTarihi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hizmet Başlama Tarihi : ";
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
            this.grid.Location = new System.Drawing.Point(0, 141);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemUcret,
            this.repositoryItemTarih});
            this.grid.Size = new System.Drawing.Size(1055, 276);
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
            this.colId,
            this.colKod,
            this.colHizmetAdi,
            this.colHizmetTuruId,
            this.colHizmetTuruAdi,
            this.colBaslamaTarihi,
            this.colBitisTarihi,
            this.colUcret,
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
            this.view.ViewCaption = "HİZMET KARTLARI";
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
            this.colKod.Width = 100;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet Adı";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisaYol = null;
            this.colHizmetAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 1;
            this.colHizmetAdi.Width = 250;
            // 
            // colHizmetTuruId
            // 
            this.colHizmetTuruId.Caption = "HizmetTuruId";
            this.colHizmetTuruId.FieldName = "HizmetTuruId";
            this.colHizmetTuruId.Name = "colHizmetTuruId";
            this.colHizmetTuruId.OptionsColumn.AllowEdit = false;
            this.colHizmetTuruId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmetTuruId.StatusBarAciklama = null;
            this.colHizmetTuruId.StatusBarKisaYol = null;
            this.colHizmetTuruId.StatusBarKisaYolAciklama = null;
            // 
            // colHizmetTuruAdi
            // 
            this.colHizmetTuruAdi.Caption = "Hizmet Türü Adı";
            this.colHizmetTuruAdi.FieldName = "HizmetTuruAdi";
            this.colHizmetTuruAdi.Name = "colHizmetTuruAdi";
            this.colHizmetTuruAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetTuruAdi.StatusBarAciklama = null;
            this.colHizmetTuruAdi.StatusBarKisaYol = null;
            this.colHizmetTuruAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetTuruAdi.Visible = true;
            this.colHizmetTuruAdi.VisibleIndex = 2;
            this.colHizmetTuruAdi.Width = 100;
            // 
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaslamaTarihi.Caption = "BaşlamaTarihi";
            this.colBaslamaTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslamaTarihi.StatusBarAciklama = null;
            this.colBaslamaTarihi.StatusBarKisaYol = null;
            this.colBaslamaTarihi.StatusBarKisaYolAciklama = null;
            this.colBaslamaTarihi.Visible = true;
            this.colBaslamaTarihi.VisibleIndex = 3;
            this.colBaslamaTarihi.Width = 110;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBitisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBitisTarihi.Caption = "Bitiş Tarihi";
            this.colBitisTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colBitisTarihi.StatusBarAciklama = null;
            this.colBitisTarihi.StatusBarKisaYol = null;
            this.colBitisTarihi.StatusBarKisaYolAciklama = null;
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.VisibleIndex = 4;
            this.colBitisTarihi.Width = 110;
            // 
            // colUcret
            // 
            this.colUcret.Caption = "Ücret";
            this.colUcret.ColumnEdit = this.repositoryItemUcret;
            this.colUcret.FieldName = "Ucret";
            this.colUcret.Name = "colUcret";
            this.colUcret.OptionsColumn.AllowEdit = false;
            this.colUcret.StatusBarAciklama = null;
            this.colUcret.StatusBarKisaYol = null;
            this.colUcret.StatusBarKisaYolAciklama = null;
            this.colUcret.Visible = true;
            this.colUcret.VisibleIndex = 5;
            this.colUcret.Width = 110;
            // 
            // repositoryItemUcret
            // 
            this.repositoryItemUcret.AutoHeight = false;
            this.repositoryItemUcret.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemUcret.DisplayFormat.FormatString = "n2";
            this.repositoryItemUcret.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemUcret.Mask.EditMask = "n2";
            this.repositoryItemUcret.Name = "repositoryItemUcret";
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
            this.colAciklama.VisibleIndex = 6;
            this.colAciklama.Width = 250;
            // 
            // HizmetListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 465);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Controls.Add(this.ustPanel);
            this.IconOptions.ShowIcon = false;
            this.Name = "HizmetListForm";
            this.Text = "Hizmet Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.ustPanel, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustPanel)).EndInit();
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemUcret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl ustPanel;
        private UserControls.Controls.MyDateEdit txtHizmetBaslamaTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView view;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colKod;
        private UserControls.Grids.MyGridColumn colHizmetAdi;
        private UserControls.Grids.MyGridColumn colHizmetTuruId;
        private UserControls.Grids.MyGridColumn colHizmetTuruAdi;
        private UserControls.Grids.MyGridColumn colBaslamaTarihi;
        private UserControls.Grids.MyGridColumn colBitisTarihi;
        private UserControls.Grids.MyGridColumn colUcret;
        private UserControls.Grids.MyGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemUcret;
    }
}