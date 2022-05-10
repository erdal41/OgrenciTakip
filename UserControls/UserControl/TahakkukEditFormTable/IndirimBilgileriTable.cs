using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.IndirimForms;
using OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
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
    public partial class IndirimBilgileriTable : BaseTablo
    {
        public IndirimBilgileriTable()
        {
            InitializeComponent();
            Bll = new IndirimBilgileriBll();
            Tablo = view;
            EventsLoad();
            ShowItems = new BarItem[] { btnIptalEt, btnIptalGeriAl };
        }

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((IndirimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<IndirimBilgileriList>();
        }

        protected override void HareketEkle()
        {
            bool HizmetAlindi(long hizmetId)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriList>().Where(x => x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete).Sum(x => x.BrutUcret);
                var indirimToplami = view.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && !x.IptalEdildi && !x.Delete).Sum(x => x.BrutIndirim);

                //eğer hizmettoplami 0 ise false. Eğer hizmettoplami-indirimtoplami sıfırdan büyük ise true değilse false döndürür.
                return hizmetToplami == 0 ? false : hizmetToplami - indirimToplami > 0;
            }

            bool AyniHizmetKartinaAyniIndirimUygulandi(IndiriminUygulanacagiHizmetBilgileriList hizmet)
            {
                return view.DataController.ListSource.Cast<IndirimBilgileriList>().Any(x => x.HizmetId == hizmet.HizmetId && x.IndirimId == hizmet.IndirimId && !x.ManuelGirilenTutar && !x.IptalEdildi && !x.Delete);
            }

            var indirimList = ShowListForms<IndirimListForm>.ShowDialogListForm(KartTuru.Indirim, true).EntityListConvert<IndirimList>();

            if (indirimList == null) return;

            using (var iuhBll = new IndiriminUygulanacagiHizmetBilgileriBll())
            {
                var source = view.DataController.ListSource;
                var sabitTutarliIndirimGirildi = false;
                var eklenenKayitSayisi = 0;

                foreach (var indirim in indirimList)
                {
                    var hizmetList = iuhBll.List(x => x.IndirimId == indirim.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId).Cast<IndiriminUygulanacagiHizmetBilgileriList>();

                    foreach (var hizmet in hizmetList)
                    {
                        if (!HizmetAlindi(hizmet.HizmetId)) continue;
                        if (AyniHizmetKartinaAyniIndirimUygulandi(hizmet)) continue;

                        if (!sabitTutarliIndirimGirildi)
                        {
                            sabitTutarliIndirimGirildi = hizmet.IndirimTutari > 0;
                        }

                        var (brutIndirim, kistDonemDusulenIndirim) = IndirimHesapla(hizmet.IndirimId, hizmet.HizmetId);

                        var row = new IndirimBilgileriList
                        {
                            TahakkukId = OwnerForm.Id,
                            IndirimId = indirim.Id,
                            IndirimAdi = indirim.IndirimAdi,
                            HizmetId = hizmet.HizmetId,
                            HizmetAdi = hizmet.HizmetAdi,
                            IslemTarihi = DateTime.Now.Date,
                            BrutIndirim = brutIndirim,
                            KistDonemDusulenIndirim = kistDonemDusulenIndirim,
                            NetIndirim = brutIndirim - kistDonemDusulenIndirim,
                            OranliIndirim = hizmet.IndirimOrani > 0,
                            ManuelGirilenTutar = hizmet.IndirimOrani == 0 && hizmet.IndirimTutari == 0,
                            Insert = true,
                        };

                        source.Add(row);
                        eklenenKayitSayisi++;

                        if (hizmet.IndirimOrani == 0 && hizmet.IndirimTutari == 0)
                        {
                            view.FocusedColumn = colBrutIndirim;
                        }
                    }
                }

                if (eklenenKayitSayisi == 0) return;

                if (sabitTutarliIndirimGirildi)
                {
                    TopluIndirimHesapla();
                }
            }

            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            ButtonEnabledDurumu(true);
        }

        private (decimal brutIndirim, decimal kistDonemDusulenIndirim) IndirimHesapla(long indirimId, long hizmetId)
        {
            decimal HizmetToplamiAl(bool iptalEdildi)
            {
                var hizmetToplami = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriList>().Where(x => x.HizmetId == hizmetId && x.IptalEdildi == iptalEdildi && !x.Delete).Sum(x => x.BrutUcret);
                var indirimToplami = view.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => x.HizmetId == hizmetId && !x.ManuelGirilenTutar && x.IptalEdildi == iptalEdildi && !x.Delete).Sum(x => x.BrutIndirim);

                return hizmetToplami == 0 ? 0 : hizmetToplami - indirimToplami;
            }

            using (var bll = new IndiriminUygulanacagiHizmetBilgileriBll())
            {
                var hizmetSource = bll.List(x => x.IndirimId == indirimId && x.HizmetId == hizmetId).Cast<IndiriminUygulanacagiHizmetBilgileriList>().FirstOrDefault();

                if (hizmetSource == null) return (0, 0);

                var egitimBitisTarihi = AnaForm.DonemParametreleri.DonemBitisTarihi;
                var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriList>().First(x => x.HizmetId == hizmetId && !x.Delete);
                var indirimEntity = view.DataController.ListSource.Cast<IndirimBilgileriList>().FirstOrDefault(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.Delete);
                var hizmetToplami = hizmetEntity.IptalEdildi ? HizmetToplamiAl(true) : HizmetToplamiAl(false);
                var toplamGunSayisi = hizmetEntity.EgitimDonemiGunSayisi;
                var hizmetGunSayisi = indirimEntity?.IptalTarihi == null ? (int)(egitimBitisTarihi - hizmetEntity.BaslamaTarihi).TotalDays + 1 : (int)(indirimEntity.IptalTarihi - hizmetEntity.BaslamaTarihi).Value.TotalDays + 1;
                var brutIndirim = hizmetSource.IndirimTutari > 0 ? hizmetSource.IndirimTutari : hizmetToplami * hizmetSource.IndirimOrani / 100;
                var gunlukIndirim = brutIndirim / toplamGunSayisi;
                var kistDonemDusulenIndirim = (toplamGunSayisi - hizmetGunSayisi) * gunlukIndirim;
                brutIndirim = Math.Round(brutIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

                return (brutIndirim, kistDonemDusulenIndirim);
            }
        }

        protected internal void TopluIndirimHesapla()
        {
            var source = view.DataController.ListSource.Cast<IndirimBilgileriList>().ToList();

            source.ForEach(x =>
            {
                if (!x.OranliIndirim || x.ManuelGirilenTutar || x.Delete) return;

                x.BrutIndirim = 0;
                x.KistDonemDusulenIndirim = 0;
            });

            source.ForEach(x =>
            {
                if (x.ManuelGirilenTutar || x.Delete) return;

                var (brutIndirim, kistDonemDusulenIndirim) = IndirimHesapla(x.IndirimId, x.HizmetId);
                x.BrutIndirim = brutIndirim;
                x.KistDonemDusulenIndirim = kistDonemDusulenIndirim;
                x.NetIndirim = brutIndirim - kistDonemDusulenIndirim;

                if (!x.Insert)
                {
                    x.Update = true;
                }
            });

            view.UpdateSummary();
        }

        protected override void HareketSil()
        {
            if (view.DataRowCount == 0) return;
            if (Messages.SilMesaj("İndirim Bilgisi") != DialogResult.Yes) return;

            var entity = view.GetRow<IndirimBilgileriList>();

            if (entity.IptalEdildi)
            {
                Messages.IptalHareketSilinemezMesaji();
                return;
            }

            entity.Delete = true;
            view.RefreshDataSource();
            TopluIndirimHesapla();
            ButtonEnabledDurumu(true);
        }

        protected internal void TopluHareketSil(long hizmetId)
        {
            var source = view.DataController.ListSource.Cast<IndirimBilgileriList>();
            if (source == null) return;
            var silinenKayitVarmi = false;

            source.ForEach(x =>
            {
                if (x.IptalEdildi || x.HizmetId != hizmetId) return;
                x.Delete = true;
                silinenKayitVarmi = true;
            });

            if (!silinenKayitVarmi) return;

            view.RefreshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected override void IptalEt()
        {
            var indirimEntity = view.GetRow<IndirimBilgileriList>();

            if (indirimEntity == null || indirimEntity.IptalEdildi || indirimEntity.Insert) return;
            if (Messages.IptalMesaji("İndirim Bilgisi") != DialogResult.Yes) return;

            var hizmetEntity = ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriList>().FirstOrDefault(x => !x.IptalEdildi && x.HizmetId == indirimEntity.HizmetId);

            if (hizmetEntity == null) return;

            var gunlukIndirim = indirimEntity.BrutIndirim / hizmetEntity.EgitimDonemiGunSayisi;
            var alinanHizmetGunSayisi = (int)(DateTime.Now.Date - hizmetEntity.BaslamaTarihi).TotalDays + 1;
            var brutIndirim = gunlukIndirim * alinanHizmetGunSayisi;
            var kistDonemDusulenIndirim = indirimEntity.BrutIndirim - brutIndirim;
            kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

            var iptalNedeni = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, -1);
            if (iptalNedeni != null)
            {
                indirimEntity.IptalNedeniId = iptalNedeni.Id;
                indirimEntity.IptalNedeniAdi = iptalNedeni.IptalNedeniAdi;
            }

            indirimEntity.IndirimAdi = $"{indirimEntity.IndirimAdi} - ( *** İptal Edildi *** )";
            if (!indirimEntity.ManuelGirilenTutar)
            {
                indirimEntity.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
            }
            indirimEntity.NetIndirim = indirimEntity.BrutIndirim - indirimEntity.KistDonemDusulenIndirim;
            indirimEntity.IptalTarihi = DateTime.Now.Date;
            indirimEntity.IptalEdildi = true;
            indirimEntity.Update = true;

            TopluIndirimHesapla();
            view.UpdateSummary();
            view.RowCellEnabled();
            view.FocusedColumn = colIptalAciklama;
            ButtonEnabledDurumu(true);
        }

        protected internal void TopluIptalEt(HizmetBilgileriList entity)
        {
            var source = view.DataController.ListSource.Cast<IndirimBilgileriList>();
            if (source == null) return;

            source.ForEach(x =>
            {
                if (x.HizmetId != entity.HizmetId || x.IptalEdildi) return;

                var gunlukIndirim = x.BrutIndirim / entity.EgitimDonemiGunSayisi;
                var brutIndirim = gunlukIndirim * entity.AlinanHizmetGunSayisi;
                var kistDonemDusulenIndirim = x.BrutIndirim - brutIndirim;
                kistDonemDusulenIndirim = Math.Round(kistDonemDusulenIndirim, AnaForm.DonemParametreleri.IndirimTahakkukKurusKullan ? 2 : 0);

                x.IndirimAdi = $"{x.IndirimAdi} - ( *** İptal Edildi *** )";
                if (!x.ManuelGirilenTutar)
                {
                    x.KistDonemDusulenIndirim = kistDonemDusulenIndirim > 0 ? kistDonemDusulenIndirim : 0;
                }
                x.NetIndirim = x.BrutIndirim - x.KistDonemDusulenIndirim;
                x.IptalTarihi = DateTime.Now.Date;
                x.IptalEdildi = true;
                x.HizmetHareketId = entity.Id;
                x.IptalNedeniId = entity.IptalNedeniId;
                x.IptalNedeniAdi = entity.IptalNedeniAdi;

                if (!x.Insert)
                {
                    x.Update = true;
                }
            });

            TopluIndirimHesapla();
            view.UpdateSummary();
        }

        protected override void IptalGeriAl()
        {
            bool HizmetAlindi(long hizmetId)
            {
                return ((TahakkukEditForm)OwnerForm).hizmetBilgileriTable.Tablo.DataController.ListSource.Cast<HizmetBilgileriList>().Any(x => x.HizmetId == hizmetId && !x.IptalEdildi);
            }

            bool AyniIndirimAlindi(long indirimId, long hizmetId)
            {
                return view.DataController.ListSource.Cast<IndirimBilgileriList>().Any(x => x.IndirimId == indirimId && x.HizmetId == hizmetId && !x.IptalEdildi && !x.Delete);
            }

            var entity = view.GetRow<IndirimBilgileriList>();
            if (entity == null || !entity.IptalEdildi) return;
            if (Messages.IptalGerialMesaji(entity.IndirimAdi) != DialogResult.Yes) return;

            if (entity.HizmetHareketId == null && !HizmetAlindi(entity.HizmetId))
            {
                Messages.HataMesaji("İndirimin uygulandığı hizmet iptal edilmiş. İptal edilen hizmet geri alınmadan veya yeni bir hizmet oluşturulmadan iptal işlemi geri alınamaz.");
                return;
            }

            if (entity.HizmetHareketId != null)
            {
                Messages.HataMesaji("İptal edilen indirim, hizmet hareketleri tablosundan geri alınabilir.");
                return;
            }

            if (AyniIndirimAlindi(entity.IndirimId, entity.HizmetId))
            {
                Messages.HataMesaji("İptal işleminin geri alınması durumunda aynı indirimden birden fazla alım durumu oluşuyor.");
                return;
            }

            //İptal edilen hareketin yanında yazan " - ( *** İptal Edildi *** )" kısmını silmek için 
            entity.IndirimAdi = entity.IndirimAdi.Remove(entity.IndirimAdi.Length - 27, 27);
            entity.IptalEdildi = false;
            entity.IptalTarihi = null;
            entity.IptalNedeniId = null;
            entity.IptalNedeniAdi = null;
            entity.IptalAciklama = null;
            entity.HizmetHareketId = null;
            entity.Update = true;

            TopluIndirimHesapla();
            view.RefreshDataSource();
            view.UpdateSummary();
            view.RowCellEnabled();
            ButtonEnabledDurumu(true);
        }

        protected internal void TopluIptalGeriAl(int hizmetHareketId)
        {
            var source = view.DataController.ListSource.Cast<IndirimBilgileriList>().Where(x => x.HizmetHareketId == hizmetHareketId);
            source.ForEach(x =>
            {
                //İptal edilen hareketin yanında yazan " - ( *** İptal Edildi *** )" kısmını silmek için 
                x.IndirimAdi = x.IndirimAdi.Remove(x.IndirimAdi.Length - 27, 27);
                x.IptalEdildi = false;
                x.IptalTarihi = null;
                x.IptalNedeniId = null;
                x.IptalNedeniAdi = null;
                x.IptalAciklama = null;
                x.HizmetHareketId = null;
                x.Update = true;
            });

            TopluIndirimHesapla();
            view.RefreshDataSource();
            view.UpdateSummary();
        }

        protected override void RowCellAllowEdit()
        {
            if (view.DataRowCount == 0) return;

            var entity = view.GetRow<IndirimBilgileriList>();


            //hizmethareketıd hizmet bilgileri tablosundaki herhangi bir iptal etme işleminde indirim bilgileri tablosundaki o hizmete bağlı indirimide iptal eder.
            colIptalTarihi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalNedeniAdi.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;
            colIptalAciklama.OptionsColumn.AllowEdit = entity.IptalEdildi && entity.HizmetHareketId == null;

            if (entity.Insert)
            {
                colBrutIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && !entity.IptalEdildi;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar && entity.IptalEdildi;
            }
            else
            {
                colBrutIndirim.OptionsColumn.AllowEdit = false;
                colKistDonemDusulenIndirim.OptionsColumn.AllowEdit = entity.ManuelGirilenTutar;
            }
        }

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);

            var entity = (IndirimBilgileriList)view.GetRow(Tablo.FocusedRowHandle);

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
            else if (e.FocusedColumn == colIptalTarihi)
            {
                var entity = view.GetRow<IndirimBilgileriList>();

                if (entity.IptalTarihi == null) return;

                repositoryItemIptalTarihi.MinValue = AnaForm.DonemParametreleri.GunTarihininOncesineIptalTarihiGirilebilir ? entity.IslemTarihi : DateTime.Now.Date;
                repositoryItemIptalTarihi.MaxValue = AnaForm.DonemParametreleri.GunTarihininSonrasinaIptalTarihiGirilebilir ? AnaForm.DonemParametreleri.DonemBitisTarihi.AddDays(-1) : DateTime.Now.Date;
            }
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column == colIptalTarihi)
            {
                TopluIndirimHesapla();
            }
            else if (e.Column == colBrutIndirim || e.Column == colKistDonemDusulenIndirim)
            {
                var entity = view.GetRow<IndirimBilgileriList>();
                entity.NetIndirim = entity.BrutIndirim - entity.KistDonemDusulenIndirim;
            }
        }
    }
}