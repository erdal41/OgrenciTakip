using DevExpress.XtraBars;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciListForm : BaseListForm
    {
        public KullaniciListForm()
        {
            InitializeComponent();
            Bll = new KullaniciBll();
            HideItems = new BarItem[] { btnSec };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;

            //filtreleme için kullandık
            BaseKartTuru = KartTuru.Kullanici;
            FormShow = new ShowEditForms<KullaniciEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KullaniciBll)Bll).List(FilterFunctions.Filter<Kullanici>(AktifKartlariGoster));
        }
    }
}