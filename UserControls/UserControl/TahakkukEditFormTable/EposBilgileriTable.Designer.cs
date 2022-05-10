
namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class EposBilgileriTable
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
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBankaAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemBanka = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colKartTuru = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemKartTuru = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colKartNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemKartNo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSonKullanmaTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemSonKullanmaTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGuvenlikKodu = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemGuvenlikKodu = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemKartTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemKartNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSonKullanmaTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGuvenlikKodu)).BeginInit();
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
            this.repositoryItemBanka,
            this.repositoryItemKartTuru,
            this.repositoryItemKartNo,
            this.repositoryItemSonKullanmaTarihi,
            this.repositoryItemGuvenlikKodu});
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
            this.colAdi,
            this.colSoyadi,
            this.colBankaId,
            this.colBankaAdi,
            this.colKartTuru,
            this.colKartNo,
            this.colSonKullanmaTarihi,
            this.colGuvenlikKodu});
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
            this.view.StatusBarAciklama = "Epos bilgileri ekleyiniz.";
            this.view.StatusBarKisaYol = "Shift+Insert : ";
            this.view.StatusBarKisaYolAciklama = "Bilgi Oluştur";
            this.view.ViewCaption = "EPOS BİLGİLERİ";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAdi.OptionsFilter.AllowAutoFilter = false;
            this.colAdi.OptionsFilter.AllowFilter = false;
            this.colAdi.StatusBarAciklama = "Kart sahibinin adını giriniz.";
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 96;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoyadi.OptionsFilter.AllowAutoFilter = false;
            this.colSoyadi.OptionsFilter.AllowFilter = false;
            this.colSoyadi.StatusBarAciklama = "Kart sahibinin soyadını giriniz.";
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 96;
            // 
            // colBankaId
            // 
            this.colBankaId.Caption = "BankaId";
            this.colBankaId.FieldName = "BankaId";
            this.colBankaId.Name = "colBankaId";
            this.colBankaId.OptionsColumn.AllowEdit = false;
            this.colBankaId.OptionsColumn.ShowInCustomizationForm = false;
            this.colBankaId.StatusBarAciklama = null;
            this.colBankaId.StatusBarKisaYol = null;
            this.colBankaId.StatusBarKisaYolAciklama = null;
            // 
            // colBankaAdi
            // 
            this.colBankaAdi.Caption = "Banka Adı";
            this.colBankaAdi.ColumnEdit = this.repositoryItemBanka;
            this.colBankaAdi.FieldName = "BankaAdi";
            this.colBankaAdi.Name = "colBankaAdi";
            this.colBankaAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBankaAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBankaAdi.OptionsFilter.AllowFilter = false;
            this.colBankaAdi.StatusBarAciklama = "Banka seçiniz.";
            this.colBankaAdi.StatusBarKisaYol = "F4 : ";
            this.colBankaAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colBankaAdi.Visible = true;
            this.colBankaAdi.VisibleIndex = 2;
            this.colBankaAdi.Width = 132;
            // 
            // repositoryItemBanka
            // 
            this.repositoryItemBanka.AutoHeight = false;
            this.repositoryItemBanka.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemBanka.Name = "repositoryItemBanka";
            this.repositoryItemBanka.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colKartTuru
            // 
            this.colKartTuru.Caption = "Kart Türü";
            this.colKartTuru.ColumnEdit = this.repositoryItemKartTuru;
            this.colKartTuru.FieldName = "KartTuru";
            this.colKartTuru.Name = "colKartTuru";
            this.colKartTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKartTuru.OptionsFilter.AllowAutoFilter = false;
            this.colKartTuru.OptionsFilter.AllowFilter = false;
            this.colKartTuru.StatusBarAciklama = "Kart türünü seçiniz.";
            this.colKartTuru.StatusBarKisaYol = "F4 : ";
            this.colKartTuru.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colKartTuru.Visible = true;
            this.colKartTuru.VisibleIndex = 3;
            this.colKartTuru.Width = 96;
            // 
            // repositoryItemKartTuru
            // 
            this.repositoryItemKartTuru.AutoHeight = false;
            this.repositoryItemKartTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemKartTuru.Name = "repositoryItemKartTuru";
            // 
            // colKartNo
            // 
            this.colKartNo.AppearanceCell.Options.UseTextOptions = true;
            this.colKartNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartNo.Caption = "Kart No";
            this.colKartNo.ColumnEdit = this.repositoryItemKartNo;
            this.colKartNo.FieldName = "KartNo";
            this.colKartNo.Name = "colKartNo";
            this.colKartNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKartNo.OptionsFilter.AllowAutoFilter = false;
            this.colKartNo.OptionsFilter.AllowFilter = false;
            this.colKartNo.StatusBarAciklama = "Kart numarası giriniz.";
            this.colKartNo.StatusBarKisaYol = null;
            this.colKartNo.StatusBarKisaYolAciklama = null;
            this.colKartNo.Visible = true;
            this.colKartNo.VisibleIndex = 4;
            this.colKartNo.Width = 115;
            // 
            // repositoryItemKartNo
            // 
            this.repositoryItemKartNo.AutoHeight = false;
            this.repositoryItemKartNo.Mask.EditMask = "\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?-\\d?\\d?\\d?\\d?";
            this.repositoryItemKartNo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.repositoryItemKartNo.Name = "repositoryItemKartNo";
            // 
            // colSonKullanmaTarihi
            // 
            this.colSonKullanmaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colSonKullanmaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSonKullanmaTarihi.Caption = "Son Kullanma Tarihi";
            this.colSonKullanmaTarihi.ColumnEdit = this.repositoryItemSonKullanmaTarihi;
            this.colSonKullanmaTarihi.FieldName = "SonKullanmaTarihi";
            this.colSonKullanmaTarihi.Name = "colSonKullanmaTarihi";
            this.colSonKullanmaTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSonKullanmaTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colSonKullanmaTarihi.OptionsFilter.AllowFilter = false;
            this.colSonKullanmaTarihi.StatusBarAciklama = "Son kullanma tarihi giriniz.";
            this.colSonKullanmaTarihi.StatusBarKisaYol = null;
            this.colSonKullanmaTarihi.StatusBarKisaYolAciklama = null;
            this.colSonKullanmaTarihi.Visible = true;
            this.colSonKullanmaTarihi.VisibleIndex = 5;
            this.colSonKullanmaTarihi.Width = 56;
            // 
            // repositoryItemSonKullanmaTarihi
            // 
            this.repositoryItemSonKullanmaTarihi.AutoHeight = false;
            this.repositoryItemSonKullanmaTarihi.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.repositoryItemSonKullanmaTarihi.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemSonKullanmaTarihi.Name = "repositoryItemSonKullanmaTarihi";
            // 
            // colGuvenlikKodu
            // 
            this.colGuvenlikKodu.AppearanceCell.Options.UseTextOptions = true;
            this.colGuvenlikKodu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGuvenlikKodu.Caption = "Güvenlik Kodu";
            this.colGuvenlikKodu.ColumnEdit = this.repositoryItemGuvenlikKodu;
            this.colGuvenlikKodu.FieldName = "GuvenlikKodu";
            this.colGuvenlikKodu.Name = "colGuvenlikKodu";
            this.colGuvenlikKodu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGuvenlikKodu.OptionsFilter.AllowAutoFilter = false;
            this.colGuvenlikKodu.OptionsFilter.AllowFilter = false;
            this.colGuvenlikKodu.StatusBarAciklama = "Güvenlik kodunu giriniz.";
            this.colGuvenlikKodu.StatusBarKisaYol = null;
            this.colGuvenlikKodu.StatusBarKisaYolAciklama = null;
            this.colGuvenlikKodu.Visible = true;
            this.colGuvenlikKodu.VisibleIndex = 6;
            // 
            // repositoryItemGuvenlikKodu
            // 
            this.repositoryItemGuvenlikKodu.AutoHeight = false;
            this.repositoryItemGuvenlikKodu.Mask.EditMask = "\\d\\d\\d";
            this.repositoryItemGuvenlikKodu.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemGuvenlikKodu.Name = "repositoryItemGuvenlikKodu";
            // 
            // EposBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "EposBilgileriTable";
            this.Size = new System.Drawing.Size(636, 290);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemKartTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemKartNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSonKullanmaTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGuvenlikKodu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView view;
        private Grids.MyGridColumn colAdi;
        private Grids.MyGridColumn colSoyadi;
        private Grids.MyGridColumn colBankaId;
        private Grids.MyGridColumn colBankaAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBanka;
        private Grids.MyGridColumn colKartTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemKartTuru;
        private Grids.MyGridColumn colKartNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemKartNo;
        private Grids.MyGridColumn colSonKullanmaTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemSonKullanmaTarihi;
        private Grids.MyGridColumn colGuvenlikKodu;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemGuvenlikKodu;
    }
}
