
namespace OgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    partial class RolYetkileriTable
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
            this.colId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKartTuru = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGorebilir = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colEkleyebilir = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDegistirebilir = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSilebilir = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 294);
            this.insUpNavigator.Size = new System.Drawing.Size(679, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheck});
            this.grid.Size = new System.Drawing.Size(679, 294);
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
            this.colId,
            this.colKartTuru,
            this.colGorebilir,
            this.colEkleyebilir,
            this.colDegistirebilir,
            this.colSilebilir});
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
            this.view.StatusBarAciklama = "Rol Yetki Kartları";
            this.view.StatusBarKisaYol = "Shift+Insert :";
            this.view.StatusBarKisaYolAciklama = "Yetki Kartı Ekle";
            this.view.ViewCaption = "ROL YETKİLERİ";
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
            // colKartTuru
            // 
            this.colKartTuru.Caption = "Kart Türü";
            this.colKartTuru.FieldName = "KartTuru";
            this.colKartTuru.Name = "colKartTuru";
            this.colKartTuru.OptionsColumn.AllowEdit = false;
            this.colKartTuru.StatusBarAciklama = null;
            this.colKartTuru.StatusBarKisaYol = null;
            this.colKartTuru.StatusBarKisaYolAciklama = null;
            this.colKartTuru.Visible = true;
            this.colKartTuru.VisibleIndex = 0;
            this.colKartTuru.Width = 338;
            // 
            // colGorebilir
            // 
            this.colGorebilir.Caption = "Görebilir";
            this.colGorebilir.ColumnEdit = this.repositoryItemCheck;
            this.colGorebilir.FieldName = "Gorebilir";
            this.colGorebilir.Name = "colGorebilir";
            this.colGorebilir.OptionsFilter.AllowAutoFilter = false;
            this.colGorebilir.OptionsFilter.AllowFilter = false;
            this.colGorebilir.StatusBarAciklama = null;
            this.colGorebilir.StatusBarKisaYol = null;
            this.colGorebilir.StatusBarKisaYolAciklama = null;
            this.colGorebilir.Visible = true;
            this.colGorebilir.VisibleIndex = 1;
            // 
            // repositoryItemCheck
            // 
            this.repositoryItemCheck.AutoHeight = false;
            this.repositoryItemCheck.Name = "repositoryItemCheck";
            this.repositoryItemCheck.ValueChecked = ((byte)(1));
            this.repositoryItemCheck.ValueGrayed = ((byte)(2));
            this.repositoryItemCheck.ValueUnchecked = ((byte)(0));
            // 
            // colEkleyebilir
            // 
            this.colEkleyebilir.Caption = "Ekleyebilir";
            this.colEkleyebilir.ColumnEdit = this.repositoryItemCheck;
            this.colEkleyebilir.FieldName = "Ekleyebilir";
            this.colEkleyebilir.Name = "colEkleyebilir";
            this.colEkleyebilir.OptionsFilter.AllowAutoFilter = false;
            this.colEkleyebilir.OptionsFilter.AllowFilter = false;
            this.colEkleyebilir.StatusBarAciklama = null;
            this.colEkleyebilir.StatusBarKisaYol = null;
            this.colEkleyebilir.StatusBarKisaYolAciklama = null;
            this.colEkleyebilir.Visible = true;
            this.colEkleyebilir.VisibleIndex = 2;
            // 
            // colDegistirebilir
            // 
            this.colDegistirebilir.Caption = "Değiştirebilir";
            this.colDegistirebilir.ColumnEdit = this.repositoryItemCheck;
            this.colDegistirebilir.FieldName = "Degistirebilir";
            this.colDegistirebilir.Name = "colDegistirebilir";
            this.colDegistirebilir.OptionsFilter.AllowAutoFilter = false;
            this.colDegistirebilir.OptionsFilter.AllowFilter = false;
            this.colDegistirebilir.StatusBarAciklama = null;
            this.colDegistirebilir.StatusBarKisaYol = null;
            this.colDegistirebilir.StatusBarKisaYolAciklama = null;
            this.colDegistirebilir.Visible = true;
            this.colDegistirebilir.VisibleIndex = 3;
            // 
            // colSilebilir
            // 
            this.colSilebilir.Caption = "Silebilir";
            this.colSilebilir.ColumnEdit = this.repositoryItemCheck;
            this.colSilebilir.FieldName = "Silebilir";
            this.colSilebilir.Name = "colSilebilir";
            this.colSilebilir.OptionsFilter.AllowAutoFilter = false;
            this.colSilebilir.OptionsFilter.AllowFilter = false;
            this.colSilebilir.StatusBarAciklama = null;
            this.colSilebilir.StatusBarKisaYol = null;
            this.colSilebilir.StatusBarKisaYolAciklama = null;
            this.colSilebilir.Visible = true;
            this.colSilebilir.VisibleIndex = 4;
            // 
            // RolYetkileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "RolYetkileriTable";
            this.Size = new System.Drawing.Size(679, 318);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView view;
        private Grids.MyGridColumn colId;
        private Grids.MyGridColumn colKartTuru;
        private Grids.MyGridColumn colGorebilir;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheck;
        private Grids.MyGridColumn colEkleyebilir;
        private Grids.MyGridColumn colDegistirebilir;
        private Grids.MyGridColumn colSilebilir;
    }
}
