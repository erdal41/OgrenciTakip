using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.IndirimEditFormTable
{
    public partial class IndiriminUygulanacagiHizmetlerTable : BaseTablo
    {
        public IndiriminUygulanacagiHizmetlerTable()
        {
            InitializeComponent();
            Bll = new IndiriminUygulanacagiHizmetBilgileriBll();
            Tablo = view;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((IndiriminUygulanacagiHizmetBilgileriBll)Bll).List(x => x.IndirimId == OwnerForm.Id).ToBindingList<IndiriminUygulanacagiHizmetBilgileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IndiriminUygulanacagiHizmetBilgileriList>().Where(x => !x.Delete).Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<HizmetList>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new IndiriminUygulanacagiHizmetBilgileriList
                {
                    IndirimId = OwnerForm.Id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    IndirimTutari = 0,
                    IndirimOrani = 0,
                    SubeId = AnaForm.SubeId,
                    DonemId = AnaForm.DonemId,
                    Insert = true,
                };

                source.Add(row);
            }

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colIndirimTutari;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            for (int i = 0; i < Tablo.DataRowCount; i++)
            {
                var entity = view.GetRow<IndiriminUygulanacagiHizmetBilgileriList>(i);
                if (entity.IndirimTutari == 0 || entity.IndirimOrani == 0) continue;
                view.Focus();
                view.FocusedRowHandle = i;
                Messages.HataMesaji("İndirim tutarı veya indirim oranı alanlarından sadece birinin değeri Sıfır(0)'dan büyük olmalıdır.");
                return true;
            }
            return false;
        }
    }
}