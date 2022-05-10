using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.DonemForms;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.KullaniciBirimYetkileriEditFormTable
{
    public partial class DonemTable : BaseTablo
    {
        public DonemTable()
        {
            InitializeComponent();
            Bll = new KullaniciBirimYetkileriBll();
            Tablo = view;
            EventsLoad();
        }

        #region Functions

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((KullaniciBirimYetkileriBll)Bll).List(x => x.KullaniciId == OwnerForm.Id && x.KartTuru == KartTuru.Donem).ToBindingList<KullaniciBirimYetkileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<KullaniciBirimYetkileriList>().Select(x => x.DonemId.Value).ToList();

            var entities = ShowListForms<DonemListForm>.ShowDialogListForm(ListeDisiTutulacakKayitlar, true, false).EntityListConvert<Donem>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new KullaniciBirimYetkileriList
                {
                    Kod = entity.Kod,
                    DonemAdi = entity.DonemAdi,
                    KartTuru = KartTuru.Donem,
                    KullaniciId = OwnerForm.Id,
                    DonemId = entity.Id,
                    Insert = true,
                };
                source.Add(row);
            }

            if (!Kaydet()) return;

            Listele();
            view.Focus();
            view.FocusedRowHandle = view.DataRowCount - 1;
        }

        protected override void HareketSil()
        {
            if (view.DataRowCount == 0) return;
            if (Messages.SilMesaj("Dönem Kartı") != DialogResult.Yes) return;

            view.GetRow<IBaseHareketEntity>().Delete = true;
            view.RefreshDataSource();

            var rowHandle = view.FocusedRowHandle;
            if (!Kaydet()) return;
            Listele();
            view.FocusedRowHandle = rowHandle;
        }

        #endregion

        #region Events

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            btnHareketSil.Enabled = view.DataRowCount > 0;
            btnHareketEkle.Enabled = ((KullaniciBirimYetkileriEditForm)OwnerForm).kullaniciTable.Tablo.DataRowCount > 0;
            e.SagMenuGoster(popupMenu);
        }

        #endregion
    }
}