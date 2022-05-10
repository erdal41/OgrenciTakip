using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using System;

namespace OgrenciTakip.UI.Win.Forms.CariForms
{
    public partial class CariListForm : BaseListForm
    {
        public CariListForm()
        {
            InitializeComponent();
            Bll = new CariBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Cari;
            FormShow = new ShowEditForms<CariEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CariBll)Bll).List(FilterFunctions.Filter<Cari>(AktifKartlariGoster));
        }
    }
}