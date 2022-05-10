
namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class IndirimBilgileriTable
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
            this.colIptalEdildi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colIndirimAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHizmetAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIslemTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIptalTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemIptalTarihi = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colBrutIndirim = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKistDonemDusulenIndirim = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetIndirim = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalNedeniId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIptalNedeniAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemIptalNedeni = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIptalAciklama = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalNedeni)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 252);
            this.insUpNavigator.Size = new System.Drawing.Size(747, 24);
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
            this.colIndirimAdi,
            this.colHizmetAdi,
            this.colIslemTarihi,
            this.colIptalTarihi,
            this.colIptalEdildi,
            this.colBrutIndirim,
            this.colKistDonemDusulenIndirim,
            this.colNetIndirim,
            this.colIptalNedeniId,
            this.colIptalNedeniAdi,
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
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowFooter = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = "Öğrenciye uygulanan indirimleri seçiniz.";
            this.view.StatusBarKisaYol = "Shift+Insert";
            this.view.StatusBarKisaYolAciklama = "Seçim Yap";
            this.view.ViewCaption = "İNDİRİM BİLGİLERİ";
            // 
            // colIndirimAdi
            // 
            this.colIndirimAdi.Caption = "İndirim Adı";
            this.colIndirimAdi.FieldName = "IndirimAdi";
            this.colIndirimAdi.Name = "colIndirimAdi";
            this.colIndirimAdi.OptionsColumn.AllowEdit = false;
            this.colIndirimAdi.OptionsFilter.AllowAutoFilter = false;
            this.colIndirimAdi.OptionsFilter.AllowFilter = false;
            this.colIndirimAdi.StatusBarAciklama = null;
            this.colIndirimAdi.StatusBarKisaYol = null;
            this.colIndirimAdi.StatusBarKisaYolAciklama = null;
            this.colIndirimAdi.Visible = true;
            this.colIndirimAdi.VisibleIndex = 0;
            this.colIndirimAdi.Width = 250;
            // 
            // colHizmetAdi
            // 
            this.colHizmetAdi.Caption = "İndirimin Uygulanacağı Hizmet";
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
            this.colHizmetAdi.VisibleIndex = 1;
            this.colHizmetAdi.Width = 250;
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
            this.colIptalTarihi.VisibleIndex = 6;
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
            // colBrutIndirim
            // 
            this.colBrutIndirim.Caption = "Brüt İndirim";
            this.colBrutIndirim.ColumnEdit = this.repositoryItemDecimal;
            this.colBrutIndirim.FieldName = "BrutIndirim";
            this.colBrutIndirim.Name = "colBrutIndirim";
            this.colBrutIndirim.OptionsColumn.AllowEdit = false;
            this.colBrutIndirim.OptionsColumn.AllowMove = false;
            this.colBrutIndirim.OptionsColumn.AllowShowHide = false;
            this.colBrutIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBrutIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colBrutIndirim.OptionsFilter.AllowFilter = false;
            this.colBrutIndirim.StatusBarAciklama = "Tutar giriniz.";
            this.colBrutIndirim.StatusBarKisaYol = "F4 : ";
            this.colBrutIndirim.StatusBarKisaYolAciklama = "Hesap Makinesi";
            this.colBrutIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BrutIndirim", "{0:n2}")});
            this.colBrutIndirim.Visible = true;
            this.colBrutIndirim.VisibleIndex = 2;
            this.colBrutIndirim.Width = 100;
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
            // colKistDonemDusulenIndirim
            // 
            this.colKistDonemDusulenIndirim.Caption = "Kıst Dönem Düşülen İndirim";
            this.colKistDonemDusulenIndirim.ColumnEdit = this.repositoryItemDecimal;
            this.colKistDonemDusulenIndirim.FieldName = "KistDonemDusulenIndirim";
            this.colKistDonemDusulenIndirim.Name = "colKistDonemDusulenIndirim";
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowMove = false;
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowShowHide = false;
            this.colKistDonemDusulenIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDonemDusulenIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colKistDonemDusulenIndirim.OptionsFilter.AllowFilter = false;
            this.colKistDonemDusulenIndirim.StatusBarAciklama = "Tutar giriniz.";
            this.colKistDonemDusulenIndirim.StatusBarKisaYol = "F4 : ";
            this.colKistDonemDusulenIndirim.StatusBarKisaYolAciklama = "Hesap Makinesi";
            this.colKistDonemDusulenIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KistDonemDusulenIndirim", "{0:n2}")});
            this.colKistDonemDusulenIndirim.Visible = true;
            this.colKistDonemDusulenIndirim.VisibleIndex = 3;
            this.colKistDonemDusulenIndirim.Width = 95;
            // 
            // colNetIndirim
            // 
            this.colNetIndirim.Caption = "Net İndirim";
            this.colNetIndirim.ColumnEdit = this.repositoryItemDecimal;
            this.colNetIndirim.FieldName = "NetIndirim";
            this.colNetIndirim.Name = "colNetIndirim";
            this.colNetIndirim.OptionsColumn.AllowEdit = false;
            this.colNetIndirim.OptionsColumn.AllowMove = false;
            this.colNetIndirim.OptionsColumn.AllowShowHide = false;
            this.colNetIndirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetIndirim.OptionsFilter.AllowAutoFilter = false;
            this.colNetIndirim.OptionsFilter.AllowFilter = false;
            this.colNetIndirim.StatusBarAciklama = null;
            this.colNetIndirim.StatusBarKisaYol = null;
            this.colNetIndirim.StatusBarKisaYolAciklama = null;
            this.colNetIndirim.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetIndirim", "{0:n2}")});
            this.colNetIndirim.Visible = true;
            this.colNetIndirim.VisibleIndex = 4;
            this.colNetIndirim.Width = 100;
            // 
            // colIptalNedeniId
            // 
            this.colIptalNedeniId.Caption = "IptalNedeniId";
            this.colIptalNedeniId.FieldName = "IptalNedeniId";
            this.colIptalNedeniId.Name = "colIptalNedeniId";
            this.colIptalNedeniId.OptionsColumn.AllowEdit = false;
            this.colIptalNedeniId.OptionsColumn.ShowInCustomizationForm = false;
            this.colIptalNedeniId.OptionsFilter.AllowAutoFilter = false;
            this.colIptalNedeniId.OptionsFilter.AllowFilter = false;
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
            this.colIptalNedeniAdi.StatusBarAciklama = "İptal  nedeni seçiniz.";
            this.colIptalNedeniAdi.StatusBarKisaYol = "F4 : ";
            this.colIptalNedeniAdi.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colIptalNedeniAdi.Visible = true;
            this.colIptalNedeniAdi.VisibleIndex = 7;
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
            this.colIptalAciklama.StatusBarAciklama = "İptal nedeni açıklaması giriniz.";
            this.colIptalAciklama.StatusBarKisaYol = null;
            this.colIptalAciklama.StatusBarKisaYolAciklama = null;
            this.colIptalAciklama.Visible = true;
            this.colIptalAciklama.VisibleIndex = 8;
            this.colIptalAciklama.Width = 300;
            // 
            // IndirimBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "IndirimBilgileriTable";
            this.Size = new System.Drawing.Size(747, 276);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIptalNedeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView view;
        private Grids.MyGridColumn colHizmetAdi;
        private Grids.MyGridColumn colIslemTarihi;
        private Grids.MyGridColumn colBrutIndirim;
        private Grids.MyGridColumn colKistDonemDusulenIndirim;
        private Grids.MyGridColumn colNetIndirim;
        private Grids.MyGridColumn colIptalTarihi;
        private Grids.MyGridColumn colIptalNedeniId;
        private Grids.MyGridColumn colIptalNedeniAdi;
        private Grids.MyGridColumn colIptalAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemIptalNedeni;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemIptalTarihi;
        private Grids.MyGridColumn colIndirimAdi;
        private Grids.MyGridColumn colIptalEdildi;
    }
}
