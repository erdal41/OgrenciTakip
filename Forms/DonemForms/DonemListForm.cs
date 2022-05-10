using DevExpress.XtraBars;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;

namespace OgrenciTakip.UI.Win.Forms.DonemForms
{
    public partial class DonemListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<Donem, bool>> _filter;

        #endregion

        public DonemListForm()
        {
            InitializeComponent();
            Bll = new DonemBll();
            _filter = x => x.Durum == AktifKartlariGoster;
            ShowItems = new BarItem[] { btnParametreler, barParametreler, barParametrelerAciklama };
        }

        public DonemListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Donem;
            FormShow = new ShowEditForms<DonemEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((DonemBll)Bll).List(_filter);
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

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<Donem>();

            if (entity == null) return;

            ShowEditForms<DonemParametreEditForm>.ShowDialogEditForm(null, entity.Id);
        }
    }
}