
namespace OgrenciTakip.UI.Win.UserControls.UserControl.FaturaEditFormTable
{
    partial class FaturaPlaniTable
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
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPlanTarih = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPlanTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colPlanIndirimTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colPlanNetTutar = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFaturaNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTahakkukTarih = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTahakkukTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTahakkukIndirimTutari = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTahakkukNetTutar = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 308);
            this.insUpNavigator.Size = new System.Drawing.Size(796, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih,
            this.repositoryItemDecimal});
            this.grid.Size = new System.Drawing.Size(796, 308);
            this.grid.TabIndex = 1;
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
            this.view.BandPanelRowHeight = 20;
            this.view.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colAciklama,
            this.colPlanTarih,
            this.colPlanTutari,
            this.colPlanIndirimTutari,
            this.colPlanNetTutar,
            this.colFaturaNo,
            this.colTahakkukTarih,
            this.colTahakkukTutari,
            this.colTahakkukIndirimTutari,
            this.colTahakkukNetTutar});
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
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = "Öğrenciye kesilen - kesilecek fatura bilgilerini giriniz.";
            this.view.StatusBarKisaYol = "Shift+Insert";
            this.view.StatusBarKisaYolAciklama = "Fatura Planı Ekle";
            this.view.ViewCaption = "FATURA PLANI";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Fatura Planı Bilgileri";
            this.gridBand1.Columns.Add(this.colAciklama);
            this.gridBand1.Columns.Add(this.colPlanTarih);
            this.gridBand1.Columns.Add(this.colPlanTutari);
            this.gridBand1.Columns.Add(this.colPlanIndirimTutari);
            this.gridBand1.Columns.Add(this.colPlanNetTutar);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 660;
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
            this.colAciklama.Width = 300;
            // 
            // colPlanTarih
            // 
            this.colPlanTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colPlanTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlanTarih.Caption = "Tarih";
            this.colPlanTarih.ColumnEdit = this.repositoryItemTarih;
            this.colPlanTarih.CustomizationCaption = "Plan Tarih";
            this.colPlanTarih.FieldName = "PlanTarih";
            this.colPlanTarih.Name = "colPlanTarih";
            this.colPlanTarih.OptionsColumn.AllowEdit = false;
            this.colPlanTarih.StatusBarAciklama = null;
            this.colPlanTarih.StatusBarKisaYol = null;
            this.colPlanTarih.StatusBarKisaYolAciklama = null;
            this.colPlanTarih.Visible = true;
            this.colPlanTarih.Width = 90;
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
            // colPlanTutari
            // 
            this.colPlanTutari.Caption = "Tutar";
            this.colPlanTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colPlanTutari.CustomizationCaption = "Plan Tutarı";
            this.colPlanTutari.FieldName = "PlanTutari";
            this.colPlanTutari.Name = "colPlanTutari";
            this.colPlanTutari.OptionsColumn.AllowEdit = false;
            this.colPlanTutari.StatusBarAciklama = null;
            this.colPlanTutari.StatusBarKisaYol = null;
            this.colPlanTutari.StatusBarKisaYolAciklama = null;
            this.colPlanTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanTutari", "{0:n2}")});
            this.colPlanTutari.Visible = true;
            this.colPlanTutari.Width = 90;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colPlanIndirimTutari
            // 
            this.colPlanIndirimTutari.Caption = "İndirim";
            this.colPlanIndirimTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colPlanIndirimTutari.CustomizationCaption = "Plan İndirim";
            this.colPlanIndirimTutari.FieldName = "PlanIndirimTutari";
            this.colPlanIndirimTutari.Name = "colPlanIndirimTutari";
            this.colPlanIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colPlanIndirimTutari.StatusBarAciklama = null;
            this.colPlanIndirimTutari.StatusBarKisaYol = null;
            this.colPlanIndirimTutari.StatusBarKisaYolAciklama = null;
            this.colPlanIndirimTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanIndirimTutari", "{0:n2}")});
            this.colPlanIndirimTutari.Visible = true;
            this.colPlanIndirimTutari.Width = 90;
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
            this.colPlanNetTutar.Width = 90;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Fatura Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colFaturaNo);
            this.gridBand2.Columns.Add(this.colTahakkukTarih);
            this.gridBand2.Columns.Add(this.colTahakkukTutari);
            this.gridBand2.Columns.Add(this.colTahakkukIndirimTutari);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 360;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.Caption = "Fatura No";
            this.colFaturaNo.FieldName = "FaturaNo";
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.OptionsColumn.AllowEdit = false;
            this.colFaturaNo.StatusBarAciklama = null;
            this.colFaturaNo.StatusBarKisaYol = null;
            this.colFaturaNo.StatusBarKisaYolAciklama = null;
            this.colFaturaNo.Visible = true;
            this.colFaturaNo.Width = 90;
            // 
            // colTahakkukTarih
            // 
            this.colTahakkukTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTahakkukTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTahakkukTarih.Caption = "Tarih";
            this.colTahakkukTarih.ColumnEdit = this.repositoryItemTarih;
            this.colTahakkukTarih.CustomizationCaption = "Tahakkuk Tarihi";
            this.colTahakkukTarih.FieldName = "TahakkukTarih";
            this.colTahakkukTarih.Name = "colTahakkukTarih";
            this.colTahakkukTarih.OptionsColumn.AllowEdit = false;
            this.colTahakkukTarih.StatusBarAciklama = null;
            this.colTahakkukTarih.StatusBarKisaYol = null;
            this.colTahakkukTarih.StatusBarKisaYolAciklama = null;
            this.colTahakkukTarih.Visible = true;
            this.colTahakkukTarih.Width = 90;
            // 
            // colTahakkukTutari
            // 
            this.colTahakkukTutari.Caption = "Tutar";
            this.colTahakkukTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colTahakkukTutari.CustomizationCaption = "Tahakkuk Tutar";
            this.colTahakkukTutari.FieldName = "TahakkukTutari";
            this.colTahakkukTutari.Name = "colTahakkukTutari";
            this.colTahakkukTutari.OptionsColumn.AllowEdit = false;
            this.colTahakkukTutari.StatusBarAciklama = null;
            this.colTahakkukTutari.StatusBarKisaYol = null;
            this.colTahakkukTutari.StatusBarKisaYolAciklama = null;
            this.colTahakkukTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukTutari", "{0:n2}")});
            this.colTahakkukTutari.Visible = true;
            this.colTahakkukTutari.Width = 90;
            // 
            // colTahakkukIndirimTutari
            // 
            this.colTahakkukIndirimTutari.Caption = "İndirim";
            this.colTahakkukIndirimTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colTahakkukIndirimTutari.CustomizationCaption = "Tahakkuk İndirim";
            this.colTahakkukIndirimTutari.FieldName = "TahakkukIndirimTutari";
            this.colTahakkukIndirimTutari.Name = "colTahakkukIndirimTutari";
            this.colTahakkukIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colTahakkukIndirimTutari.StatusBarAciklama = null;
            this.colTahakkukIndirimTutari.StatusBarKisaYol = null;
            this.colTahakkukIndirimTutari.StatusBarKisaYolAciklama = null;
            this.colTahakkukIndirimTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukIndirimTutari", "{0:n2}")});
            this.colTahakkukIndirimTutari.Visible = true;
            this.colTahakkukIndirimTutari.Width = 90;
            // 
            // colTahakkukNetTutar
            // 
            this.colTahakkukNetTutar.Caption = "Net Tutar";
            this.colTahakkukNetTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colTahakkukNetTutar.CustomizationCaption = "Tahakkuk Net Tutar";
            this.colTahakkukNetTutar.FieldName = "TahakkukNetTutar";
            this.colTahakkukNetTutar.Name = "colTahakkukNetTutar";
            this.colTahakkukNetTutar.OptionsColumn.AllowEdit = false;
            this.colTahakkukNetTutar.StatusBarAciklama = null;
            this.colTahakkukNetTutar.StatusBarKisaYol = null;
            this.colTahakkukNetTutar.StatusBarKisaYolAciklama = null;
            this.colTahakkukNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TahakkukNetTutar", "{0:n2}")});
            this.colTahakkukNetTutar.Visible = true;
            this.colTahakkukNetTutar.Width = 90;
            // 
            // FaturaPlaniTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "FaturaPlaniTable";
            this.Size = new System.Drawing.Size(796, 332);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Grids.MyBandedGridControl grid;
        private Grids.MyBandedGridView view;
        private Grids.MyBandedGridColumn colAciklama;
        private Grids.MyBandedGridColumn colPlanTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private Grids.MyBandedGridColumn colPlanTutari;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private Grids.MyBandedGridColumn colPlanIndirimTutari;
        private Grids.MyBandedGridColumn colPlanNetTutar;
        private Grids.MyBandedGridColumn colFaturaNo;
        private Grids.MyBandedGridColumn colTahakkukTarih;
        private Grids.MyBandedGridColumn colTahakkukTutari;
        private Grids.MyBandedGridColumn colTahakkukIndirimTutari;
        private Grids.MyBandedGridColumn colTahakkukNetTutar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}
