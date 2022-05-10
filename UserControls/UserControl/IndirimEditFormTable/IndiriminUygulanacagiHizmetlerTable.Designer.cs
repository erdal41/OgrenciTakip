
namespace OgrenciTakip.UI.Win.UserControls.UserControl.IndirimEditFormTable
{
    partial class IndiriminUygulanacagiHizmetlerTable
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
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colHizmetAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIndirimTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTutar = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIndirimOrani = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemOran = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemOran)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTutar,
            this.repositoryItemOran});
            this.grid.Size = new System.Drawing.Size(410, 176);
            this.grid.TabIndex = 5;
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
            this.colHizmetAdi,
            this.colIndirimTutari,
            this.colIndirimOrani});
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
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = "Bu indirimin uygulanacağını hizmet kartlarını seçiniz.";
            this.view.StatusBarKisaYol = "Shift+Insert";
            this.view.StatusBarKisaYolAciklama = "Hizmet Kartı Ekle";
            this.view.ViewCaption = "İndirimin Uygulanacağı Hizmetler";
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet Adı";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHizmetAdi.OptionsFilter.AllowAutoFilter = false;
            this.colHizmetAdi.OptionsFilter.AllowFilter = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisaYol = null;
            this.colHizmetAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 0;
            this.colHizmetAdi.Width = 210;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "Tutar";
            this.colIndirimTutari.ColumnEdit = this.repositoryItemTutar;
            this.colIndirimTutari.FieldName = "IndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIndirimTutari.OptionsFilter.AllowAutoFilter = false;
            this.colIndirimTutari.OptionsFilter.AllowFilter = false;
            this.colIndirimTutari.StatusBarAciklama = "İndirim tutarı giriniz.";
            this.colIndirimTutari.StatusBarKisaYol = "F4";
            this.colIndirimTutari.StatusBarKisaYolAciklama = "Hesap Makinesi";
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 1;
            this.colIndirimTutari.Width = 100;
            // 
            // repositoryItemTutar
            // 
            this.repositoryItemTutar.AutoHeight = false;
            this.repositoryItemTutar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTutar.DisplayFormat.FormatString = "n2";
            this.repositoryItemTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTutar.EditFormat.FormatString = "n2";
            this.repositoryItemTutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTutar.Mask.EditMask = "n2";
            this.repositoryItemTutar.Name = "repositoryItemTutar";
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "Oran ( % )";
            this.colIndirimOrani.ColumnEdit = this.repositoryItemOran;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIndirimOrani.OptionsFilter.AllowAutoFilter = false;
            this.colIndirimOrani.OptionsFilter.AllowFilter = false;
            this.colIndirimOrani.StatusBarAciklama = "İndirim oranı giriniz.";
            this.colIndirimOrani.StatusBarKisaYol = null;
            this.colIndirimOrani.StatusBarKisaYolAciklama = null;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 2;
            // 
            // repositoryItemOran
            // 
            this.repositoryItemOran.Appearance.Options.UseTextOptions = true;
            this.repositoryItemOran.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemOran.AutoHeight = false;
            this.repositoryItemOran.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemOran.DisplayFormat.FormatString = "n0";
            this.repositoryItemOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemOran.EditFormat.FormatString = "n0";
            this.repositoryItemOran.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemOran.Mask.EditMask = "n0";
            this.repositoryItemOran.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemOran.Name = "repositoryItemOran";
            // 
            // IndiriminUygulanacagiHizmetlerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IndiriminUygulanacagiHizmetlerTable";
            this.Size = new System.Drawing.Size(410, 200);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemOran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView view;
        private Grids.MyGridColumn colHizmetAdi;
        private Grids.MyGridColumn colIndirimTutari;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemTutar;
        private Grids.MyGridColumn colIndirimOrani;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemOran;
    }
}
