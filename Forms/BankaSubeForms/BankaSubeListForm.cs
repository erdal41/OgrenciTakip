using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.BankaSubeForms
{
    public partial class BankaSubeListForm : BaseListForm
    {
        #region Variables

        private readonly long _bankaId;
        private readonly string _bankaAdi; 

        #endregion

        //params ile ilId ve ilAdini çekeceğiz.
        public BankaSubeListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new BankaSubeBll();

            _bankaId = (long)prm[0];
            _bankaAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.BankaSube;
            Navigator = longNavigator.Navigator;
            Text += $" - ( {_bankaAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaSubeBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.BankaId == _bankaId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<BankaSubeEditForm>.ShowDialogEditForm(KartTuru.BankaSube, id, _bankaId, _bankaAdi);
            ShowEditFormDefault(result);
        }
    }
}