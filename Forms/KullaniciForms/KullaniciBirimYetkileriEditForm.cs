using DevExpress.XtraBars;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciBirimYetkileriEditForm : BaseEditForm
    {
        public KullaniciBirimYetkileriEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            EventsLoad();
            HideItems = new BarItem[] { btnYeni, btnSil, btnKaydet, btnGerial };
            TabloYukle();
        }

        public override void Yukle()
        {
            subeTable.Yukle();
            donemTable.Yukle();
        }

        //ButtonEnabledDurumu() devre dışı
        protected internal override void ButtonEnabledDurumu() { }

        protected override void TabloYukle()
        {
            kullaniciTable.OwnerForm = this;
            subeTable.OwnerForm = this;
            donemTable.OwnerForm = this;
            kullaniciTable.Yukle();
        }

        #region Events

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            kullaniciTable.Tablo.Focus();
        } 

        #endregion
    }
}