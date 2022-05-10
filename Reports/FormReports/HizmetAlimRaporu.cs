using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Reports.FormReports.Base;
using OgrenciTakip.UI.Win.Show;
using System.Linq;

namespace OgrenciTakip.UI.Win.Reports.FormReports
{
    public partial class HizmetAlimRaporu : BaseRapor
    {
        public HizmetAlimRaporu()
        {
            InitializeComponent();
        }

        protected override void DegiskenleriDoldur()
        {
            DataLayoutControl = myDataLayoutControl;
            Tablo = view;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Hizmetler = txtHizmetTurleri;
            HizmetAlimTuru = txtHizmetAlimTuru;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            HizmetKartlariYukle();
            txtHizmetAlimTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<HizmetAlimDurumu>());
            txtHizmetAlimTuru.SelectedItem = HizmetAlimDurumu.HizmetiAlanlar.ToName();
            RaporTuru = KartTuru.HizmetAlimRaporu;
        }

        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboboxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboboxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboboxList<KayitDurumu>();
            var hizmetler = txtHizmetTurleri.CheckedComboboxList<long>();

            using (var bll = new HizmetAlimRaporuBll())
            {
                view.GridControl.DataSource = bll.List(x =>
                    subeler.Contains(x.SubeId) &&
                    kayitSekli.Contains(x.KayitSekli) &&
                    kayitDurumu.Contains(x.KayitDurumu) &&
                    x.DonemId == AnaForm.DonemId, 
                    hizmetler, 
                    txtHizmetAlimTuru.Text.GetEnum<HizmetAlimDurumu>()
                );

                base.Listele();
            }
        }

        protected override void ShowEditForm()
        {
            var entity = view.GetRow<HizmetAlimRaporuList>();
            if (entity == null) return;

            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);
        }
    }
}