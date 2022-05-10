using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.HizmetForms;
using OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using OgrenciTakip.UI.Win.Forms.OkulForms;
using OgrenciTakip.UI.Win.Forms.ServisForms;
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
    public partial class HizmetBilgileriTable : BaseTablo
    {
        public HizmetBilgileriTable()
        {
            InitializeComponent();
            Bll = new HizmetBilgileriBll();
            Tablo = view;
            EventsLoad();
            ShowItems = new BarItem[] { btnIptalEt, btnIptalGeriAl };
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((HizmetBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<HizmetBilgileriList>();
        }

        protected override void HareketEkle()
        {
            var source = view.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<HizmetBilgileriList>().Where(x => !x.IptalEdildi && !x.Delete).Select(x => x.HizmetId).ToList();

            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true, true).EntityListConvert<HizmetList>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                Servis servis = null;

                if (entity.HizmetTipi == HizmetTipi.Servis)
                {
                    servis = (Servis)ShowListForms<ServisListForm>.ShowDialogListForm(KartTuru.Servis, -1);

                    if (servis == null) continue;
                }

                var row = new HizmetBilgileriList
                {
                    TahakkukId = OwnerForm.Id,
                    HizmetId = entity.Id,
                    HizmetAdi = entity.HizmetAdi,
                    HizmetTuruId = entity.HizmetTuruId,
                    HizmetTipi = entity.HizmetTipi,
                    IslemTarihi = DateTime.Now.Date,
                    BaslamaTarihi = entity.BaslamaTarihi,
                    BrutUcret = entity.Ucret,
                    KistDonemDusulenUcret = 0,
                    IptalEdildi = false,
                    Insert = true,
                };

                if (servis != null)
                {
                    row.ServisId = servis.Id;
                    row.ServisYeriAdi = servis.ServisYeri;
                    row.BrutUcret = servis.Ucret;
                }

                UcretHesapla(row);
                source.Add(row);
            }

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            view.FocusedColumn = colHizmetAdi;
            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            bool IndirimToplamiHizmetToplamindanBuyuk(long hizmetId)
            {
                var hizmetToplami = view.DataController.ListSource.Cast<HizmetBilgileriList>().Where(x => x.HizmetId == hizmetId && !x.Delete).Sum(x => x.BrutUcret - x.KistDonemDusulenUcret);
                var indirimToplami = ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => x.HizmetId == hizmetId && !x.Delete).Sum(x => x.BrutIndirim - x.KistDonemDusulenIndirim);
                return indirimToplami > hizmetToplami;
            }

            if (!TableValueChanged) return false;
            if (view.HasColumnErrors) view.ClearColumnErrors();

            for (int i = 0; i < view.DataRowCount; i++)
            {
                var entity = view.GetRow<HizmetBilgileriList>(i);
                if (entity.IptalEdildi && entity.HizmetTipi == HizmetTipi.Egitim && AnaForm.DonemParametreleri.GittigiOkulZorunlu && entity.GittigiOkulId == null)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colGittigiOkulAdi;
                    view.SetColumnError(colGittigiOkulAdi, "Gittiği okul adı alanına geçerli bir değer giriniz.");
                }

                if (entity.IptalEdildi && entity.IptalNedeniId == null)
                {
                    view.FocusedRowHandle = i;
                    view.FocusedColumn = colIptalNedeniAdi;
                    view.SetColumnError(colIptalNedeniAdi, "İptal nedeni alanına geçerli bir değer giriniz.");
                }

                if (view.HasColumnErrors)
                {
                    Messages.TabloEksikBilgiMesaji($"{view.ViewCaption} Tablosu");
                    return true;
                }

                if (IndirimToplamiHizmetToplamindanBuyuk(entity.HizmetId))
                {
                    view.FocusedRowHandle = i;
                    Messages.HataMesaji($"{entity.HizmetAdi} kartına uygulanan indirimlerin toplamı, kartın toplam tutarını aşmaktadır.");
                    return true;
                }
            }
            return false;
        }

        private void UcretHesapla(HizmetBilgileriList entity)
        {
            var egitimBaslamaTarihi = AnaForm.DonemParametreleri.EgitimBaslamaTarihi;
            var egitimBitisTarihi = AnaForm.DonemParametreleri.DonemBitisTarihi;

            var toplamGunSayisi = (int)(egitimBitisTarihi - egitimBaslamaTarihi).TotalDays + 1;
            var gunlukUcret = entity.BrutUcret / toplamGunSayisi;
            var alinanHizmetGunSayisi = entity.IptalTarihi == null ? (int)(egitimBitisTarihi - entity.BaslamaTarihi).TotalDays + 1 : (int)(entity.IptalTarihi - entity.BaslamaTarihi).Value.TotalDays + 1;
            var odenecekUcret = alinanHizmetGunSayisi > 0 ? gunlukUcret * alinanHizmetGunSayisi : 0;
            var kistDonemDusulenUcret = entity.BrutUcret - odenecekUcret;
            kistDonemDusulenUcret = Math.Round(kistDonemDusulenUcret, AnaForm.DonemParametreleri.HizmetTahakkukKurusKullan ? 2 : 0);

            if (entity.BaslamaTarihi > egitimBaslamaTarihi || entity.IptalEdildi)
            {
                entity.KistDonemDusulenUcret = kistDonemDusulenUcret;
            }
            else
            {
                entity.KistDonemDusulenUcret = 0;
            }

            entity.NetUcret = entity.BrutUcret - entity.KistDonemDusulenUcret;
            entity.EgitimDonemiGunSayisi = toplamGunSayisi;
            entity.AlinanHizmetGunSayisi = alinanHizmetGunSayisi;
            entity.GunlukUcret = gunlukUcret;
        }

        protected override void IptalEt()
        {
            var entity = view.GetRow<HizmetBilgileriList>();

            if (entity == null || entity.IptalEdildi || entity.Insert) return;
            if (Messages.IptalMesaji("Hizmet Bilgisi") != DialogResult.Yes) return;

            var iptalNedeni = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, -1);
            if (iptalNedeni != null)
            {
                entity.IptalNedeniId = iptalNedeni.Id;
                entity.IptalNedeniAdi = iptalNedeni.IptalNedeniAdi;
            }

            if (entity.HizmetTipi == HizmetTipi.Egitim)
            {
                var gittigiOkul = (OkulList)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, -1);
                if (gittigiOkul != null)
                {
                    entity.GittigiOkulId = gittigiOkul.Id;
                    entity.GittigiOkulAdi = gittigiOkul.OkulAdi;
                }
            }

            entity.IptalTarihi = DateTime.Now.Date;
            entity.HizmetAdi = $"{entity.HizmetAdi} - ( *** İptal Edildi *** )";
            entity.IptalEdildi = true;
            entity.Update = true;
            UcretHesapla(entity);

            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIptalEt(entity);
            view.UpdateSummary();
            view.RowCellEnabled();
            view.FocusedColumn = colIptalAciklama;
            ButtonEnabledDurumu(true);
        }

        protected override void IptalGeriAl()
        {
            bool AyniHizmetAlindi(long hizmetId)
            {
                return view.DataController.ListSource.Cast<HizmetBilgileriList>().Any(x => x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete);
            }

            var entity = view.GetRow<HizmetBilgileriList>();
            if (entity == null || !entity.IptalEdildi) return;

            if (Messages.IptalGerialMesaji(entity.HizmetAdi) != DialogResult.Yes) return;
            if (AyniHizmetAlindi(entity.HizmetId))
            {
                Messages.HataMesaji("İptal işleminin geri alınması durumunda aynı hizmetten birden fazla alım durumu oluşuyor.");
                return;
            }

            //İptal edilen hareketin yanında yazan " - ( *** İptal Edildi *** )" kısmını silmek için 
            entity.HizmetAdi = entity.HizmetAdi.Remove(entity.HizmetAdi.Length - 27, 27);
            entity.IptalEdildi = false;
            entity.IptalTarihi = null;
            entity.IptalNedeniId = null;
            entity.IptalNedeniAdi = null;
            entity.GittigiOkulId = null;
            entity.GittigiOkulAdi = null;
            entity.IptalAciklama = null;
            entity.Update = true;

            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIptalGeriAl(entity.Id);
            UcretHesapla(entity);
            view.UpdateSummary();
            view.RowCellEnabled();
            ButtonEnabledDurumu(true);
        }

        protected override void SutunGizleGoster()
        {
            if (view.DataRowCount == 0) return;

            var entity = view.GetRow<HizmetBilgileriList>();

            if (entity.HizmetTipi == HizmetTipi.Servis)
            {
                colServisYeriAdi.Visible = true;
                colServisYeriAdi.VisibleIndex = 1;
            }
            else
            {
                colServisYeriAdi.Visible = false;
            }
        }

        protected override void RowCellAllowEdit()
        {
            if (view.DataRowCount == 0) return;

            var entity = view.GetRow<HizmetBilgileriList>();

            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colIptalNedeniAdi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colGittigiOkulAdi.OptionsColumn.AllowEdit = entity.IptalEdildi;
            colIptalAciklama.OptionsColumn.AllowEdit = entity.IptalEdildi;

            if (entity.HizmetTipi != HizmetTipi.Egitim)
            {
                colGittigiOkulAdi.OptionsColumn.AllowEdit = false;
            }
        }

        protected override void HareketSil()
        {
            bool HizmetKartinaAitIptalEdilmisHareketVarmi(long hizmetId)
            {
                var count = view.DataController.ListSource.Cast<HizmetBilgileriList>().Count(x => x.HizmetId == hizmetId);
                return count < 2 && ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriList>().Any(x => x.HizmetId == hizmetId && x.IptalEdildi);
            }

            if (view.DataRowCount == 0) return;
            if (Messages.SilMesaj("Hizmet Bilgisi") != DialogResult.Yes) return;

            var entity = view.GetRow<HizmetBilgileriList>();

            if (entity.IptalEdildi)
            {
                Messages.IptalHareketSilinemezMesaji();
                return;
            }

            if (HizmetKartinaAitIptalEdilmisHareketVarmi(entity.HizmetId))
            {
                Messages.HataMesaji("Bu hizmet kartına ait iptal edilmiş indirim hareketleri bulunmaktadır. Hizmet kartı silinemez.");
                return;
            }

            ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluHareketSil(entity.HizmetId);
            entity.Delete = true;
            view.RefreshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity = (HizmetBilgileriList)view.GetRow(Tablo.FocusedRowHandle);

            if (entity == null) return;

            btnHareketSil.Enabled = !entity.IptalEdildi;
            btnIptalEt.Enabled = !entity.IptalEdildi && !entity.Insert;
            btnIptalGeriAl.Enabled = entity.IptalEdildi;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colIptalNedeniAdi)
            {
                e.FocusedColumn.Sec(view, insUpNavigator.Navigator, repositoryItemIptalNedeni, colIptalNedeniId);
            }
            else if (e.FocusedColumn == colGittigiOkulAdi)
            {
                e.FocusedColumn.Sec(view, insUpNavigator.Navigator, repositoryItemGittigiOkul, colGittigiOkulId);
            }
            else if (e.FocusedColumn == colIptalTarihi)
            {
                var entity = view.GetRow<HizmetBilgileriList>();

                if (entity.IptalTarihi == null) return;

                repositoryItemIptalTarihi.MinValue = AnaForm.DonemParametreleri.GunTarihininOncesineIptalTarihiGirilebilir ? entity.BaslamaTarihi : DateTime.Now.Date;
                repositoryItemIptalTarihi.MaxValue = AnaForm.DonemParametreleri.GunTarihininSonrasinaIptalTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi.AddDays(-1) : DateTime.Now.Date;
            }
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = view.GetRow<HizmetBilgileriList>();

            if (e.Column == colIptalNedeniAdi)
            {
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id).ForEach(x => x.IptalNedeniId = entity.IptalNedeniId);
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id).ForEach(x => x.IptalNedeniAdi = entity.IptalNedeniAdi);
            }
            else if (e.Column == colIptalAciklama)
            {
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id).ForEach(x => x.IptalAciklama = entity.IptalAciklama);
            }
            else if (e.Column == colIptalTarihi)
            {
                UcretHesapla(entity);
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.Tablo.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => x.IptalEdildi && x.HizmetHareketId == entity.Id).ForEach(x => x.IptalTarihi = entity.IptalTarihi);
                ((TahakkukEditForm)OwnerForm).indirimBilgileriTable.TopluIndirimHesapla();
            }
        }
    }
}