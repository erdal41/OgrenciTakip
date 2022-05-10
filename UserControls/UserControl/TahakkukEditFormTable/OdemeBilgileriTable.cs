using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.MakbuzForms;
using OgrenciTakip.UI.Win.Forms.TahakkukForm;
using OgrenciTakip.UI.Win.Forms.TahakkukForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class OdemeBilgileriTable : BaseTablo
    {
        public OdemeBilgileriTable()
        {
            InitializeComponent();
            Bll = new OdemeBilgileriBll();
            Tablo = view;
            EventsLoad();
            ShowItems = new BarItem[] { btnBelgeHareketleri };
        }

        #region Functions

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((OdemeBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<OdemeBilgileriList>();
        }

        protected override void HareketEkle()
        {
            decimal BakiyeHesapla()
            {
                var bakiye = ((TahakkukEditForm)OwnerForm).txtFark.Value;
                return bakiye <= 0 ? 0 : bakiye;
            }

            var source = view.DataController.ListSource;
            var dahaOnceGirilenTaksitSayisi = source.Cast<OdemeBilgileriList>().Count(x => !x.Delete && x.BelgeDurumu != BelgeDurumu.MusteriyeGeriIade);

            if (!ShowEditForms<TopluOdemePlaniEditForm>.ShowDialogEditForm(source, OwnerForm.Id, BakiyeHesapla(), ((TahakkukEditForm)OwnerForm).txtKayitTarihi.DateTime.Date, dahaOnceGirilenTaksitSayisi)) return;

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            view.FocusedColumn = colOdemeTuruAdi;
            ButtonEnabledDurumu(true);
        }

        protected override void SutunGizleGoster()
        {
            if (view.DataRowCount == 0) return;
            var entity = view.GetRow<OdemeBilgileriList>();
            if (entity == null) return;

            colBankaHesapAdi.VisibleIndex = 10;
            colTakipNo.VisibleIndex = 11;
            colBlokeGunSayisi.VisibleIndex = 12;
            colBankaAdi.VisibleIndex = 13;
            colBankaSubeAdi.VisibleIndex = 14;
            colHesapNo.VisibleIndex = 15;
            colBelgeNo.VisibleIndex = 16;
            colAsilBorclu.VisibleIndex = 17;
            colCiranta.VisibleIndex = 18;

            colBankaHesapAdi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Ots || entity.OdemeTipi == OdemeTipi.Pos;
            colTakipNo.Visible = entity.OdemeTipi == OdemeTipi.Pos;
            colBlokeGunSayisi.Visible = entity.OdemeTipi == OdemeTipi.Epos || entity.OdemeTipi == OdemeTipi.Ots || entity.OdemeTipi == OdemeTipi.Pos;
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
            var entity = view.GetRow<OdemeBilgileriList>();
            if (entity == null) return;

            colBankaHesapAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colVade.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colTutar.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colTakipNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBankaAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBankaSubeAdi.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colHesapNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colBelgeNo.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colAsilBorclu.OptionsColumn.AllowEdit = entity.SonHareketId == null;
            colCiranta.OptionsColumn.AllowEdit = entity.SonHareketId == null;
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (view.HasColumnErrors) view.ClearColumnErrors();

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<OdemeBilgileriList>(i);

                if (entity.Tutar == 0)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colTutar;
                    view.SetColumnError(colTutar, "Belge tutarı Sıfır(0) olamaz.");
                }

                switch (entity.OdemeTipi)
                {
                    case OdemeTipi.Cek:
                        if (entity.BankaId == null)
                        {
                            view.FocusedRowHandle = i;
                            view.FocusedColumn = colBankaAdi;
                            view.SetColumnError(colBankaAdi, "Banka seçimi yapmalısınız.");
                        }

                        if (entity.BankaSubeId == null)
                        {
                            view.FocusedRowHandle = i;
                            view.FocusedColumn = colBankaSubeAdi;
                            view.SetColumnError(colBankaSubeAdi, "Banka şubesi seçimi yapmalısınız.");
                        }

                        if (string.IsNullOrEmpty(entity.BelgeNo))
                        {
                            view.FocusedRowHandle = i;
                            view.FocusedColumn = colBelgeNo;
                            view.SetColumnError(colBelgeNo, "Belge no alanına geçerli bir değer giriniz.");
                        }

                        if (string.IsNullOrEmpty(entity.AsilBorclu))
                        {
                            view.FocusedRowHandle = i;
                            view.FocusedColumn = colAsilBorclu;
                            view.SetColumnError(colAsilBorclu, "Asıl borçlu alanına geçerli bir değer giriniz.");
                        }
                        break;
                    case OdemeTipi.Senet:
                        if (string.IsNullOrEmpty(entity.AsilBorclu))
                        {
                            view.FocusedRowHandle = i;
                            view.FocusedColumn = colAsilBorclu;
                            view.SetColumnError(colAsilBorclu, "Asıl borçlu alanına geçerli bir değer giriniz.");
                        }
                        break;
                    case OdemeTipi.Epos:
                    case OdemeTipi.Ots:
                    case OdemeTipi.Pos:
                        if (entity.BankaHesapId == null)
                        {
                            view.FocusedRowHandle = i;
                            view.FocusedColumn = colBankaHesapAdi;
                            view.SetColumnError(colBankaHesapAdi, "Banka hesabı seçimi yapmalısınız.");
                        }
                        break;

                }
                if (view.HasColumnErrors)
                {
                    Messages.TabloEksikBilgiMesaji($"{view.ViewCaption} Tablosu");
                    return true;
                }

            }
            return false;
        }

        protected override void HareketSil()
        {
            if (view.DataRowCount == 0) return;
            if (Messages.SilMesaj("Ödeme Bilgisi") != DialogResult.Yes) return;
            var entity = view.GetRow<OdemeBilgileriList>();

            if (entity.SonHareketId != null)
            {
                Messages.OdemeBelgesiSilinemezMesaji(false);
                return;
            }

            entity.Delete = true;
            view.RefreshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected override void BelgeHareketleri()
        {
            var entity = view.GetRow<OdemeBilgileriList>();
            if (entity == null) return;

            ShowListForms<BelgeHareketleriListForm>.ShowDialogListForm(KartTuru.BelgeHareketleri, null, entity.Id);
        }

        #endregion

        #region Events

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = view.GetRow<OdemeBilgileriList>();

            if (e.Column == colVade)
            {
                entity.VadeYazi = ((DateTime)e.Value).YaziIleVade();
                entity.HesabaGecisTarihi = entity.Vade.AddDays(entity.BlokeGunSayisi);
            }
            else if (e.Column == colTutar)
            {
                entity.TutarYazi = ((decimal)e.Value).YaziIleTutar();
            }
            else if (e.Column == colBlokeGunSayisi)
            {
                entity.HesabaGecisTarihi = entity.Vade.AddDays(entity.BlokeGunSayisi);
            }
            else if (e.Column == colBankaId)
            {
                entity.BankaSubeId = null;
                entity.BankaSubeAdi = null;
                colBankaSubeAdi.OptionsColumn.AllowEdit = entity.BankaId != null;
            }
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colBankaHesapAdi)
            {
                e.FocusedColumn.Sec(view, insUpNavigator.Navigator, repositoryItemBankaHesap, colBankaHesapId);
            }

            if (e.FocusedColumn == colBankaAdi)
            {
                e.FocusedColumn.Sec(view, insUpNavigator.Navigator, repositoryItemBanka, colBankaId);
            }

            if (e.FocusedColumn == colBankaSubeAdi)
            {
                e.FocusedColumn.Sec(view, insUpNavigator.Navigator, repositoryItemBankaSube, colBankaSubeId, colBankaId, colBankaAdi);
            }
            else if (e.FocusedColumn == colVade)
            {
                repositoryItemVade.MinValue = ((TahakkukEditForm)OwnerForm).txtKayitTarihi.DateTime.Date;
                repositoryItemVade.MaxValue = AnaForm.DonemParametreleri.MaksimumTaksitTarihi;
            }
        }

        #endregion
    }
}