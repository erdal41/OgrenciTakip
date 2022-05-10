using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class BilgiNotlariTable : BaseTablo
    {
        public BilgiNotlariTable()
        {
            InitializeComponent();
            Bll = new BilgiNotlariBll();
            Tablo = view;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((BilgiNotlariBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<BilgiNotlariList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;

            var row = new BilgiNotlariList
            {
                TahakkukId = OwnerForm.Id,
                Tarih = DateTime.Now,
                Insert = true,
            };
            source.Add(row);

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colBilgiNotu;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (view.HasColumnErrors) view.ClearColumnErrors();

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<BilgiNotlariList>(i);
                if (entity.BilgiNotu == null)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colBilgiNotu;
                    view.SetColumnError(colBilgiNotu, "Bilgi notu alanına geçerli bir değer giriniz.");
                }

                if (!view.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{view.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }
    }
}