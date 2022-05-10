﻿using OgrenciTakip.Bll.General;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Common.Functions;

namespace OgrenciTakip.UI.Win.Forms.OzelKodForms
{
    public partial class OzelKodListForm : BaseListForm
    {
        #region Variables

        private readonly OzelKodTuru _ozelKodTuru;
        private readonly KartTuru _ozelKodKartTuru;

        #endregion

        public OzelKodListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new OzelKodBll();

            _ozelKodTuru = (OzelKodTuru)prm[0];
            _ozelKodKartTuru = (KartTuru)prm[1];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.OzelKod;
            Navigator = longNavigator.Navigator;

            Text = $"{Text} - ( {_ozelKodTuru.ToName()} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OzelKodBll)Bll).List(x => x.KodTuru == _ozelKodTuru && x.KartTuru == _ozelKodKartTuru);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<OzelKodEditForm>.ShowDialogEditForm(KartTuru.OzelKod, id, _ozelKodTuru, _ozelKodKartTuru);
            ShowEditFormDefault(result);
        }
    }
}