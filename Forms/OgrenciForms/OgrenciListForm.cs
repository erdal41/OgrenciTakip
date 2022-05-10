using DevExpress.XtraBars;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;

namespace OgrenciTakip.UI.Win.Forms.OgrenciForms
{
    public partial class OgrenciListForm : BaseListForm
    {
        public OgrenciListForm()
        {
            InitializeComponent();
            Bll = new OgrenciBll();
            ShowItems = new BarItem[] { btnTahakkukYap };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Ogrenci;
            FormShow = new ShowEditForms<OgrenciEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OgrenciBll)Bll).List(FilterFunctions.Filter<Ogrenci>(AktifKartlariGoster));
        }

        protected override void TahakkukYap()
        {
            var entity = view.GetRow<OgrenciList>().EntityConvert<Ogrenci>();

            using (var bll = new TahakkukBll())
            {
                //Ogrenci ID ye göre tahakkuları getirir.
                var tahakkuk = bll.SingleSummary(x => x.OgrenciId == entity.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

                if (tahakkuk != null)
                {
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, tahakkuk.Id, null);
                }
                else
                {
                    ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, -1, entity);
                }
            }
        }
    }
}