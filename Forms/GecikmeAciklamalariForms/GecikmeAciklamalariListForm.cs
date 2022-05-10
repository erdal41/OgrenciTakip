using DevExpress.XtraBars;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    public partial class GecikmeAciklamalariListForm : BaseListForm
    {
        #region Variables

        private readonly int _odemeBilgileriId;

        #endregion

        public GecikmeAciklamalariListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new GecikmeAciklamalariBll();
            HideItems = new BarItem[] { btnSec, btnAktifPasifKartlar, barSec, barSecAciklama };

            _odemeBilgileriId = (int)prm[0];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.GecikmeAciklamalari;
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
            {
                ShowItems = new BarItem[] { btnBagliKartlar };
            }
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GecikmeAciklamalariBll)Bll).List(x => x.OdemeBilgileriId == _odemeBilgileriId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<GecikmeAciklamalariEditForm>.ShowDialogEditForm(KartTuru.GecikmeAciklamalari, id, _odemeBilgileriId);
            ShowEditFormDefault(result);
        }
    }
}