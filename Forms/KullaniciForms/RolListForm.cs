using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.RolForms
{
    public partial class RolListForm : BaseListForm
    {
        public RolListForm()
        {
            InitializeComponent();
            Bll = new RolBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;

            //filtreleme için kullandık
            BaseKartTuru = KartTuru.Rol;
            FormShow = new ShowEditForms<RolEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RolBll)Bll).List(FilterFunctions.Filter<Rol>(AktifKartlariGoster));
        }
    }
}