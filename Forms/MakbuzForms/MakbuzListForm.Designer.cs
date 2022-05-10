
namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    partial class MakbuzListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakbuzListForm));
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colMakbuzNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.colHesapAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colMakbuzToplami = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHareketSayisi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colMakbuzTuru = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colMakbuzHesapTuru = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTarih = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemMakbuzToplami = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemHareketSayisi = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMakbuzToplami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHareketSayisi)).BeginInit();
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
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih,
            this.repositoryItemMakbuzToplami,
            this.repositoryItemHareketSayisi});
            this.grid.Size = new System.Drawing.Size(898, 263);
            this.grid.TabIndex = 2;
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
            this.colMakbuzNo,
            this.colTarih,
            this.colMakbuzHesapTuru,
            this.colMakbuzTuru,
            this.colHareketSayisi,
            this.colMakbuzToplami,
            this.colHesapAdi});
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
            this.view.ViewCaption = "MAKBUZ KARTLARI";
            // 
            // colMakbuzNo
            // 
            this.colMakbuzNo.AppearanceCell.Options.UseTextOptions = true;
            this.colMakbuzNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMakbuzNo.Caption = "Makbuz No";
            this.colMakbuzNo.FieldName = "Kod";
            this.colMakbuzNo.Name = "colMakbuzNo";
            this.colMakbuzNo.OptionsColumn.AllowEdit = false;
            this.colMakbuzNo.StatusBarAciklama = null;
            this.colMakbuzNo.StatusBarKisaYol = null;
            this.colMakbuzNo.StatusBarKisaYolAciklama = null;
            this.colMakbuzNo.Visible = true;
            this.colMakbuzNo.VisibleIndex = 0;
            this.colMakbuzNo.Width = 90;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 372);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(898, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsColumn.AllowEdit = false;
            this.colHesapAdi.StatusBarAciklama = null;
            this.colHesapAdi.StatusBarKisaYol = null;
            this.colHesapAdi.StatusBarKisaYolAciklama = null;
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 6;
            this.colHesapAdi.Width = 150;
            // 
            // colMakbuzToplami
            // 
            this.colMakbuzToplami.Caption = "Makbuz Toplamı";
            this.colMakbuzToplami.ColumnEdit = this.repositoryItemMakbuzToplami;
            this.colMakbuzToplami.FieldName = "MakbuzToplami";
            this.colMakbuzToplami.Name = "colMakbuzToplami";
            this.colMakbuzToplami.OptionsColumn.AllowEdit = false;
            this.colMakbuzToplami.StatusBarAciklama = null;
            this.colMakbuzToplami.StatusBarKisaYol = null;
            this.colMakbuzToplami.StatusBarKisaYolAciklama = null;
            this.colMakbuzToplami.Visible = true;
            this.colMakbuzToplami.VisibleIndex = 5;
            this.colMakbuzToplami.Width = 100;
            // 
            // colHareketSayisi
            // 
            this.colHareketSayisi.Caption = "Hareket";
            this.colHareketSayisi.ColumnEdit = this.repositoryItemHareketSayisi;
            this.colHareketSayisi.CustomizationCaption = "Hareket Sayısı";
            this.colHareketSayisi.FieldName = "HareketSayisi";
            this.colHareketSayisi.Name = "colHareketSayisi";
            this.colHareketSayisi.OptionsColumn.AllowEdit = false;
            this.colHareketSayisi.StatusBarAciklama = null;
            this.colHareketSayisi.StatusBarKisaYol = null;
            this.colHareketSayisi.StatusBarKisaYolAciklama = null;
            this.colHareketSayisi.Visible = true;
            this.colHareketSayisi.VisibleIndex = 4;
            this.colHareketSayisi.Width = 90;
            // 
            // colMakbuzTuru
            // 
            this.colMakbuzTuru.Caption = "Makbuz Türü";
            this.colMakbuzTuru.FieldName = "MakbuzTuru";
            this.colMakbuzTuru.Name = "colMakbuzTuru";
            this.colMakbuzTuru.OptionsColumn.AllowEdit = false;
            this.colMakbuzTuru.StatusBarAciklama = null;
            this.colMakbuzTuru.StatusBarKisaYol = null;
            this.colMakbuzTuru.StatusBarKisaYolAciklama = null;
            this.colMakbuzTuru.Visible = true;
            this.colMakbuzTuru.VisibleIndex = 3;
            this.colMakbuzTuru.Width = 150;
            // 
            // colMakbuzHesapTuru
            // 
            this.colMakbuzHesapTuru.Caption = "Makbuz Hesap Türü";
            this.colMakbuzHesapTuru.FieldName = "MakbuzHesapTuru";
            this.colMakbuzHesapTuru.Name = "colMakbuzHesapTuru";
            this.colMakbuzHesapTuru.OptionsColumn.AllowEdit = false;
            this.colMakbuzHesapTuru.StatusBarAciklama = null;
            this.colMakbuzHesapTuru.StatusBarKisaYol = null;
            this.colMakbuzHesapTuru.StatusBarKisaYolAciklama = null;
            this.colMakbuzHesapTuru.Visible = true;
            this.colMakbuzHesapTuru.VisibleIndex = 2;
            this.colMakbuzHesapTuru.Width = 105;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryItemTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.StatusBarAciklama = null;
            this.colTarih.StatusBarKisaYol = null;
            this.colTarih.StatusBarKisaYolAciklama = null;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            this.colTarih.Width = 90;
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
            // repositoryItemMakbuzToplami
            // 
            this.repositoryItemMakbuzToplami.AutoHeight = false;
            this.repositoryItemMakbuzToplami.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMakbuzToplami.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemMakbuzToplami.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemMakbuzToplami.Name = "repositoryItemMakbuzToplami";
            // 
            // repositoryItemHareketSayisi
            // 
            this.repositoryItemHareketSayisi.AutoHeight = false;
            this.repositoryItemHareketSayisi.DisplayFormat.FormatString = "{0:n0}";
            this.repositoryItemHareketSayisi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemHareketSayisi.Name = "repositoryItemHareketSayisi";
            // 
            // MakbuzListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 420);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "MakbuzListForm";
            this.Text = "Makbuz Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMakbuzToplami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHareketSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView view;
        private UserControls.Grids.MyGridColumn colMakbuzNo;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridColumn colTarih;
        private UserControls.Grids.MyGridColumn colMakbuzHesapTuru;
        private UserControls.Grids.MyGridColumn colMakbuzTuru;
        private UserControls.Grids.MyGridColumn colHareketSayisi;
        private UserControls.Grids.MyGridColumn colMakbuzToplami;
        private UserControls.Grids.MyGridColumn colHesapAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemHareketSayisi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemMakbuzToplami;
    }
}