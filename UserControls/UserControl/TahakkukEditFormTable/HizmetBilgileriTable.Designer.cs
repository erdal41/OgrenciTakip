
namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class HizmetBilgileriTable
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colHizmetId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetTuruId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIslemTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colServisId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colServisYeriAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBrutUcret = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKistDonemDusulenUcret = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetUcret = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalEdildi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colEgitimDonemiGunSayisi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAlinanHizmetGunSayisi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGunlukUcret = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemIptalTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIptalNedeniId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalNedeniAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemIptalNedeni = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colGittigiOkulId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGittigiOkulAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemGittigiOkul = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIptalAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalNedeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGittigiOkul)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 252);
            this.insUpNavigator.Size = new System.Drawing.Size(747, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTarih,
            this.repositoryItemDecimal,
            this.repositoryItemIptalNedeni,
            this.repositoryItemGittigiOkul,
            this.repositoryItemIptalTarihi});
            this.grid.Size = new System.Drawing.Size(747, 252);
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
            this.colHizmetId,
            this.colHizmetAdi,
            this.colHizmetTuruId,
            this.colIslemTarihi,
            this.colServisId,
            this.colServisYeriAdi,
            this.colBaslamaTarihi,
            this.colBrutUcret,
            this.colKistDonemDusulenUcret,
            this.colNetUcret,
            this.colIptalEdildi,
            this.colEgitimDonemiGunSayisi,
            this.colAlinanHizmetGunSayisi,
            this.colGunlukUcret,
            this.colIptalTarihi,
            this.colIptalNedeniId,
            this.colIptalNedeniAdi,
            this.colGittigiOkulId,
            this.colGittigiOkulAdi,
            this.colIptalAciklama});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colIptalEdildi;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.MistyRose;
            formatConditionRuleValue1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Options.HighPriority = true;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = true;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.view.FormatRules.Add(gridFormatRule1);
            this.view.GridControl = this.grid;
            this.view.Name = "view";
            this.view.OptionsCustomization.AllowColumnMoving = false;
            this.view.OptionsCustomization.AllowFilter = false;
            this.view.OptionsCustomization.AllowSort = false;
            this.view.OptionsMenu.EnableColumnMenu = false;
            this.view.OptionsMenu.EnableFooterMenu = false;
            this.view.OptionsMenu.EnableGroupPanelMenu = false;
            this.view.OptionsNavigation.EnterMoveNextColumn = true;
            this.view.OptionsPrint.AutoWidth = false;
            this.view.OptionsPrint.PrintFooter = false;
            this.view.OptionsPrint.PrintGroupFooter = false;
            this.view.OptionsView.ColumnAutoWidth = false;
            this.view.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.view.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.view.OptionsView.RowAutoHeight = true;
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = "Öğrenciye verilen hizmetleri seçiniz.";
            this.view.StatusBarKisaYol = "Shift+Insert";
            this.view.StatusBarKisaYolAciklama = "Seçim Yap";
            this.view.ViewCaption = "HİZMET BİLGİLERİ";
            // 
            // colHizmetId
            // 
            this.colHizmetId.Caption = "HizmetId";
            this.colHizmetId.FieldName = "HizmetId";
            this.colHizmetId.Name = "colHizmetId";
            this.colHizmetId.OptionsColumn.AllowEdit = false;
            this.colHizmetId.OptionsColumn.ShowInCustomizationForm = false;
            this.colHizmetId.StatusBarAciklama = null;
            this.colHizmetId.StatusBarKisaYol = null;
            this.colHizmetId.StatusBarKisaYolAciklama = null;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "Hizmet Adı";
            this.colHizmetAdi.FieldName = "HizmetAdi";
            this.colHizmetAdi.Name = "colHizmetAdi";
            this.colHizmetAdi.OptionsColumn.AllowEdit = false;
            this.colHizmetAdi.OptionsColumn.AllowMove = false;
            this.colHizmetAdi.OptionsColumn.AllowShowHide = false;
            this.colHizmetAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHizmetAdi.OptionsFilter.AllowAutoFilter = false;
            this.colHizmetAdi.OptionsFilter.AllowFilter = false;
            this.colHizmetAdi.StatusBarAciklama = null;
            this.colHizmetAdi.StatusBarKisaYol = null;
            this.colHizmetAdi.StatusBarKisaYolAciklama = null;
            this.colHizmetAdi.Visible = true;
            this.colHizmetAdi.VisibleIndex = 0;
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
            // colIslemTarihi
            // 
            this.colIslemTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIslemTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIslemTarihi.Caption = "İşlem Tarihi";
            this.colIslemTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colIslemTarihi.FieldName = "IslemTarihi";
            this.colIslemTarihi.Name = "colIslemTarihi";
            this.colIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colIslemTarihi.OptionsColumn.AllowMove = false;
            this.colIslemTarihi.OptionsColumn.AllowShowHide = false;
            this.colIslemTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIslemTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colIslemTarihi.OptionsFilter.AllowFilter = false;
            this.colIslemTarihi.StatusBarAciklama = null;
            this.colIslemTarihi.StatusBarKisaYol = null;
            this.colIslemTarihi.StatusBarKisaYolAciklama = null;
            this.colIslemTarihi.Visible = true;
            this.colIslemTarihi.VisibleIndex = 5;
            this.colIslemTarihi.Width = 100;
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
            // colServisId
            // 
            this.colServisId.Caption = "ServisId";
            this.colServisId.FieldName = "ServisId";
            this.colServisId.Name = "colServisId";
            this.colServisId.OptionsColumn.AllowEdit = false;
            this.colServisId.OptionsColumn.ShowInCustomizationForm = false;
            this.colServisId.StatusBarAciklama = null;
            this.colServisId.StatusBarKisaYol = null;
            this.colServisId.StatusBarKisaYolAciklama = null;
            // 
            // colServisYeriAdi
            // 
            this.colServisYeriAdi.Caption = "Servis Yeri";
            this.colServisYeriAdi.FieldName = "ServisYeriAdi";
            this.colServisYeriAdi.Name = "colServisYeriAdi";
            this.colServisYeriAdi.OptionsColumn.AllowEdit = false;
            this.colServisYeriAdi.OptionsColumn.AllowMove = false;
            this.colServisYeriAdi.OptionsColumn.AllowShowHide = false;
            this.colServisYeriAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colServisYeriAdi.OptionsFilter.AllowAutoFilter = false;
            this.colServisYeriAdi.OptionsFilter.AllowFilter = false;
            this.colServisYeriAdi.StatusBarAciklama = null;
            this.colServisYeriAdi.StatusBarKisaYol = null;
            this.colServisYeriAdi.StatusBarKisaYolAciklama = null;
            this.colServisYeriAdi.Width = 100;
            // 
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBaslamaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaslamaTarihi.Caption = "Başlama Tarihi";
            this.colBaslamaTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslamaTarihi.OptionsColumn.AllowMove = false;
            this.colBaslamaTarihi.OptionsColumn.AllowShowHide = false;
            this.colBaslamaTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBaslamaTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colBaslamaTarihi.OptionsFilter.AllowFilter = false;
            this.colBaslamaTarihi.StatusBarAciklama = null;
            this.colBaslamaTarihi.StatusBarKisaYol = null;
            this.colBaslamaTarihi.StatusBarKisaYolAciklama = null;
            this.colBaslamaTarihi.Visible = true;
            this.colBaslamaTarihi.VisibleIndex = 1;
            this.colBaslamaTarihi.Width = 100;
            // 
            // colBrutUcret
            // 
            this.colBrutUcret.Caption = "Brüt Ücret";
            this.colBrutUcret.ColumnEdit = this.repositoryItemDecimal;
            this.colBrutUcret.FieldName = "BrutUcret";
            this.colBrutUcret.Name = "colBrutUcret";
            this.colBrutUcret.OptionsColumn.AllowEdit = false;
            this.colBrutUcret.OptionsColumn.AllowMove = false;
            this.colBrutUcret.OptionsColumn.AllowShowHide = false;
            this.colBrutUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBrutUcret.OptionsFilter.AllowAutoFilter = false;
            this.colBrutUcret.OptionsFilter.AllowFilter = false;
            this.colBrutUcret.StatusBarAciklama = null;
            this.colBrutUcret.StatusBarKisaYol = null;
            this.colBrutUcret.StatusBarKisaYolAciklama = null;
            this.colBrutUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrutUcret", "{0:n2}")});
            this.colBrutUcret.Visible = true;
            this.colBrutUcret.VisibleIndex = 2;
            this.colBrutUcret.Width = 100;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Mask.EditMask = "n2";
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colKistDonemDusulenUcret
            // 
            this.colKistDonemDusulenUcret.Caption = "Kıst Dönem Düşülen Ücret";
            this.colKistDonemDusulenUcret.ColumnEdit = this.repositoryItemDecimal;
            this.colKistDonemDusulenUcret.FieldName = "KistDonemDusulenUcret";
            this.colKistDonemDusulenUcret.Name = "colKistDonemDusulenUcret";
            this.colKistDonemDusulenUcret.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowMove = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowShowHide = false;
            this.colKistDonemDusulenUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDonemDusulenUcret.OptionsFilter.AllowAutoFilter = false;
            this.colKistDonemDusulenUcret.OptionsFilter.AllowFilter = false;
            this.colKistDonemDusulenUcret.StatusBarAciklama = null;
            this.colKistDonemDusulenUcret.StatusBarKisaYol = null;
            this.colKistDonemDusulenUcret.StatusBarKisaYolAciklama = null;
            this.colKistDonemDusulenUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDonemDusulenUcret", "{0:n2}")});
            this.colKistDonemDusulenUcret.Visible = true;
            this.colKistDonemDusulenUcret.VisibleIndex = 3;
            this.colKistDonemDusulenUcret.Width = 100;
            // 
            // colNetUcret
            // 
            this.colNetUcret.Caption = "Net Ücret";
            this.colNetUcret.ColumnEdit = this.repositoryItemDecimal;
            this.colNetUcret.FieldName = "NetUcret";
            this.colNetUcret.Name = "colNetUcret";
            this.colNetUcret.OptionsColumn.AllowEdit = false;
            this.colNetUcret.OptionsColumn.AllowMove = false;
            this.colNetUcret.OptionsColumn.AllowShowHide = false;
            this.colNetUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetUcret.OptionsFilter.AllowAutoFilter = false;
            this.colNetUcret.OptionsFilter.AllowFilter = false;
            this.colNetUcret.StatusBarAciklama = null;
            this.colNetUcret.StatusBarKisaYol = null;
            this.colNetUcret.StatusBarKisaYolAciklama = null;
            this.colNetUcret.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetUcret", "{0:n2}")});
            this.colNetUcret.Visible = true;
            this.colNetUcret.VisibleIndex = 4;
            this.colNetUcret.Width = 100;
            // 
            // colIptalEdildi
            // 
            this.colIptalEdildi.Caption = "IptalEdildi";
            this.colIptalEdildi.FieldName = "IptalEdildi";
            this.colIptalEdildi.Name = "colIptalEdildi";
            this.colIptalEdildi.OptionsColumn.AllowEdit = false;
            this.colIptalEdildi.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalEdildi.StatusBarAciklama = null;
            this.colIptalEdildi.StatusBarKisaYol = null;
            this.colIptalEdildi.StatusBarKisaYolAciklama = null;
            // 
            // colEgitimDonemiGunSayisi
            // 
            this.colEgitimDonemiGunSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colEgitimDonemiGunSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEgitimDonemiGunSayisi.Caption = "Eğitim Dönemi Gün Sayısı";
            this.colEgitimDonemiGunSayisi.FieldName = "EgitimDonemiGunSayisi";
            this.colEgitimDonemiGunSayisi.Name = "colEgitimDonemiGunSayisi";
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowEdit = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowMove = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowShowHide = false;
            this.colEgitimDonemiGunSayisi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEgitimDonemiGunSayisi.OptionsFilter.AllowAutoFilter = false;
            this.colEgitimDonemiGunSayisi.OptionsFilter.AllowFilter = false;
            this.colEgitimDonemiGunSayisi.StatusBarAciklama = null;
            this.colEgitimDonemiGunSayisi.StatusBarKisaYol = null;
            this.colEgitimDonemiGunSayisi.StatusBarKisaYolAciklama = null;
            this.colEgitimDonemiGunSayisi.Visible = true;
            this.colEgitimDonemiGunSayisi.VisibleIndex = 6;
            this.colEgitimDonemiGunSayisi.Width = 85;
            // 
            // colAlinanHizmetGunSayisi
            // 
            this.colAlinanHizmetGunSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.colAlinanHizmetGunSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAlinanHizmetGunSayisi.Caption = "Alınan Hizmet Gün Sayısı";
            this.colAlinanHizmetGunSayisi.FieldName = "AlinanHizmetGunSayisi";
            this.colAlinanHizmetGunSayisi.Name = "colAlinanHizmetGunSayisi";
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowEdit = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowMove = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowShowHide = false;
            this.colAlinanHizmetGunSayisi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAlinanHizmetGunSayisi.OptionsFilter.AllowAutoFilter = false;
            this.colAlinanHizmetGunSayisi.OptionsFilter.AllowFilter = false;
            this.colAlinanHizmetGunSayisi.StatusBarAciklama = null;
            this.colAlinanHizmetGunSayisi.StatusBarKisaYol = null;
            this.colAlinanHizmetGunSayisi.StatusBarKisaYolAciklama = null;
            this.colAlinanHizmetGunSayisi.Visible = true;
            this.colAlinanHizmetGunSayisi.VisibleIndex = 7;
            this.colAlinanHizmetGunSayisi.Width = 85;
            // 
            // colGunlukUcret
            // 
            this.colGunlukUcret.Caption = "Günlük Ücret";
            this.colGunlukUcret.ColumnEdit = this.repositoryItemDecimal;
            this.colGunlukUcret.FieldName = "GunlukUcret";
            this.colGunlukUcret.Name = "colGunlukUcret";
            this.colGunlukUcret.OptionsColumn.AllowEdit = false;
            this.colGunlukUcret.OptionsColumn.AllowMove = false;
            this.colGunlukUcret.OptionsColumn.AllowShowHide = false;
            this.colGunlukUcret.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGunlukUcret.OptionsFilter.AllowAutoFilter = false;
            this.colGunlukUcret.OptionsFilter.AllowFilter = false;
            this.colGunlukUcret.StatusBarAciklama = null;
            this.colGunlukUcret.StatusBarKisaYol = null;
            this.colGunlukUcret.StatusBarKisaYolAciklama = null;
            this.colGunlukUcret.Visible = true;
            this.colGunlukUcret.VisibleIndex = 8;
            this.colGunlukUcret.Width = 85;
            // 
            // colIptalTarihi
            // 
            this.colIptalTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIptalTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIptalTarihi.Caption = "İptal Tarihi";
            this.colIptalTarihi.ColumnEdit = this.repositoryItemIptalTarihi;
            this.colIptalTarihi.FieldName = "IptalTarihi";
            this.colIptalTarihi.Name = "colIptalTarihi";
            this.colIptalTarihi.OptionsColumn.AllowEdit = false;
            this.colIptalTarihi.OptionsColumn.AllowMove = false;
            this.colIptalTarihi.OptionsColumn.AllowShowHide = false;
            this.colIptalTarihi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalTarihi.OptionsFilter.AllowAutoFilter = false;
            this.colIptalTarihi.OptionsFilter.AllowFilter = false;
            this.colIptalTarihi.StatusBarAciklama = "Tarih seçiniz.";
            this.colIptalTarihi.StatusBarKisaYol = "F4 : ";
            this.colIptalTarihi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colIptalTarihi.Visible = true;
            this.colIptalTarihi.VisibleIndex = 9;
            this.colIptalTarihi.Width = 100;
            // 
            // repositoryItemIptalTarihi
            // 
            this.repositoryItemIptalTarihi.AutoHeight = false;
            this.repositoryItemIptalTarihi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIptalTarihi.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIptalTarihi.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemIptalTarihi.Name = "repositoryItemIptalTarihi";
            // 
            // colIptalNedeniId
            // 
            this.colIptalNedeniId.Caption = "IptalNedeniId";
            this.colIptalNedeniId.FieldName = "IptalNedeniId";
            this.colIptalNedeniId.Name = "colIptalNedeniId";
            this.colIptalNedeniId.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniId.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalNedeniId.StatusBarAciklama = null;
            this.colIptalNedeniId.StatusBarKisaYol = null;
            this.colIptalNedeniId.StatusBarKisaYolAciklama = null;
            // 
            // colIptalNedeniAdi
            // 
            this.colIptalNedeniAdi.Caption = "İptal Nedeni Adı";
            this.colIptalNedeniAdi.ColumnEdit = this.repositoryItemIptalNedeni;
            this.colIptalNedeniAdi.FieldName = "IptalNedeniAdi";
            this.colIptalNedeniAdi.Name = "colIptalNedeniAdi";
            this.colIptalNedeniAdi.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowMove = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowShowHide = false;
            this.colIptalNedeniAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalNedeniAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIptalNedeniAdi.OptionsFilter.AllowFilter = false;
            this.colIptalNedeniAdi.StatusBarAciklama = "İptal nedeni seçiniz.";
            this.colIptalNedeniAdi.StatusBarKisaYol = "F4 : ";
            this.colIptalNedeniAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colIptalNedeniAdi.Visible = true;
            this.colIptalNedeniAdi.VisibleIndex = 10;
            this.colIptalNedeniAdi.Width = 150;
            // 
            // repositoryItemIptalNedeni
            // 
            this.repositoryItemIptalNedeni.AutoHeight = false;
            this.repositoryItemIptalNedeni.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemIptalNedeni.Name = "repositoryItemIptalNedeni";
            this.repositoryItemIptalNedeni.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colGittigiOkulId
            // 
            this.colGittigiOkulId.Caption = "GittigiOkulId";
            this.colGittigiOkulId.FieldName = "GittigiOkulId";
            this.colGittigiOkulId.Name = "colGittigiOkulId";
            this.colGittigiOkulId.OptionsColumn.AllowEdit = false;
            this.colGittigiOkulId.OptionsColumn.ShowInCustomizationForm = false;
            this.colGittigiOkulId.StatusBarAciklama = null;
            this.colGittigiOkulId.StatusBarKisaYol = null;
            this.colGittigiOkulId.StatusBarKisaYolAciklama = null;
            // 
            // colGittigiOkulAdi
            // 
            this.colGittigiOkulAdi.Caption = "Gittiği Okul Adı";
            this.colGittigiOkulAdi.ColumnEdit = this.repositoryItemGittigiOkul;
            this.colGittigiOkulAdi.FieldName = "GittigiOkulAdi";
            this.colGittigiOkulAdi.Name = "colGittigiOkulAdi";
            this.colGittigiOkulAdi.OptionsColumn.AllowEdit = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowMove = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowShowHide = false;
            this.colGittigiOkulAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGittigiOkulAdi.OptionsFilter.AllowAutoFilter = false;
            this.colGittigiOkulAdi.OptionsFilter.AllowFilter = false;
            this.colGittigiOkulAdi.StatusBarAciklama = "Okul seçiniz.";
            this.colGittigiOkulAdi.StatusBarKisaYol = "F4 : ";
            this.colGittigiOkulAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colGittigiOkulAdi.Visible = true;
            this.colGittigiOkulAdi.VisibleIndex = 11;
            this.colGittigiOkulAdi.Width = 200;
            // 
            // repositoryItemGittigiOkul
            // 
            this.repositoryItemGittigiOkul.AutoHeight = false;
            this.repositoryItemGittigiOkul.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemGittigiOkul.Name = "repositoryItemGittigiOkul";
            this.repositoryItemGittigiOkul.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colIptalAciklama
            // 
            this.colIptalAciklama.Caption = "İptal Açıklama";
            this.colIptalAciklama.FieldName = "IptalAciklama";
            this.colIptalAciklama.Name = "colIptalAciklama";
            this.colIptalAciklama.OptionsColumn.AllowEdit = false;
            this.colIptalAciklama.OptionsColumn.AllowMove = false;
            this.colIptalAciklama.OptionsColumn.AllowShowHide = false;
            this.colIptalAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIptalAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colIptalAciklama.OptionsFilter.AllowFilter = false;
            this.colIptalAciklama.StatusBarAciklama = "İptal açıklaması giriniz.";
            this.colIptalAciklama.StatusBarKisaYol = null;
            this.colIptalAciklama.StatusBarKisaYolAciklama = null;
            this.colIptalAciklama.Visible = true;
            this.colIptalAciklama.VisibleIndex = 12;
            this.colIptalAciklama.Width = 300;
            // 
            // HizmetBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "HizmetBilgileriTable";
            this.Size = new System.Drawing.Size(747, 276);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalNedeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGittigiOkul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView view;
        private Grids.MyGridColumn colHizmetId;
        private Grids.MyGridColumn colHizmetAdi;
        private Grids.MyGridColumn colHizmetTuruId;
        private Grids.MyGridColumn colServisId;
        private Grids.MyGridColumn colServisYeriAdi;
        private Grids.MyGridColumn colIslemTarihi;
        private Grids.MyGridColumn colBaslamaTarihi;
        private Grids.MyGridColumn colBrutUcret;
        private Grids.MyGridColumn colKistDonemDusulenUcret;
        private Grids.MyGridColumn colNetUcret;
        private Grids.MyGridColumn colIptalEdildi;
        private Grids.MyGridColumn colEgitimDonemiGunSayisi;
        private Grids.MyGridColumn colAlinanHizmetGunSayisi;
        private Grids.MyGridColumn colGunlukUcret;
        private Grids.MyGridColumn colIptalTarihi;
        private Grids.MyGridColumn colIptalNedeniId;
        private Grids.MyGridColumn colIptalNedeniAdi;
        private Grids.MyGridColumn colGittigiOkulId;
        private Grids.MyGridColumn colGittigiOkulAdi;
        private Grids.MyGridColumn colIptalAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemIptalNedeni;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemGittigiOkul;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemIptalTarihi;
    }
}
