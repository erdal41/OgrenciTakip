
namespace OgrenciTakip.UI.Win.Forms.TahakkukForms
{
    partial class TahakkukListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahakkukListForm));
            this.longNavigator = new OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.view = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridView();
            this.colTcKimlikNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSoyadi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colBabaAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colAnaAdi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOgrenciNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOkulNo = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKayitTarihi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKayitSekli = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSinif = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colGeldigiOkul = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colYabanciDil = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKontenjan = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colTesvik = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colRehber = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSube = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSonrakiDonemKayitDurumu = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colSonrakiDonemKayitDurumuAciklamasi = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod1 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod2 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod3 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod4 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colOzelKod5 = new OgrenciTakip.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bndSecim = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
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
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 372);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(898, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.view;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(898, 263);
            this.grid.TabIndex = 3;
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
            this.view.BandPanelRowHeight = 40;
            this.view.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bndSecim,
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.view.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colOgrenciNo,
            this.colOkulNo,
            this.colTcKimlikNo,
            this.colAdi,
            this.colSoyadi,
            this.colBabaAdi,
            this.colAnaAdi,
            this.colKayitTarihi,
            this.colKayitSekli,
            this.colKayitDurumu,
            this.colSinif,
            this.colYabanciDil,
            this.colGeldigiOkul,
            this.colKontenjan,
            this.colTesvik,
            this.colRehber,
            this.colSonrakiDonemKayitDurumu,
            this.colSonrakiDonemKayitDurumuAciklamasi,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colOzelKod5,
            this.colSube});
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
            this.view.OptionsView.ShowAutoFilterRow = true;
            this.view.OptionsView.ShowGroupPanel = false;
            this.view.OptionsView.ShowViewCaption = true;
            this.view.StatusBarAciklama = null;
            this.view.StatusBarKisaYol = null;
            this.view.StatusBarKisaYolAciklama = null;
            this.view.ViewCaption = "TAHAKKUK KARTLARI";
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTcKimlikNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTcKimlikNo.Caption = "T.C. Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.Width = 100;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.StatusBarAciklama = null;
            this.colAdi.StatusBarKisaYol = null;
            this.colAdi.StatusBarKisaYolAciklama = null;
            this.colAdi.Visible = true;
            this.colAdi.Width = 100;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.OptionsColumn.AllowEdit = false;
            this.colSoyadi.StatusBarAciklama = null;
            this.colSoyadi.StatusBarKisaYol = null;
            this.colSoyadi.StatusBarKisaYolAciklama = null;
            this.colSoyadi.Visible = true;
            this.colSoyadi.Width = 100;
            // 
            // colBabaAdi
            // 
            this.colBabaAdi.Caption = "Baba Adı";
            this.colBabaAdi.FieldName = "BabaAdi";
            this.colBabaAdi.Name = "colBabaAdi";
            this.colBabaAdi.OptionsColumn.AllowEdit = false;
            this.colBabaAdi.StatusBarAciklama = null;
            this.colBabaAdi.StatusBarKisaYol = null;
            this.colBabaAdi.StatusBarKisaYolAciklama = null;
            this.colBabaAdi.Visible = true;
            this.colBabaAdi.Width = 100;
            // 
            // colAnaAdi
            // 
            this.colAnaAdi.Caption = "Ana Adı";
            this.colAnaAdi.FieldName = "AnaAdi";
            this.colAnaAdi.Name = "colAnaAdi";
            this.colAnaAdi.OptionsColumn.AllowEdit = false;
            this.colAnaAdi.StatusBarAciklama = null;
            this.colAnaAdi.StatusBarKisaYol = null;
            this.colAnaAdi.StatusBarKisaYolAciklama = null;
            this.colAnaAdi.Visible = true;
            this.colAnaAdi.Width = 100;
            // 
            // colOgrenciNo
            // 
            this.colOgrenciNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOgrenciNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOgrenciNo.Caption = "Öğrenci No";
            this.colOgrenciNo.FieldName = "Kod";
            this.colOgrenciNo.Name = "colOgrenciNo";
            this.colOgrenciNo.OptionsColumn.AllowEdit = false;
            this.colOgrenciNo.Visible = true;
            this.colOgrenciNo.Width = 100;
            // 
            // colOkulNo
            // 
            this.colOkulNo.AppearanceCell.Options.UseTextOptions = true;
            this.colOkulNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.OptionsColumn.AllowEdit = false;
            this.colOkulNo.StatusBarAciklama = null;
            this.colOkulNo.StatusBarKisaYol = null;
            this.colOkulNo.StatusBarKisaYolAciklama = null;
            this.colOkulNo.Visible = true;
            this.colOkulNo.Width = 100;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colKayitTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.StatusBarAciklama = null;
            this.colKayitTarihi.StatusBarKisaYol = null;
            this.colKayitTarihi.StatusBarKisaYolAciklama = null;
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.Width = 100;
            // 
            // colKayitSekli
            // 
            this.colKayitSekli.Caption = "Kayıt Şekli";
            this.colKayitSekli.FieldName = "KayitSekli";
            this.colKayitSekli.Name = "colKayitSekli";
            this.colKayitSekli.OptionsColumn.AllowEdit = false;
            this.colKayitSekli.StatusBarAciklama = null;
            this.colKayitSekli.StatusBarKisaYol = null;
            this.colKayitSekli.StatusBarKisaYolAciklama = null;
            this.colKayitSekli.Visible = true;
            this.colKayitSekli.Width = 110;
            // 
            // colKayitDurumu
            // 
            this.colKayitDurumu.Caption = "Kayıt Durumu";
            this.colKayitDurumu.FieldName = "KayitDurumu";
            this.colKayitDurumu.Name = "colKayitDurumu";
            this.colKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colKayitDurumu.StatusBarAciklama = null;
            this.colKayitDurumu.StatusBarKisaYol = null;
            this.colKayitDurumu.StatusBarKisaYolAciklama = null;
            this.colKayitDurumu.Visible = true;
            this.colKayitDurumu.Width = 110;
            // 
            // colSinif
            // 
            this.colSinif.Caption = "Sınıf";
            this.colSinif.FieldName = "SinifAdi";
            this.colSinif.Name = "colSinif";
            this.colSinif.OptionsColumn.AllowEdit = false;
            this.colSinif.StatusBarAciklama = null;
            this.colSinif.StatusBarKisaYol = null;
            this.colSinif.StatusBarKisaYolAciklama = null;
            this.colSinif.Visible = true;
            this.colSinif.Width = 100;
            // 
            // colGeldigiOkul
            // 
            this.colGeldigiOkul.Caption = "Geldiği Okul";
            this.colGeldigiOkul.FieldName = "GeldigiOkulAdi";
            this.colGeldigiOkul.Name = "colGeldigiOkul";
            this.colGeldigiOkul.OptionsColumn.AllowEdit = false;
            this.colGeldigiOkul.StatusBarAciklama = null;
            this.colGeldigiOkul.StatusBarKisaYol = null;
            this.colGeldigiOkul.StatusBarKisaYolAciklama = null;
            this.colGeldigiOkul.Visible = true;
            this.colGeldigiOkul.Width = 120;
            // 
            // colYabanciDil
            // 
            this.colYabanciDil.Caption = "Yabancı Dil";
            this.colYabanciDil.FieldName = "YabanciDilAdi";
            this.colYabanciDil.Name = "colYabanciDil";
            this.colYabanciDil.OptionsColumn.AllowEdit = false;
            this.colYabanciDil.StatusBarAciklama = null;
            this.colYabanciDil.StatusBarKisaYol = null;
            this.colYabanciDil.StatusBarKisaYolAciklama = null;
            this.colYabanciDil.Visible = true;
            this.colYabanciDil.Width = 100;
            // 
            // colKontenjan
            // 
            this.colKontenjan.Caption = "Kontenjan Türü";
            this.colKontenjan.FieldName = "KontenjanAdi";
            this.colKontenjan.Name = "colKontenjan";
            this.colKontenjan.OptionsColumn.AllowEdit = false;
            this.colKontenjan.StatusBarAciklama = null;
            this.colKontenjan.StatusBarKisaYol = null;
            this.colKontenjan.StatusBarKisaYolAciklama = null;
            this.colKontenjan.Visible = true;
            this.colKontenjan.Width = 120;
            // 
            // colTesvik
            // 
            this.colTesvik.Caption = "Teşvik Türü";
            this.colTesvik.FieldName = "TesvikAdi";
            this.colTesvik.Name = "colTesvik";
            this.colTesvik.OptionsColumn.AllowEdit = false;
            this.colTesvik.StatusBarAciklama = null;
            this.colTesvik.StatusBarKisaYol = null;
            this.colTesvik.StatusBarKisaYolAciklama = null;
            this.colTesvik.Visible = true;
            this.colTesvik.Width = 120;
            // 
            // colRehber
            // 
            this.colRehber.Caption = "Rehber Öğretmeni";
            this.colRehber.FieldName = "RehberAdi";
            this.colRehber.Name = "colRehber";
            this.colRehber.OptionsColumn.AllowEdit = false;
            this.colRehber.StatusBarAciklama = null;
            this.colRehber.StatusBarKisaYol = null;
            this.colRehber.StatusBarKisaYolAciklama = null;
            this.colRehber.Visible = true;
            this.colRehber.Width = 100;
            // 
            // colSube
            // 
            this.colSube.Caption = "Şube Adı";
            this.colSube.FieldName = "SubeAdi";
            this.colSube.Name = "colSube";
            this.colSube.OptionsColumn.AllowEdit = false;
            this.colSube.StatusBarAciklama = null;
            this.colSube.StatusBarKisaYol = null;
            this.colSube.StatusBarKisaYolAciklama = null;
            this.colSube.Visible = true;
            this.colSube.Width = 150;
            // 
            // colSonrakiDonemKayitDurumu
            // 
            this.colSonrakiDonemKayitDurumu.Caption = "Kayıt Durumu";
            this.colSonrakiDonemKayitDurumu.CustomizationCaption = "Sonraki Dönem Kayıt Durumu";
            this.colSonrakiDonemKayitDurumu.FieldName = "SonrakiDonemKayitDurumu";
            this.colSonrakiDonemKayitDurumu.Name = "colSonrakiDonemKayitDurumu";
            this.colSonrakiDonemKayitDurumu.OptionsColumn.AllowEdit = false;
            this.colSonrakiDonemKayitDurumu.StatusBarAciklama = null;
            this.colSonrakiDonemKayitDurumu.StatusBarKisaYol = null;
            this.colSonrakiDonemKayitDurumu.StatusBarKisaYolAciklama = null;
            this.colSonrakiDonemKayitDurumu.Visible = true;
            this.colSonrakiDonemKayitDurumu.Width = 150;
            // 
            // colSonrakiDonemKayitDurumuAciklamasi
            // 
            this.colSonrakiDonemKayitDurumuAciklamasi.Caption = "Açıklama";
            this.colSonrakiDonemKayitDurumuAciklamasi.CustomizationCaption = "Sonraki Dönem Kayıt Durumu Açıklaması";
            this.colSonrakiDonemKayitDurumuAciklamasi.FieldName = "SonrakiDonemKayitDurumuAciklamasi";
            this.colSonrakiDonemKayitDurumuAciklamasi.Name = "colSonrakiDonemKayitDurumuAciklamasi";
            this.colSonrakiDonemKayitDurumuAciklamasi.OptionsColumn.AllowEdit = false;
            this.colSonrakiDonemKayitDurumuAciklamasi.StatusBarAciklama = null;
            this.colSonrakiDonemKayitDurumuAciklamasi.StatusBarKisaYol = null;
            this.colSonrakiDonemKayitDurumuAciklamasi.StatusBarKisaYolAciklama = null;
            this.colSonrakiDonemKayitDurumuAciklamasi.Visible = true;
            this.colSonrakiDonemKayitDurumuAciklamasi.Width = 250;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1Adi";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            this.colOzelKod1.StatusBarAciklama = null;
            this.colOzelKod1.StatusBarKisaYol = null;
            this.colOzelKod1.StatusBarKisaYolAciklama = null;
            this.colOzelKod1.Visible = true;
            this.colOzelKod1.Width = 120;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2Adi";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            this.colOzelKod2.StatusBarAciklama = null;
            this.colOzelKod2.StatusBarKisaYol = null;
            this.colOzelKod2.StatusBarKisaYolAciklama = null;
            this.colOzelKod2.Visible = true;
            this.colOzelKod2.Width = 120;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod-3";
            this.colOzelKod3.FieldName = "OzelKod3Adi";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            this.colOzelKod3.StatusBarAciklama = null;
            this.colOzelKod3.StatusBarKisaYol = null;
            this.colOzelKod3.StatusBarKisaYolAciklama = null;
            this.colOzelKod3.Visible = true;
            this.colOzelKod3.Width = 120;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod-4";
            this.colOzelKod4.FieldName = "OzelKod4Adi";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            this.colOzelKod4.StatusBarAciklama = null;
            this.colOzelKod4.StatusBarKisaYol = null;
            this.colOzelKod4.StatusBarKisaYolAciklama = null;
            this.colOzelKod4.Visible = true;
            this.colOzelKod4.Width = 120;
            // 
            // colOzelKod5
            // 
            this.colOzelKod5.Caption = "Özel Kod-5";
            this.colOzelKod5.FieldName = "OzelKod5Adi";
            this.colOzelKod5.Name = "colOzelKod5";
            this.colOzelKod5.OptionsColumn.AllowEdit = false;
            this.colOzelKod5.StatusBarAciklama = null;
            this.colOzelKod5.StatusBarKisaYol = null;
            this.colOzelKod5.StatusBarKisaYolAciklama = null;
            this.colOzelKod5.Visible = true;
            this.colOzelKod5.Width = 120;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // bndSecim
            // 
            this.bndSecim.Caption = "Seç";
            this.bndSecim.Name = "bndSecim";
            this.bndSecim.Visible = false;
            this.bndSecim.VisibleIndex = -1;
            this.bndSecim.Width = 43;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Öğrenci Bilgileri";
            this.gridBand1.Columns.Add(this.colTcKimlikNo);
            this.gridBand1.Columns.Add(this.colAdi);
            this.gridBand1.Columns.Add(this.colSoyadi);
            this.gridBand1.Columns.Add(this.colBabaAdi);
            this.gridBand1.Columns.Add(this.colAnaAdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 500;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Tahakkuk Bilgileri";
            this.gridBand2.Columns.Add(this.colOgrenciNo);
            this.gridBand2.Columns.Add(this.colOkulNo);
            this.gridBand2.Columns.Add(this.colKayitTarihi);
            this.gridBand2.Columns.Add(this.colKayitSekli);
            this.gridBand2.Columns.Add(this.colKayitDurumu);
            this.gridBand2.Columns.Add(this.colSinif);
            this.gridBand2.Columns.Add(this.colGeldigiOkul);
            this.gridBand2.Columns.Add(this.colYabanciDil);
            this.gridBand2.Columns.Add(this.colKontenjan);
            this.gridBand2.Columns.Add(this.colTesvik);
            this.gridBand2.Columns.Add(this.colRehber);
            this.gridBand2.Columns.Add(this.colSube);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1330;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Sonraki Dönem";
            this.gridBand3.Columns.Add(this.colSonrakiDonemKayitDurumu);
            this.gridBand3.Columns.Add(this.colSonrakiDonemKayitDurumuAciklamasi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 400;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Özel Kod";
            this.gridBand4.Columns.Add(this.colOzelKod1);
            this.gridBand4.Columns.Add(this.colOzelKod2);
            this.gridBand4.Columns.Add(this.colOzelKod3);
            this.gridBand4.Columns.Add(this.colOzelKod4);
            this.gridBand4.Columns.Add(this.colOzelKod5);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 600;
            // 
            // TahakkukListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 420);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "TahakkukListForm";
            this.Text = "Tahakkuk Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView view;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOgrenciNo;
        private UserControls.Grids.MyBandedGridColumn colOkulNo;
        private UserControls.Grids.MyBandedGridColumn colTcKimlikNo;
        private UserControls.Grids.MyBandedGridColumn colAdi;
        private UserControls.Grids.MyBandedGridColumn colSoyadi;
        private UserControls.Grids.MyBandedGridColumn colBabaAdi;
        private UserControls.Grids.MyBandedGridColumn colAnaAdi;
        private UserControls.Grids.MyBandedGridColumn colKayitTarihi;
        private UserControls.Grids.MyBandedGridColumn colKayitSekli;
        private UserControls.Grids.MyBandedGridColumn colKayitDurumu;
        private UserControls.Grids.MyBandedGridColumn colSinif;
        private UserControls.Grids.MyBandedGridColumn colGeldigiOkul;
        private UserControls.Grids.MyBandedGridColumn colKontenjan;
        private UserControls.Grids.MyBandedGridColumn colYabanciDil;
        private UserControls.Grids.MyBandedGridColumn colTesvik;
        private UserControls.Grids.MyBandedGridColumn colRehber;
        private UserControls.Grids.MyBandedGridColumn colSonrakiDonemKayitDurumu;
        private UserControls.Grids.MyBandedGridColumn colSonrakiDonemKayitDurumuAciklamasi;
        private UserControls.Grids.MyBandedGridColumn colOzelKod1;
        private UserControls.Grids.MyBandedGridColumn colOzelKod2;
        private UserControls.Grids.MyBandedGridColumn colOzelKod3;
        private UserControls.Grids.MyBandedGridColumn colOzelKod4;
        private UserControls.Grids.MyBandedGridColumn colOzelKod5;
        private UserControls.Grids.MyBandedGridColumn colSube;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bndSecim;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}