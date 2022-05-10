
namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    partial class TahakkukBilgileriTable
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
            this.colSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDonemAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBrutHizmet = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKistDonemDusulenHizmet = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetHizmet = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBrutIndirim = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKistDonemDusulenIndirim = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetIndirim = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colNetUcret = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 276);
            this.insUpNavigator.Size = new System.Drawing.Size(853, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.view;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDecimal});
            this.grid.Size = new System.Drawing.Size(853, 276);
            this.grid.TabIndex = 6;
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
            this.colSubeAdi,
            this.colDonemAdi,
            this.colBrutHizmet,
            this.colKistDonemDusulenHizmet,
            this.colNetHizmet,
            this.colBrutIndirim,
            this.colKistDonemDusulenIndirim,
            this.colNetIndirim,
            this.colNetUcret});
            gridFormatRule1.ApplyToRow = true;
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
            this.view.StatusBarAciklama = "Öğrenciye yapılan ücret tahakkukları";
            this.view.StatusBarKisaYol = "";
            this.view.StatusBarKisaYolAciklama = "";
            this.view.ViewCaption = "TAHAKKUKLAR";
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.OptionsColumn.AllowMove = false;
            this.colSubeAdi.OptionsColumn.AllowShowHide = false;
            this.colSubeAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSubeAdi.OptionsFilter.AllowAutoFilter = false;
            this.colSubeAdi.OptionsFilter.AllowFilter = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisaYol = null;
            this.colSubeAdi.StatusBarKisaYolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 0;
            this.colSubeAdi.Width = 92;
            // 
            // colDonemAdi
            // 
            this.colDonemAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colDonemAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDonemAdi.Caption = "Dönem";
            this.colDonemAdi.FieldName = "DonemAdi";
            this.colDonemAdi.Name = "colDonemAdi";
            this.colDonemAdi.OptionsColumn.AllowEdit = false;
            this.colDonemAdi.OptionsColumn.AllowMove = false;
            this.colDonemAdi.OptionsColumn.AllowShowHide = false;
            this.colDonemAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDonemAdi.OptionsFilter.AllowAutoFilter = false;
            this.colDonemAdi.OptionsFilter.AllowFilter = false;
            this.colDonemAdi.StatusBarAciklama = null;
            this.colDonemAdi.StatusBarKisaYol = null;
            this.colDonemAdi.StatusBarKisaYolAciklama = null;
            this.colDonemAdi.Visible = true;
            this.colDonemAdi.VisibleIndex = 1;
            this.colDonemAdi.Width = 91;
            // 
            // colBrutHizmet
            // 
            this.colBrutHizmet.Caption = "Brüt Hizmet";
            this.colBrutHizmet.ColumnEdit = this.repositoryItemDecimal;
            this.colBrutHizmet.FieldName = "BrutHizmet";
            this.colBrutHizmet.Name = "colBrutHizmet";
            this.colBrutHizmet.OptionsColumn.AllowEdit = false;
            this.colBrutHizmet.OptionsColumn.AllowMove = false;
            this.colBrutHizmet.OptionsColumn.AllowShowHide = false;
            this.colBrutHizmet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBrutHizmet.OptionsFilter.AllowAutoFilter = false;
            this.colBrutHizmet.OptionsFilter.AllowFilter = false;
            this.colBrutHizmet.StatusBarAciklama = null;
            this.colBrutHizmet.StatusBarKisaYol = null;
            this.colBrutHizmet.StatusBarKisaYolAciklama = null;
            this.colBrutHizmet.Visible = true;
            this.colBrutHizmet.VisibleIndex = 2;
            this.colBrutHizmet.Width = 100;
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
            this.repositoryItemDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Mask.EditMask = "n2";
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colKistDonemDusulenHizmet
            // 
            this.colKistDonemDusulenHizmet.Caption = "Kıst Dönem Düşülen Hizmet";
            this.colKistDonemDusulenHizmet.ColumnEdit = this.repositoryItemDecimal;
            this.colKistDonemDusulenHizmet.FieldName = "KistDonemDusulenHizmet";
            this.colKistDonemDusulenHizmet.Name = "colKistDonemDusulenHizmet";
            this.colKistDonemDusulenHizmet.OptionsColumn.AllowEdit = false;
            this.colKistDonemDusulenHizmet.OptionsColumn.AllowMove = false;
            this.colKistDonemDusulenHizmet.OptionsColumn.AllowShowHide = false;
            this.colKistDonemDusulenHizmet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKistDonemDusulenHizmet.OptionsFilter.AllowAutoFilter = false;
            this.colKistDonemDusulenHizmet.OptionsFilter.AllowFilter = false;
            this.colKistDonemDusulenHizmet.StatusBarAciklama = null;
            this.colKistDonemDusulenHizmet.StatusBarKisaYol = null;
            this.colKistDonemDusulenHizmet.StatusBarKisaYolAciklama = null;
            this.colKistDonemDusulenHizmet.Visible = true;
            this.colKistDonemDusulenHizmet.VisibleIndex = 3;
            this.colKistDonemDusulenHizmet.Width = 100;
            // 
            // colNetHizmet
            // 
            this.colNetHizmet.Caption = "Net Hizmet";
            this.colNetHizmet.ColumnEdit = this.repositoryItemDecimal;
            this.colNetHizmet.FieldName = "NetHizmet";
            this.colNetHizmet.Name = "colNetHizmet";
            this.colNetHizmet.OptionsColumn.AllowEdit = false;
            this.colNetHizmet.OptionsColumn.AllowMove = false;
            this.colNetHizmet.OptionsColumn.AllowShowHide = false;
            this.colNetHizmet.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNetHizmet.OptionsFilter.AllowAutoFilter = false;
            this.colNetHizmet.OptionsFilter.AllowFilter = false;
            this.colNetHizmet.StatusBarAciklama = null;
            this.colNetHizmet.StatusBarKisaYol = null;
            this.colNetHizmet.StatusBarKisaYolAciklama = null;
            this.colNetHizmet.Visible = true;
            this.colNetHizmet.VisibleIndex = 4;
            this.colNetHizmet.Width = 100;
            // 
            // colBrutIndirim
            // 
            this.colBrutIndirim.AppearanceCell.Options.UseTextOptions = true;
            this.colBrutIndirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.colBrutIndirim.StatusBarAciklama = null;
            this.colBrutIndirim.StatusBarKisaYol = null;
            this.colBrutIndirim.StatusBarKisaYolAciklama = null;
            this.colBrutIndirim.Visible = true;
            this.colBrutIndirim.VisibleIndex = 5;
            this.colBrutIndirim.Width = 85;
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
            this.colKistDonemDusulenIndirim.StatusBarAciklama = null;
            this.colKistDonemDusulenIndirim.StatusBarKisaYol = null;
            this.colKistDonemDusulenIndirim.StatusBarKisaYolAciklama = null;
            this.colKistDonemDusulenIndirim.Visible = true;
            this.colKistDonemDusulenIndirim.VisibleIndex = 6;
            this.colKistDonemDusulenIndirim.Width = 85;
            // 
            // colNetIndirim
            // 
            this.colNetIndirim.AppearanceCell.Options.UseTextOptions = true;
            this.colNetIndirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.colNetIndirim.StatusBarAciklama = "Tarih seçiniz.";
            this.colNetIndirim.StatusBarKisaYol = "F4 : ";
            this.colNetIndirim.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colNetIndirim.Visible = true;
            this.colNetIndirim.VisibleIndex = 7;
            this.colNetIndirim.Width = 100;
            // 
            // colNetUcret
            // 
            this.colNetUcret.Caption = "Net Ücret";
            this.colNetUcret.ColumnEdit = this.repositoryItemDecimal;
            this.colNetUcret.FieldName = "NetUcret";
            this.colNetUcret.Name = "colNetUcret";
            this.colNetUcret.OptionsColumn.AllowEdit = false;
            this.colNetUcret.StatusBarAciklama = null;
            this.colNetUcret.StatusBarKisaYol = null;
            this.colNetUcret.StatusBarKisaYolAciklama = null;
            this.colNetUcret.Visible = true;
            this.colNetUcret.VisibleIndex = 8;
            // 
            // TahakkukBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.MinimumSize = new System.Drawing.Size(853, 300);
            this.Name = "TahakkukBilgileriTable";
            this.Size = new System.Drawing.Size(853, 300);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView view;
        private Grids.MyGridColumn colSubeAdi;
        private Grids.MyGridColumn colDonemAdi;
        private Grids.MyGridColumn colBrutHizmet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private Grids.MyGridColumn colKistDonemDusulenHizmet;
        private Grids.MyGridColumn colNetHizmet;
        private Grids.MyGridColumn colBrutIndirim;
        private Grids.MyGridColumn colKistDonemDusulenIndirim;
        private Grids.MyGridColumn colNetIndirim;
        private Grids.MyGridColumn colNetUcret;
    }
}
