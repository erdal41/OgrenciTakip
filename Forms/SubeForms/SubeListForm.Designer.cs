
namespace OgrenciTakip.UI.Win.Forms.SubeForms
{
    partial class SubeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubeListForm));
            this.ustPanel = new DevExpress.XtraEditors.PanelControl();
            this.txtHizmetBaslamaTarihi = new OgrenciTakip.UI.Win.UserControls.Controls.MyDateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKod = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSubeAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colGrupAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAdres = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTelefon = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colFax = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIbanNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSiraNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustPanel)).BeginInit();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1055, 109);
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
            // btnYeniMakbuz
            // 
            this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // btnYeniRapor
            // 
            this.btnYeniRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.Image")));
            this.btnYeniRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.LargeImage")));
            // 
            // barSubItem2
            // 
            this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
            // 
            // btnOnTanimliRaporlar
            // 
            this.btnOnTanimliRaporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnTanimliRaporlar.ImageOptions.Image")));
            // 
            // ustPanel
            // 
            this.ustPanel.Controls.Add(this.txtHizmetBaslamaTarihi);
            this.ustPanel.Controls.Add(this.labelControl1);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 109);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(1055, 32);
            this.ustPanel.TabIndex = 2;
            this.ustPanel.Visible = false;
            // 
            // txtHizmetBaslamaTarihi
            // 
            this.txtHizmetBaslamaTarihi.EditValue = null;
            this.txtHizmetBaslamaTarihi.EnterMoveNextControl = true;
            this.txtHizmetBaslamaTarihi.Location = new System.Drawing.Point(131, 6);
            this.txtHizmetBaslamaTarihi.MenuManager = this.ribbonControl;
            this.txtHizmetBaslamaTarihi.Name = "txtHizmetBaslamaTarihi";
            this.txtHizmetBaslamaTarihi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtHizmetBaslamaTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHizmetBaslamaTarihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHizmetBaslamaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHizmetBaslamaTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtHizmetBaslamaTarihi.Size = new System.Drawing.Size(136, 20);
            this.txtHizmetBaslamaTarihi.StatusBarAciklama = null;
            this.txtHizmetBaslamaTarihi.StatusBarKisaYol = "F4 :";
            this.txtHizmetBaslamaTarihi.StatusBarKisaYolAciklama = "Tarih Seç";
            this.txtHizmetBaslamaTarihi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hizmet Başlama Tarihi : ";
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 417);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1055, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 141);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1055, 276);
            this.grid.TabIndex = 4;
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
            this.colKod,
            this.colSubeAdi,
            this.colGrupAdi,
            this.colSiraNo,
            this.colTelefon,
            this.colFax,
            this.colIbanNo,
            this.colAdres});
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
            this.view.ViewCaption = "ŞUBE KARTLARI";
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
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 125;
            // 
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.StatusBarAciklama = null;
            this.colSubeAdi.StatusBarKisaYol = null;
            this.colSubeAdi.StatusBarKisaYolAciklama = null;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 1;
            this.colSubeAdi.Width = 120;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.Caption = "Grup Adı";
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.StatusBarAciklama = null;
            this.colGrupAdi.StatusBarKisaYol = null;
            this.colGrupAdi.StatusBarKisaYolAciklama = null;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 2;
            this.colGrupAdi.Width = 120;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.StatusBarAciklama = null;
            this.colAdres.StatusBarKisaYol = null;
            this.colAdres.StatusBarKisaYolAciklama = null;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 7;
            this.colAdres.Width = 247;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.StatusBarAciklama = null;
            this.colTelefon.StatusBarKisaYol = null;
            this.colTelefon.StatusBarKisaYolAciklama = null;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 4;
            this.colTelefon.Width = 100;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.StatusBarAciklama = null;
            this.colFax.StatusBarKisaYol = null;
            this.colFax.StatusBarKisaYolAciklama = null;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 5;
            this.colFax.Width = 100;
            // 
            // colIbanNo
            // 
            this.colIbanNo.Caption = "İban No";
            this.colIbanNo.FieldName = "IbanNo";
            this.colIbanNo.Name = "colIbanNo";
            this.colIbanNo.OptionsColumn.AllowEdit = false;
            this.colIbanNo.StatusBarAciklama = null;
            this.colIbanNo.StatusBarKisaYol = null;
            this.colIbanNo.StatusBarKisaYolAciklama = null;
            this.colIbanNo.Visible = true;
            this.colIbanNo.VisibleIndex = 6;
            this.colIbanNo.Width = 170;
            // 
            // colSiraNo
            // 
            this.colSiraNo.Caption = "Sıra No";
            this.colSiraNo.FieldName = "SiraNo";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.OptionsColumn.AllowEdit = false;
            this.colSiraNo.StatusBarAciklama = null;
            this.colSiraNo.StatusBarKisaYol = null;
            this.colSiraNo.StatusBarKisaYolAciklama = null;
            this.colSiraNo.Visible = true;
            this.colSiraNo.VisibleIndex = 3;
            // 
            // SubeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 465);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Controls.Add(this.ustPanel);
            this.IconOptions.ShowIcon = false;
            this.Name = "SubeListForm";
            this.Text = "Şube Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.ustPanel, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustPanel)).EndInit();
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetBaslamaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl ustPanel;
        private UserControls.Controls.MyDateEdit txtHizmetBaslamaTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView view;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colKod;
        private UserControls.Grids.MyGridColumn colSubeAdi;
        private UserControls.Grids.MyGridColumn colGrupAdi;
        private UserControls.Grids.MyGridColumn colSiraNo;
        private UserControls.Grids.MyGridColumn colTelefon;
        private UserControls.Grids.MyGridColumn colFax;
        private UserControls.Grids.MyGridColumn colIbanNo;
        private UserControls.Grids.MyGridColumn colAdres;
    }
}