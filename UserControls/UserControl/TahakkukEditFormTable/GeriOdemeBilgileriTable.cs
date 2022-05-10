using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class GeriOdemeBilgileriTable : BaseTablo
    {
        public GeriOdemeBilgileriTable()
        {
            InitializeComponent();
            Bll = new GeriOdemeBilgileriBll();
            Tablo = view;
            EventsLoad();
            repositoryItemHesapTuru.Items.AddEnum<GeriOdemeHesapTuru>();
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((GeriOdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<GeriOdemeBilgileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;

            var row = new GeriOdemeBilgileriList
            {
                TahakkukId = OwnerForm.Id,
                Tarih = DateTime.Now.Date,
                HesapTuru = GeriOdemeHesapTuru.Kasa,
                Tutar = 0,
                Insert = true,
            };
            source.Add(row);

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colHesapAdi;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (view.HasColumnErrors) view.ClearColumnErrors();

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<GeriOdemeBilgileriList>(i);
                if (entity.HesapId == null)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colHesapAdi;
                    view.SetColumnError(colHesapAdi, "Hesap seçimi yapmalısınız.");
                }

                if (entity.Tutar <= 0)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colTutar;
                    view.SetColumnError(colTutar, "Sıfırdan büyük bir değer giriniz.");
                }

                if (!view.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{view.ViewCaption} Tablosu");

                return true;
            }
            return false;
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column == colHesapId)
            {
                var entity = view.GetRow<GeriOdemeBilgileriList>();
                entity.BankaHesapId = entity.HesapTuru == GeriOdemeHesapTuru.Banka ? entity.HesapId : null;
                entity.KasaId = entity.HesapTuru == GeriOdemeHesapTuru.Kasa ? entity.HesapId : null;
            }
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colHesapAdi)
            {
                e.FocusedColumn.Sec(view, insUpNavigator.Navigator, repositoryItemHesap, colHesapId);
            }
        }

        protected override void ImageCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            var entity = view.GetRow<GeriOdemeBilgileriList>();
            entity.HesapId = null;
            entity.HesapAdi = null;
            view.FocusedColumn = colHesapAdi;
        }
    }
}