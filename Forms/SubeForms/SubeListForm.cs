using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.UI.Win.Forms.SubeForms
{
    public partial class SubeListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<Sube, bool>> _filter;

        #endregion

        public SubeListForm()
        {
            InitializeComponent();
            Bll = new SubeBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public SubeListForm(params object[] prm) : this()
        {

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Sube;
            FormShow = new ShowEditForms<SubeEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((SubeBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())  //list te değer veya kayıt var ise
            {
                EklenebilecekEntityVar = true;
            }
            else
            {
                Messages.KartBulunamadiMesaji("Kart");
            }
        }
    }
}