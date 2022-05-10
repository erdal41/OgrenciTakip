using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.EvrakForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class EvrakBilgileriTable : BaseTablo
    {
        public EvrakBilgileriTable()
        {
            InitializeComponent();
            Bll = new EvrakBilgileriBll();
            Tablo = view;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((EvrakBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<EvrakBilgileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<EvrakBilgileriList>().Where(x => !x.Delete).Select(x => x.EvrakId).ToList();

            var entities = ShowListForms<EvrakListForm>.ShowDialogListForm(KartTuru.Evrak, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Evrak>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new EvrakBilgileriList
                {
                    TahakkukId = OwnerForm.Id,
                    EvrakId = entity.Id,
                    Kod = entity.Kod,
                    EvrakAdi = entity.EvrakAdi,
                    Insert = true,
                };
                source.Add(row);
            }

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colKod;

            ButtonEnabledDurumu(true);
        }
    }
}