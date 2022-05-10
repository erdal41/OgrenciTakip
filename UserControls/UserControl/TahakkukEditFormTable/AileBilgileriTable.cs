using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class AileBilgileriTable : BaseTablo
    {
        public AileBilgileriTable()
        {
            InitializeComponent();
            Bll = new AileBilgileriBll();
            Tablo = view;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((AileBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<AileBilgileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<AileBilgileriList>().Where(x => !x.Delete).Select(x => x.AileBilgiId).ToList();

            var entities = ShowListForms<AileBilgiListForm>.ShowDialogListForm(KartTuru.AileBilgi, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<AileBilgi>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new AileBilgileriList
                {
                    TahakkukId = OwnerForm.Id,
                    AileBilgiId = entity.Id,
                    BilgiAdi = entity.BilgiAdi,
                    Aciklama = null,
                    Insert = true,
                };
                source.Add(row);
            }

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colBilgiAdi;

            ButtonEnabledDurumu(true);
        }
    }
}