using DevExpress.XtraBars;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System.Linq;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.MakbuzForms
{
    public partial class BelgeHareketleriListForm : BaseListForm
    {
        #region Variables

        private readonly int _odemeBilgileriId;

        #endregion

        public BelgeHareketleriListForm(params object[] prm)
        {
            InitializeComponent();
            HideItems = new BarItem[] { btnYeni, btnSil, btnSec, barYeniAciklama, barYeniAciklama, barSil, barSilAciklama, barSec, barSecAciklama };
            ShowItems = new BarItem[] { btnYeni, };
            _odemeBilgileriId = (int)prm[0];
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.BelgeHareketleri;
            Navigator = longNavigator.Navigator;
            Navigator.TextStringFormat = "Belge Hareketleri ({0} / {1})";
        }

        protected override void Listele()
        {
            using (var bll = new BelgeHareketleriBll())
            {
                var list = bll.List(x => x.OdemeBilgileriId == _odemeBilgileriId).Cast<BelgeHareketleriList>().ToList();

                if (!list.Any())
                {
                    Messages.UyariMesaji("Seçmiş olduğunuz ödeme belgesine ait hareket bulunmamaktadır.");
                    Close();
                    return;
                }

                var entity = list[0];
                txtOgrenciNo.Text = entity.OgrenciNo;
                txtAdi.Text = entity.Adi;
                txtSoyadi.Text = entity.Soyadi;
                txtSinif.Text = entity.SinifAdi;
                txtSube.Text = entity.OgrenciSubeAdi;
                txtPortfoyNo.EditValue = entity.OdemeBilgileriId;
                txtOdemeTuru.Text = entity.OdemeTuruAdi;
                txtGirisTarihi.DateTime = entity.GirisTarihi;
                txtVade.DateTime = entity.Vade;
                txtHesabaGecisTarihi.DateTime = entity.HesabaGecisTarihi;
                txtTutar.Value = entity.Tutar;
                txtAsilBorclu.Text = entity.AsilBorclu;
                txtCiranta.Text = entity.Ciranta;
                txtBanka.Text = entity.BankaAdi;
                txtBankaSube.Text = entity.BankaSubeAdi;
                txtHesapNo.Text = entity.HesapNo;
                txtBelgeNo.Text = entity.BelgeNo;

                grid.DataSource = list;
            }
        }

        protected override void ShowEditForm(long id)
        {
            var entity = view.GetRow<BelgeHareketleriList>();
            if (entity == null) return;

            if (entity.SubeId != AnaForm.SubeId)
            {
                ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.MakbuzHesapTuru, true);
            }
            else
            {
                var result = ShowEditForms<MakbuzEditForm>.ShowDialogEditForm(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.MakbuzHesapTuru);
                ShowEditFormDefault(result);
            }
        }
    }
}