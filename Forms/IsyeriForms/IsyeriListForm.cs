using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.IsyeriForms
{
    public partial class IsyeriListForm : BaseListForm
    {
        public IsyeriListForm()
        {
            InitializeComponent();

            Bll = new IsyeriBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Isyeri;
            FormShow = new ShowEditForms<IsyeriEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IsyeriBll)Bll).List(FilterFunctions.Filter<Isyeri>(AktifKartlariGoster));
        }
    }
}