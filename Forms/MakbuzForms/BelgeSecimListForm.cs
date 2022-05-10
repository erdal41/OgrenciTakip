using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GenelForms;
using System;
using System.Linq;
using System.Linq.Expressions;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class BelgeSecimListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<OdemeBilgileri, bool>> _filter;
        private readonly MakbuzTuru _makbuzTuru;
        private readonly MakbuzHesapTuru _makbuzHesapTuru;
        private readonly long _hesapId;

        #endregion

        public BelgeSecimListForm(params object[] prm)
        {
            InitializeComponent();
            _makbuzTuru = (MakbuzTuru)prm[0];
            _makbuzHesapTuru = (MakbuzHesapTuru)prm[1];
            _hesapId = prm[2] != null ? (long)prm[2] : 0;
            HideItems = new BarItem[] { btnYeni, btnSil, btnDuzelt, barYeni, barYeniAciklama, barSil, barSilAciklama, barDuzenle, barDuzenleAciklama };
            ShowItems = new BarItem[] { btnBelgeHareketleri };

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Tahakkuk.DonemId == AnaForm.DonemId;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Hizmet;
            Navigator = longNavigator.Navigator;
            Text = $"{Text} - {_makbuzTuru.ToName()} - ( {_makbuzHesapTuru.ToName()} )";
        }

        protected override void Listele()
        {
            using (var bll = new BelgeSecimBll())
            {
                var list = bll.List(_filter, _makbuzTuru, _makbuzHesapTuru, _makbuzHesapTuru.ToName().GetEnum<OdemeTipi>(), _hesapId, AnaForm.SubeId);
                Tablo.GridControl.DataSource = list;

                if (!MultiSelect) return;
                if (list.Any())  //list te değer veya kayıt var ise
                {
                    EklenebilecekEntityVar = true;
                }
                else
                {
                    Messages.KartBulunamadiMesaji("Belge");
                }
            }
        }

        protected override void SutunGizleGoster()
        {
            if (view.DataRowCount == 0) return;
            var entity = view.GetRow<BelgeSecimList>(false);
            if (entity == null) return;

            bndBelgeDetayBilgileri.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colTakipNo.Visible = entity.OdemeTipi == OdemeTipi.Pos;
            colBankaHesapAdi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Pos || entity.OdemeTipi == OdemeTipi.Ots;
            colBankaAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBankaSubeAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colHesapNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBelgeNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colAsilBorclu.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colCiranta.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
        }

        protected override void BelgeHareketleri()
        {
            var entity = view.GetRow<BelgeSecimList>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.OdemeBilgileriId);
        }
    }
}