using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class SinavBilgileriTable : BaseTablo
    {
        public SinavBilgileriTable()
        {
            InitializeComponent();
            Bll = new SinavBilgileriBll();
            Tablo = view;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((SinavBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<SinavBilgileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;

            var row = new SinavBilgileriList
            {
                TahakkukId = OwnerForm.Id,
                Tarih = DateTime.Now.Date,
                Insert = true,
            };
            source.Add(row);

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colSinavAdi;

            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (view.HasColumnErrors) view.ClearColumnErrors();

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<SinavBilgileriList>(i);
                if (string.IsNullOrEmpty(entity.SinavAdi))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colSinavAdi;
                    view.SetColumnError(colSinavAdi, "Sınav adı alanına geçerli bir değer giriniz.");
                }

                if (string.IsNullOrEmpty(entity.PuanTuru))
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colPuanTuru;
                    view.SetColumnError(colPuanTuru, "Puan türü alanına geçerli bir değer giriniz.");
                }

                if (!view.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{view.ViewCaption} Tablosu");

                return true;
            }

            return false;
        }
    }
}