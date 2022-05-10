using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.KullaniciBirimYetkileriEditFormTable
{
    public partial class KullaniciTable : BaseTablo
    {
        public KullaniciTable()
        {
            InitializeComponent();
            Bll = new KullaniciBll();
            Tablo = view;
            EventsLoad();

            HideItems = new BarItem[] { btnHareketEkle, btnHareketSil };
            insUpNavigator.Navigator.Buttons.Append.Visible = false;
            insUpNavigator.Navigator.Buttons.Remove.Visible = false;
            insUpNavigator.Navigator.Buttons.PrevPage.Visible = true;
            insUpNavigator.Navigator.Buttons.NextPage.Visible = true;
        }

        #region Functions

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((KullaniciBll)Bll).List(null);
        }

        //Basetabloda kısayol ataması yaptığımız için ve bu tabloda ise bu fonksiyon kullanılmayacağı için kısayol tuşlarını devredışı bırakmamız gerektiğinden dolayı bu fonksiyonu çağırıp boş bıraktık ki HarektSil()'in kısayol tuşu çalışmasın.
        protected override void HareketSil() { }

        #endregion

        #region Events

        protected override void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            var entity = view.GetRow<KullaniciList>();
            if (entity == null) return;

            OwnerForm.Id = entity.Id;
            ((KullaniciBirimYetkileriEditForm)OwnerForm).Yukle();
        }

        #endregion
    }
}