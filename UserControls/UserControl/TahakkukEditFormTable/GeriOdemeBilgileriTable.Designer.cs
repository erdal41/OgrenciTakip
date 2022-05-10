
namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class GeriOdemeBilgileriTable
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
            this.colTarih = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colHesapTuru = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemHesapTuru = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colHesapId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHesapAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemHesap = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colTutar = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTutar = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHesapTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 266);
            this.insUpNavigator.Size = new System.Drawing.Size(636, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih,
            this.repositoryItemHesap,
            this.repositoryItemTutar,
            this.repositoryItemHesapTuru});
            this.grid.Size = new System.Drawing.Size(636, 266);
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
            this.colTarih,
            this.colHesapTuru,
            this.colHesapId,
            this.colHesapAdi,
            this.colTutar,
            this.colAciklama});
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsCustomization.AllowColumnMoving = false;
            this.view.OptionsCustomization.AllowSort = false;
            this.view.OptionsMenu.EnableColumnMenu = false;
            this.view.OptionsMenu.EnableFooterMenu = false;
            this.view.OptionsMenu.EnableGroupPanelMenu = false;
            this.view.OptionsNavigation.EnterMoveNextColumn = true;
            this.view.OptionsPrint.AutoWidth = false;
            this.view.OptionsPrint.PrintFooter = false;
            this.view.OptionsPrint.PrintGroupFooter = false;
            this.view.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.view.OptionsView.RowAutoHeight = true;
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = "Geri ödeme bilgileri giriniz.";
            this.view.StatusBarKisaYol = "Shift+Insert : ";
            this.view.StatusBarKisaYolAciklama = "Hareket Ekle";
            this.view.ViewCaption = "GERİ ÖDEME BİLGİLERİ";
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryItemTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsFilter.AllowAutoFilter = false;
            this.colTarih.OptionsFilter.AllowFilter = false;
            this.colTarih.StatusBarAciklama = "Tarih seçiniz.";
            this.colTarih.StatusBarKisaYol = "F4 : ";
            this.colTarih.StatusBarKisaYolAciklama = "Tarih Seç";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 90;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
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
            // colHesapTuru
            // 
            this.colHesapTuru.Caption = "Hesap Türü";
            this.colHesapTuru.ColumnEdit = this.repositoryItemHesapTuru;
            this.colHesapTuru.FieldName = "HesapTuru";
            this.colHesapTuru.Name = "colHesapTuru";
            this.colHesapTuru.OptionsFilter.AllowAutoFilter = false;
            this.colHesapTuru.OptionsFilter.AllowFilter = false;
            this.colHesapTuru.StatusBarAciklama = "Hesap türü seçiniz.";
            this.colHesapTuru.StatusBarKisaYol = "F4 : ";
            this.colHesapTuru.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colHesapTuru.Visible = true;
            this.colHesapTuru.VisibleIndex = 1;
            this.colHesapTuru.Width = 90;
            // 
            // repositoryItemHesapTuru
            // 
            this.repositoryItemHesapTuru.AutoHeight = false;
            this.repositoryItemHesapTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemHesapTuru.Name = "repositoryItemHesapTuru";
            // 
            // colHesapId
            // 
            this.colHesapId.Caption = "colHesapId";
            this.colHesapId.FieldName = "HesapId";
            this.colHesapId.Name = "colHesapId";
            this.colHesapId.OptionsColumn.AllowEdit = false;
            this.colHesapId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHesapId.OptionsFilter.AllowAutoFilter = false;
            this.colHesapId.OptionsFilter.AllowFilter = false;
            this.colHesapId.StatusBarAciklama = null;
            this.colHesapId.StatusBarKisaYol = null;
            this.colHesapId.StatusBarKisaYolAciklama = null;
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.ColumnEdit = this.repositoryItemHesap;
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.OptionsFilter.AllowAutoFilter = false;
            this.colHesapAdi.OptionsFilter.AllowFilter = false;
            this.colHesapAdi.StatusBarAciklama = "Hesap seçiniz.";
            this.colHesapAdi.StatusBarKisaYol = "F4 : ";
            this.colHesapAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 2;
            this.colHesapAdi.Width = 150;
            // 
            // repositoryItemHesap
            // 
            this.repositoryItemHesap.AutoHeight = false;
            this.repositoryItemHesap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemHesap.Name = "repositoryItemHesap";
            this.repositoryItemHesap.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryItemTutar;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsFilter.AllowAutoFilter = false;
            this.colTutar.OptionsFilter.AllowFilter = false;
            this.colTutar.StatusBarAciklama = "Tutar giriniz.";
            this.colTutar.StatusBarKisaYol = "F4 : ";
            this.colTutar.StatusBarKisaYolAciklama = "Hesap Makinesi";
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:n2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Width = 90;
            // 
            // repositoryItemTutar
            // 
            this.repositoryItemTutar.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
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
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colAciklama.OptionsFilter.AllowFilter = false;
            this.colAciklama.StatusBarAciklama = "Açıklama giriniz.";
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 300;
            // 
            // GeriOdemeBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "GeriOdemeBilgileriTable";
            this.Size = new System.Drawing.Size(636, 290);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHesapTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView view;
        private Grids.MyGridColumn colTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private Grids.MyGridColumn colHesapTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemHesapTuru;
        private Grids.MyGridColumn colHesapId;
        private Grids.MyGridColumn colHesapAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemHesap;
        private Grids.MyGridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemTutar;
        private Grids.MyGridColumn colAciklama;
    }
}
