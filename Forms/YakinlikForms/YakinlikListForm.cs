using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.YakinlikForms
{
    public partial class YakinlikListForm : BaseListForm
    {
        public YakinlikListForm()
        {
            InitializeComponent();

            Bll = new YakinlikBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Yakinlik;
            FormShow = new ShowEditForms<YakinlikEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YakinlikBll)Bll).List(FilterFunctions.Filter<Yakinlik>(AktifKartlariGoster));
        }
    }
}