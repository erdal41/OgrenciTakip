using DevExpress.XtraBars;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.AvukatForms
{
    public partial class AvukatListForm : BaseListForm
    {
        public AvukatListForm()
        {
            InitializeComponent();

            Bll = new AvukatBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Avukat;
            FormShow = new ShowEditForms<AvukatEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AvukatBll)Bll).List(FilterFunctions.Filter<Avukat>(AktifKartlariGoster));
        }
    }
}