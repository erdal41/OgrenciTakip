using DevExpress.XtraBars;
using OgrenciTakip.Bll.General;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.UI.Win.GenelForms;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class TahakkukBilgileriTable : BaseTablo
    {
        public TahakkukBilgileriTable()
        {
            InitializeComponent();
            Bll = new TahakkukBll();
            Tablo = view;
            EventsLoad();

            insUpNavigator.Navigator.Buttons.Append.Visible = false;
            insUpNavigator.Navigator.Buttons.Remove.Visible = false;
            insUpNavigator.Navigator.Buttons.PrevPage.Visible = true;
            insUpNavigator.Navigator.Buttons.NextPage.Visible = true;

            HideItems = new BarItem[] { btnHareketEkle, btnHareketSil };
            ShowItems = new BarItem[] { btnKartDuzenle };
        }

        protected internal override void Listele()
        {
            view.GridControl.DataSource = ((TahakkukBll)Bll).OgrenciTahakkukList(x => x.OgrenciId == OwnerForm.Id);
        }

        protected override void OpenEntity()
        {
            var entity = Tablo.GetRow<OgrenciTahakkukList>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
        }
    }
}