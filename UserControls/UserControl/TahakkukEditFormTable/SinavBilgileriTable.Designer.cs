
namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class SinavBilgileriTable
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
            this.colSinavAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTarih = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPuanTuru = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colPuan = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemPuan = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colSira = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemSira = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colYuzde = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemYuzde = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYuzde)).BeginInit();
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
            this.repositoryItemPuan,
            this.repositoryItemSira,
            this.repositoryItemYuzde});
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
            this.colSinavAdi,
            this.colTarih,
            this.colPuanTuru,
            this.colPuan,
            this.colSira,
            this.colYuzde});
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
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = "Sınav bilgisi giriniz.";
            this.view.StatusBarKisaYol = "Shift+Insert : ";
            this.view.StatusBarKisaYolAciklama = "Sınav Ekle";
            this.view.ViewCaption = "SINAV BİLGİLERİ";
            // 
            // colSinavAdi
            // 
            this.colSinavAdi.Caption = "Sınav Adı";
            this.colSinavAdi.FieldName = "SinavAdi";
            this.colSinavAdi.Name = "colSinavAdi";
            this.colSinavAdi.StatusBarAciklama = "Sınav adı giriniz.";
            this.colSinavAdi.StatusBarKisaYol = null;
            this.colSinavAdi.StatusBarKisaYolAciklama = null;
            this.colSinavAdi.Visible = true;
            this.colSinavAdi.VisibleIndex = 0;
            this.colSinavAdi.Width = 144;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.ColumnEdit = this.repositoryItemTarih;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.StatusBarAciklama = "Tarih seçiniz.";
            this.colTarih.StatusBarKisaYol = "F4 : ";
            this.colTarih.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            this.colTarih.Width = 110;
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
            // colPuanTuru
            // 
            this.colPuanTuru.Caption = "Puan Türü";
            this.colPuanTuru.FieldName = "PuanTuru";
            this.colPuanTuru.Name = "colPuanTuru";
            this.colPuanTuru.StatusBarAciklama = "Puan türü giriniz.";
            this.colPuanTuru.StatusBarKisaYol = null;
            this.colPuanTuru.StatusBarKisaYolAciklama = null;
            this.colPuanTuru.Visible = true;
            this.colPuanTuru.VisibleIndex = 2;
            this.colPuanTuru.Width = 86;
            // 
            // colPuan
            // 
            this.colPuan.Caption = "Puan";
            this.colPuan.ColumnEdit = this.repositoryItemPuan;
            this.colPuan.FieldName = "Puan";
            this.colPuan.Name = "colPuan";
            this.colPuan.StatusBarAciklama = "Puan giriniz.";
            this.colPuan.StatusBarKisaYol = null;
            this.colPuan.StatusBarKisaYolAciklama = null;
            this.colPuan.Visible = true;
            this.colPuan.VisibleIndex = 3;
            this.colPuan.Width = 86;
            // 
            // repositoryItemPuan
            // 
            this.repositoryItemPuan.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemPuan.AutoHeight = false;
            this.repositoryItemPuan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPuan.DisplayFormat.FormatString = "n5";
            this.repositoryItemPuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemPuan.EditFormat.FormatString = "n5";
            this.repositoryItemPuan.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemPuan.Mask.EditMask = "n5";
            this.repositoryItemPuan.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            327680});
            this.repositoryItemPuan.Name = "repositoryItemPuan";
            // 
            // colSira
            // 
            this.colSira.Caption = "Sıra";
            this.colSira.ColumnEdit = this.repositoryItemSira;
            this.colSira.FieldName = "Sira";
            this.colSira.Name = "colSira";
            this.colSira.StatusBarAciklama = "Sınav sıra numarasını giriniz.";
            this.colSira.StatusBarKisaYol = null;
            this.colSira.StatusBarKisaYolAciklama = null;
            this.colSira.Visible = true;
            this.colSira.VisibleIndex = 4;
            this.colSira.Width = 86;
            // 
            // repositoryItemSira
            // 
            this.repositoryItemSira.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemSira.AutoHeight = false;
            this.repositoryItemSira.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSira.DisplayFormat.FormatString = "n0";
            this.repositoryItemSira.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSira.EditFormat.FormatString = "n0";
            this.repositoryItemSira.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSira.Mask.EditMask = "n0";
            this.repositoryItemSira.Name = "repositoryItemSira";
            // 
            // colYuzde
            // 
            this.colYuzde.Caption = "Derece (%)";
            this.colYuzde.ColumnEdit = this.repositoryItemYuzde;
            this.colYuzde.FieldName = "Yuzde";
            this.colYuzde.Name = "colYuzde";
            this.colYuzde.StatusBarAciklama = "Sınav başarı derecesini giriniz.";
            this.colYuzde.StatusBarKisaYol = null;
            this.colYuzde.StatusBarKisaYolAciklama = null;
            this.colYuzde.Visible = true;
            this.colYuzde.VisibleIndex = 5;
            this.colYuzde.Width = 99;
            // 
            // repositoryItemYuzde
            // 
            this.repositoryItemYuzde.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemYuzde.AutoHeight = false;
            this.repositoryItemYuzde.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemYuzde.DisplayFormat.FormatString = "n4";
            this.repositoryItemYuzde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemYuzde.EditFormat.FormatString = "n4";
            this.repositoryItemYuzde.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemYuzde.Mask.EditMask = "n4";
            this.repositoryItemYuzde.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            262144});
            this.repositoryItemYuzde.Name = "repositoryItemYuzde";
            // 
            // SinavBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "SinavBilgileriTable";
            this.Size = new System.Drawing.Size(636, 290);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYuzde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView view;
        private Grids.MyGridColumn colSinavAdi;
        private Grids.MyGridColumn colTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private Grids.MyGridColumn colPuanTuru;
        private Grids.MyGridColumn colPuan;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemPuan;
        private Grids.MyGridColumn colSira;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemSira;
        private Grids.MyGridColumn colYuzde;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemYuzde;
    }
}
