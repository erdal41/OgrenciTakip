using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.TesvikForms
{
    public partial class TesvikListForm : BaseListForm
    {
        public TesvikListForm()
        {
            InitializeComponent();

            Bll = new TesvikBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Tesvik;
            FormShow = new ShowEditForms<TesvikEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TesvikBll)Bll).List(FilterFunctions.Filter<Tesvik>(AktifKartlariGoster));
        }
    }
}