using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Data.Contexts;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.UI.Win.Forms.DonemForms;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Forms.RolForms;
using OgrenciTakip.UI.Win.Forms.SubeForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Security;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Yonetim.Forms.GenelForms
{
    public partial class AnaForm : RibbonForm
    {
        #region Variables

        private readonly string _server;

        //SecureString bir formdan başka forma taşınırken şifrelenip taşınır.
        private readonly SecureString _kullaniciAdi;
        private readonly SecureString _sifre;
        private readonly YetkilendirmeTuru _yetkilendirmeTuru;
        private readonly KurumBll _bll;

        #endregion

        public AnaForm(params object[] prm)
        {
            InitializeComponent();
            longNavigator.Navigator.NavigatableControl = view.GridControl;
            EventsLoad();
            ButtonEnabledDurumu();

            _server = prm[0].ToString();
            _kullaniciAdi = (SecureString)prm[1];
            _sifre = (SecureString)prm[2];
            _yetkilendirmeTuru = (YetkilendirmeTuru)prm[3];
            _bll = new KurumBll();
        }

        #region Functions

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }

            //Table Events
            view.DoubleClick += View_DoubleClick;
            view.KeyDown += View_KeyDown;
            view.MouseUp += View_MouseUp;
            view.RowCountChanged += View_RowCountChanged;

            //Form Events
            FormClosing += AnaForm_FormClosing;
            Load += AnaForm_Load;
        }

        protected internal void Listele()
        {
            view.GridControl.DataSource = _bll.List(null);
        }

        protected virtual void ShowEditForm(long id)
        {
            GeneralFunctions.CreateConnectionString("OgrenciTakipYonetim", _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);

            var result = ShowEditForms<KurumEditForm>.ShowDialogEditForm(id, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            if (result <= 0) return;
            Listele();

            //Yeni eklenen satıra focus
            view.RowFocus("Id", result);
        }

        private void ButtonEnabledDurumu()
        {
            foreach (BarItem button in ribbonControl.Items)
            {
                if (!(button is BarButtonItem item)) continue;
                if (item != btnYeni)
                {
                    item.Enabled = view.DataRowCount > 0;
                }
            }
        }

        private void EntityDelete(BaseEntity entity)
        {
            GeneralFunctions.CreateConnectionString(entity.Kod, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            if (!Functions.GeneralFunctions.DeleteDatabase<OgrenciTakipYonetimContext>()) return;

            GeneralFunctions.CreateConnectionString("OgrenciTakipYonetim", _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);
            _bll.Delete(entity);
            view.DeleteSelectedRows();
            view.RowFocus(view.FocusedRowHandle);
        }

        #endregion

        #region Events

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnYeni || e.Item == btnDüzelt)
            {
                if (e.Item == btnYeni)
                {
                    ShowEditForm(-1);
                }
                else if (e.Item == btnDüzelt)
                {
                    ShowEditForm(view.GetRowId());
                }
            }
            else
            {
                var entity = view.GetRow<Kurum>();
                if (entity == null) return;

                GeneralFunctions.CreateConnectionString(entity.Kod, _server, _kullaniciAdi, _sifre, _yetkilendirmeTuru);

                if (e.Item == btnSil)
                {
                    EntityDelete(entity);
                }
                else if (e.Item == btnEmailParametreleri)
                {
                    ShowEditForms<EmailParametreEditForm>.ShowDialogEditForm();
                }
                else if (e.Item == btnSubeKartlari)
                {
                    ShowListForms<SubeListForm>.ShowDialogListForm();
                }
                else if (e.Item == btnDonemKartlari)
                {
                    ShowListForms<DonemListForm>.ShowDialogListForm();
                }
                else if (e.Item == btnKurumBilgileri)
                {
                    ShowEditForms<KurumBilgileriEditForm>.ShowDialogEditForm(null, entity.Kod, entity.KurumAdi);
                }
                else if (e.Item == btnRolKartlari)
                {
                    ShowListForms<RolListForm>.ShowDialogListForm();
                }
                else if (e.Item == btnKullaniciKartlari)
                {
                    ShowListForms<KullaniciListForm>.ShowDialogListForm();

                }
                else if (e.Item == btnKullaniciBirimYetkileri)
                {
                    ShowEditForms<KullaniciBirimYetkileriEditForm>.ShowDialogEditForm();
                }
            }

            Cursor.Current = DefaultCursor;
        }

        private void View_DoubleClick(object sender, EventArgs e)
        {
            if (view.FocusedRowHandle < 0) return;
            ShowEditForm(view.GetRowId());
        }

        private void View_KeyDown(object sender, KeyEventArgs e)
        {
            //tabloya focuslanılan satır sayısı 0 dan küçükse aşağıdakiler çalışmaz.
            if (view.FocusedRowHandle < 0) return;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowEditForm(view.GetRowId());
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void View_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void View_RowCountChanged(object sender, EventArgs e)
        {
            ButtonEnabledDurumu();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan çıkmak istiyor musunuz?", "Çıkış Onayı") == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Listele();
            view.Focus();
            Cursor.Current = Cursors.Default;
        }

        #endregion
    }
}