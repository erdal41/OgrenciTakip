using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Events;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;

namespace OgrenciTakip.UI.Win.GenelForms
{
    public partial class DonemParametreEditForm : BaseEditForm
    {
        #region Variables

        private readonly long _donemId;

        #endregion

        public DonemParametreEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new DonemParametreBll();
            HideItems = new BarItem[] { btnYeni, btnSil };
            KayitSonrasiFormuKapat = false;
            EventsLoad();

            _donemId = (long)prm[0];
        }

        #region Functions

        protected override void NesneyiKontrollereBagla()
        {
            var parametre = (DonemParametre)OldEntity;
            var entity = new DonemParametre
            {
                Id = parametre.Id,
                Kod = parametre.Kod,
                SubeId = parametre.SubeId,
                DonemId = parametre.DonemId,
                DonemBaslamaTarihi = parametre.DonemBaslamaTarihi,
                DonemBitisTarihi = parametre.DonemBitisTarihi,
                EgitimBaslamaTarihi = parametre.EgitimBaslamaTarihi,
                EgitimBitisTarihi = parametre.EgitimBaslamaTarihi,
                GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = parametre.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir,
                GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = parametre.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir,
                GunTarihininOncesineIptalTarihiGirilebilir = parametre.GunTarihininOncesineIptalTarihiGirilebilir,
                GunTarihininSonrasinaIptalTarihiGirilebilir = parametre.GunTarihininSonrasinaIptalTarihiGirilebilir,
                GunTarihininOncesineMakbuzTarihiGirilebilir = parametre.GunTarihininOncesineMakbuzTarihiGirilebilir,
                GunTarihininSonrasinaMakbuzTarihiGirilebilir = parametre.GunTarihininSonrasinaMakbuzTarihiGirilebilir,
                HizmetTahakkukKurusKullan = parametre.HizmetTahakkukKurusKullan,
                IndirimTahakkukKurusKullan = parametre.IndirimTahakkukKurusKullan,
                OdemePlaniKurusKullan = parametre.OdemePlaniKurusKullan,
                FaturaTahakkukKurusKullan = parametre.FaturaTahakkukKurusKullan,
                MaksimumTaksitTarihi = parametre.MaksimumTaksitTarihi,
                MaksimumTaksitSayisi = parametre.MaksimumTaksitSayisi,
                GittigiOkulZorunlu = parametre.GittigiOkulZorunlu,
                YetkiKontroluAnlikYapilacak = parametre.YetkiKontroluAnlikYapilacak,
            };

            Id = entity.Id;
            propertyGridControl.SelectedObject = entity;
        }

        protected override void GuncelNesneOlustur()
        {
            if(txtSube.Id == null)
            {
                OldEntity = new DonemParametre();
                NewEntity = new DonemParametre();
                ButtonEnabledDurumu();
                return;
            }

            NewEntity = new DonemParametre
            {
                Id = Id,
                Kod = Id.ToString(),
                SubeId = (long)txtSube.Id,
                DonemId = _donemId,
                DonemBaslamaTarihi = (DateTime)DonemBaslamaTarihi.Value,
                DonemBitisTarihi = (DateTime)DonemBitisTarihi.Value,
                EgitimBaslamaTarihi = (DateTime)EgitimBaslamaTarihi.Value,
                EgitimBitisTarihi = (DateTime)EgitimBaslamaTarihi.Value,
                GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = (bool)GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.Value,
                GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = (bool)GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.Value,
                GunTarihininOncesineIptalTarihiGirilebilir = (bool)GunTarihininOncesineIptalTarihiGirilebilir.Properties.Value,
                GunTarihininSonrasinaIptalTarihiGirilebilir = (bool)GunTarihininSonrasinaIptalTarihiGirilebilir.Properties.Value,
                GunTarihininOncesineMakbuzTarihiGirilebilir = (bool)GunTarihininOncesineMakbuzTarihiGirilebilir.Properties.Value,
                GunTarihininSonrasinaMakbuzTarihiGirilebilir = (bool)GunTarihininSonrasinaMakbuzTarihiGirilebilir.Properties.Value,
                HizmetTahakkukKurusKullan = (bool)HizmetTahakkukKurusKullan.Properties.Value,
                IndirimTahakkukKurusKullan = (bool)IndirimTahakkukKurusKullan.Properties.Value,
                OdemePlaniKurusKullan = (bool)OdemePlaniKurusKullan.Properties.Value,
                FaturaTahakkukKurusKullan = (bool)FaturaTahakkukKurusKullan.Properties.Value,
                MaksimumTaksitTarihi = (DateTime)MaksimumTaksitTarihi.Properties.Value,
                MaksimumTaksitSayisi = (byte)MaksimumTaksitSayisi.Properties.Value,
                GittigiOkulZorunlu = (bool)GittigiOkulZorunlu.Properties.Value,
                YetkiKontroluAnlikYapilacak = (bool)YetkiKontroluAnlikYapilacak.Properties.Value,
            };

            ButtonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtSube)
                {
                    sec.Sec(txtSube);
                }
            }
        }

        protected override bool EntityInsert()
        {
            var result = base.EntityInsert();
            if (!result) return false;

            ReturnEntity();
            return true;
        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();
            if (!result) return false;

            ReturnEntity();
            return true;
        }

        #endregion

        #region Events

        protected override void Control_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GuncelNesneOlustur();
        }

        protected override void Control_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            statusBarAciklama.Caption = e.Row.Properties.Caption;
        }

        protected override void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!(sender is ButtonEdit)) return;
            if (txtSube.Id == null) return;

            OldEntity = ((DonemParametreBll)Bll).Single(x => x.SubeId == txtSube.Id && x.DonemId == _donemId) ?? new DonemParametre();
            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);
        }


        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtSube) return;

            txtSube.ControlEnabledChange(propertyGridControl);
            GuncelNesneOlustur();
        }
        #endregion
    }
}