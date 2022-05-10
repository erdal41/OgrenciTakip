using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    public partial class MakbuzHareketleriTable : BaseTablo
    {
        public MakbuzHareketleriTable()
        {
            InitializeComponent();
            Bll = new MakbuzHareketleriBll();
            Tablo = view;
            EventsLoad();
            ShowItems = new BarItem[] { btnBelgeHareketleri };
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((MakbuzHareketleriBll)Bll).List(x => x.MakbuzId == OwnerForm.Id).ToBindingList<MakbuzHareketleriList>();
        }

        protected override void HareketEkle()
        {
            if (((MakbuzEditForm)OwnerForm).HataliGiris()) return;

            var source = view.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<MakbuzHareketleriList>().Where(x => !x.Delete).Select(x => (long)x.OdemeBilgileriId).ToList();

            var entities = ShowListForms<BelgeSecimListForm>.ShowDialogListForm(KartTuru.BelgeSecim, ListeDisiTutulacakKayitlar, true, ((MakbuzEditForm)OwnerForm).MakbuzTuru, ((MakbuzEditForm)OwnerForm).txtMakbuzHesapTuru.Text.GetEnum<MakbuzHesapTuru>(), ((MakbuzEditForm)OwnerForm).txtHesap.Id).EntityListConvert<BelgeSecimList>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new MakbuzHareketleriList
                {
                    MakbuzId = OwnerForm.Id,
                    OgrenciNo = entity.OgrenciNo,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    SinifAdi = entity.SinifAdi,
                    OgrenciSubeAdi = entity.OgrenciSubeAdi,
                    BelgeSubeAdi = entity.BelgeSubeAdi,
                    OdemeBilgileriId = entity.OdemeBilgileriId,
                    OdemeTuruAdi = entity.OdemeTuruAdi,
                    OdemeTipi = entity.OdemeTipi,
                    BankaHesapAdi = entity.BankaHesapAdi,
                    TakipNo = entity.TakipNo,
                    GirisTarihi = entity.GirisTarihi,
                    Vade = entity.Vade,
                    HesabaGecisTarihi = entity.HesabaGecisTarihi,
                    Tutar = entity.Tutar,
                    IslemOncesiTutar = entity.Tutar - (entity.Tahsil + entity.Iade),
                    IslemTutari = entity.Tutar - (entity.Tahsil + entity.Iade),
                    BankaAdi = entity.BankaAdi,
                    BankaSubeAdi = entity.BankaSubeAdi,
                    BelgeNo = entity.BelgeNo,
                    HesapNo = entity.HesapNo,
                    AsilBorclu = entity.AsilBorclu,
                    Ciranta = entity.Ciranta,
                    BelgeDurumu =
                            ((MakbuzEditForm)OwnerForm).MakbuzTuru == MakbuzTuru.BaskaSubeyeGonderme ? BelgeDurumu.OnayBekliyor :
                            ((MakbuzEditForm)OwnerForm).MakbuzTuru == MakbuzTuru.GelenBelgeyiOnaylama ? BelgeDurumu.Portfoyde :
                            ((MakbuzEditForm)OwnerForm).MakbuzTuru.ToName().GetEnum<BelgeDurumu>(),
                    KullaniciId = AnaForm.KullaniciId,
                    EskiSubeId = AnaForm.SubeId,
                    YeniSubeId = ((MakbuzEditForm)OwnerForm).MakbuzTuru == MakbuzTuru.BaskaSubeyeGonderme ? ((MakbuzEditForm)OwnerForm).txtHesap.Id : null,
                    Insert = true,
                };
                source.Add(row);
            }

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            view.FocusedColumn = colIslemTutari;
            SutunGizleGoster();
            RowCellAllowEdit();
            ButtonEnabledDurumu(true);
        }

        protected override void SutunGizleGoster()
        {
            if (view.DataRowCount == 0) return;
            var entity = view.GetRow<MakbuzHareketleriList>(false);
            if (entity == null) return;

            bndBelgeDetayBilgileri.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colTakipNo.Visible = entity.OdemeTipi == OdemeTipi.Pos;
            colBankaHesapAdi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Pos || entity.OdemeTipi == OdemeTipi.Ots;
            colBankaAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBankaSubeAdi.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colHesapNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colBelgeNo.Visible = entity.OdemeTipi == OdemeTipi.Cek;
            colAsilBorclu.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
            colCiranta.Visible = entity.OdemeTipi == OdemeTipi.Cek || entity.OdemeTipi == OdemeTipi.Senet;
        }

        protected override void RowCellAllowEdit()
        {
            if (view.DataRowCount == 0) return;
            var entity = view.GetRow<MakbuzHareketleriList>(false);
            if (entity == null) return;

            var makbuzTuru = ((MakbuzEditForm)OwnerForm).MakbuzTuru;

            switch (makbuzTuru)
            {
                case MakbuzTuru.AvukatYoluylaTahsilEtme:
                case MakbuzTuru.TahsilEtmeBanka:
                case MakbuzTuru.TahsilEtmeKasa:
                    colIslemTutari.OptionsColumn.AllowEdit = entity.Id == 0 || entity.Id >= entity.SonHareketId;
                    break;
            }
        }

        protected override void HareketSil()
        {
            if (Messages.SilMesaj("Makbuz Hareketi") != DialogResult.Yes) return;
            var entity = view.GetRow<MakbuzHareketleriList>();
            if (entity == null) return;

            if (entity.Id != 0 && entity.Id < entity.SonHareketId)
            {
                Messages.OdemeBelgesiSilinemezMesaji(true);
                return;
            }

            entity.Delete = true;
            view.RefreshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected internal bool TopluHareketSil()
        {
            if (Messages.SilMesaj("Makbuz Kartı") != DialogResult.Yes) return false;

            if (((MakbuzEditForm)OwnerForm).BaseIslemTuru != IslemTuru.EntityInsert)
            {
                var silinemeyenBelgeSayisi = 0;
                var source = view.DataController.ListSource.Cast<MakbuzHareketleriList>();

                source.ForEach(x =>
                {
                    if (x.Id == 0 || x.Id >= x.SonHareketId)
                    {
                        x.Delete = true;
                        ButtonEnabledDurumu(true);
                    }
                    else
                    {
                        silinemeyenBelgeSayisi++;
                    }
                });

                view.RefreshDataSource();

                if (silinemeyenBelgeSayisi > 0)
                {
                    Messages.HataMesaji($"Makbuz içerisinde daha sonra işlem görmüş {silinemeyenBelgeSayisi} adet belge bulunmaktadır. Makbuz tamamen iptal  edilemez.");
                    return false;
                }

                Kaydet();
                return true;
            }

            return true;
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            if (view.HasColumnErrors)
            {
                view.ClearColumnErrors();
            }

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<MakbuzHareketleriList>(i);
                if (entity.IslemTutari <= 0)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colIslemTutari;
                    view.SetColumnError(colIslemTutari, "İşlem tutarı, sıfıra eşit veya sıfırdan küçük olamaz.");
                }

                if (entity.IslemTutari > entity.IslemOncesiTutar)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colIslemTutari;
                    view.SetColumnError(colIslemTutari, "İşlem tutarı kalan bakiyeden büyük olamaz.");
                }

                if (!view.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{view.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void BelgeHareketleri()
        {
            var entity = view.GetRow<MakbuzHareketleriList>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.OdemeBilgileriId);
        }

        #region Events

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = view.GetRow<MakbuzHareketleriList>();
            if (entity == null) return;
            if (e.Column != colIslemTutari) return;

            if ((decimal)e.Value < entity.IslemOncesiTutar)
            {
                entity.BelgeDurumu = entity.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme ? BelgeDurumu.KismiAvukatYoluylaTahsilEtme : BelgeDurumu.KismiTahsilEdildi;
            }
            else
            {
                entity.BelgeDurumu = ((MakbuzEditForm)OwnerForm).MakbuzTuru.ToName().GetEnum<BelgeDurumu>();
            }
        }

        protected override void Tablo_RowCountChanged(object sender, System.EventArgs e)
        {
            ((MakbuzEditForm)OwnerForm).MakbuzTuruEnabled();
        }

        #endregion
    }
}