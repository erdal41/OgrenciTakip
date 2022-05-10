using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
    public partial class OdemeTuruListForm : BaseListForm
    {
        public OdemeTuruListForm()
        {
            InitializeComponent();

            Bll = new OdemeTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.OdemeTuru;
            FormShow = new ShowEditForms<OdemeTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OdemeTuruBll)Bll).List(FilterFunctions.Filter<OdemeTuru>(AktifKartlariGoster));
        }
    }
}