using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;

namespace OgrenciTakip.UI.Win.Forms.RolForms
{
    public partial class RolEditForm : BaseEditForm
    {
        public RolEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new RolBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            EventsLoad();
        }

        #region Functions

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rol() : ((RolBll)Bll).Single(FilterFunctions.Filter<Rol>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur
            txtKod.Text = ((RolBll)Bll).YeniKodVer();

            //txte focuslanır
            txtRolAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rol)OldEntity;

            txtKod.Text = entity.Kod;
            txtRolAdi.Text = entity.RolAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Rol
            {
                Id = Id,
                Kod = txtKod.Text,
                RolAdi = txtRolAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override void TabloYukle()
        {
            rolYetkileriTable.OwnerForm = this;
            rolYetkileriTable.Yukle();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, NewEntity, rolYetkileriTable.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            return ((RolBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod) && rolYetkileriTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            return ((RolBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod) && rolYetkileriTable.Kaydet();
        }

        #endregion

        #region Events

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if(BaseIslemTuru == IslemTuru.EntityUpdate)
            {
                rolYetkileriTable.Tablo.Focus();
            }
        }

        #endregion
    }
}