using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.Drawing;

namespace OgrenciTakip.UI.Win.GenelForms
{
    public partial class KullaniciParametreEditForm : BaseEditForm
    {
        #region Variables

        private readonly long _kullaniciId;

        #endregion

        public KullaniciParametreEditForm(params object[] prm)
        {
            InitializeComponent();

            _kullaniciId = (long)prm[0];
            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciParametreBll(); //Hata durumu olmadığından Bll'e datalayoutcontrol gondermedik
            HideItems = new BarItem[] { btnYeni, btnSil };
            EventsLoad();

        }

        #region Functions

        public override void Yukle()
        {
            //Bu form direk edit olarak açıldığı için farklı bir sorgulama metodu yaptık. OldEntity bağlı olan Bll'deki kullaniciId parametresi giriş yapan kullanıcının Id'sine eşit ise o kullanıcının verilerini yukler. Ama yeni kullanıcı kayıt olup giriş yapmışsa yani null ise KullaniciParametreSingle'deki varsayılan verileri çeker.
            OldEntity = ((KullaniciParametreBll)Bll).Single(x => x.KullaniciId == _kullaniciId) ?? new KullaniciParametreSingle();

            // OldEntity bağlı olan Bll'deki kullaniciId parametresi giriş yapan kullanıcının Id'sine eşit ise OldEntity sıfır(0) gelmeyecek ve güncelleme yapacak. Ama yeni kullanıcı kayıt olup giriş yapmışsa sıfır(0) gelecek ve kaydetme işlemini yapacak.
            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciParametreSingle)OldEntity;

            Id = entity.Id;
            txtVarsayilanAvukatHesabi.Id = entity.DefaultAvukatHesapId;
            txtVarsayilanAvukatHesabi.Text = entity.DefaultAvukatHesapAdi;
            txtVarsayilanBankaHesabi.Id = entity.DefaultBankaHesapId;
            txtVarsayilanBankaHesabi.Text = entity.DefaultBankaHesapAdi;
            txtVarsayilanKasaHesabi.Id = entity.DefaultKasaHesapId;
            txtVarsayilanKasaHesabi.Text = entity.DefaultKasaHesapAdi;
            txtRaporlariOnayAlmadanKapat.Checked = entity.RaporlariOnayAlmadanKapat;
            txtTabloBasligiYaziRengi.Color = Color.FromArgb(entity.TableViewCaptionForeColor);
            txtTabloBasligiSutunYaziRengi.Color = Color.FromArgb(entity.TableColumnHeaderForeColor);
            txtTabloBandPanelYaziRengi.Color = Color.FromArgb(entity.TableBandPanelForeColor);
            imgArkaPlanResmi.EditValue = entity.ArkaPlanResmi;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new KullaniciParametre
            {
                Id = Id,
                Kod = "Param-001",
                KullaniciId = AnaForm.KullaniciId,
                DefaultAvukatHesapId = txtVarsayilanAvukatHesabi.Id,
                DefaultBankaHesapId = txtVarsayilanBankaHesabi.Id,
                DefaultKasaHesapId = txtVarsayilanKasaHesabi.Id,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TableViewCaptionForeColor = txtTabloBasligiYaziRengi.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTabloBasligiSutunYaziRengi.Color.ToArgb(),
                TableBandPanelForeColor = txtTabloBandPanelYaziRengi.Color.ToArgb(),
                ArkaPlanResmi = (byte[])imgArkaPlanResmi.EditValue,
            };

            ButtonEnabledDurumu();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new KullaniciParametreSingle
            {
                DefaultAvukatHesapId = txtVarsayilanAvukatHesabi.Id,
                DefaultAvukatHesapAdi = txtVarsayilanAvukatHesabi.Text,
                DefaultBankaHesapId = txtVarsayilanBankaHesabi.Id,
                DefaultBankaHesapAdi = txtVarsayilanBankaHesabi.Text,
                DefaultKasaHesapId = txtVarsayilanKasaHesabi.Id,
                DefaultKasaHesapAdi = txtVarsayilanKasaHesabi.Text,
                RaporlariOnayAlmadanKapat = txtRaporlariOnayAlmadanKapat.Checked,
                TableViewCaptionForeColor = txtTabloBasligiYaziRengi.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTabloBasligiSutunYaziRengi.Color.ToArgb(),
                TableBandPanelForeColor = txtTabloBandPanelYaziRengi.Color.ToArgb(),
                ArkaPlanResmi = (byte[])imgArkaPlanResmi.EditValue,
            };

            return entity;
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

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtVarsayilanAvukatHesabi)
                {
                    sec.Sec(txtVarsayilanAvukatHesabi);
                }
                else if (sender == txtVarsayilanBankaHesabi)
                {
                    sec.Sec(txtVarsayilanBankaHesabi);
                }
                else if (sender == txtVarsayilanKasaHesabi)
                {
                    sec.Sec(txtVarsayilanKasaHesabi);
                }
            }
        }

        #endregion

        #region Events

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }

        #endregion

        private void RaporlariOnayAlmadanKapat_CheckedChanged(object sender, EventArgs e)
        {
            if(txtRaporlariOnayAlmadanKapat.Checked)
            {
                txtRaporlariOnayAlmadanKapat.Text = "Evet";
            }
            else
            {
                txtRaporlariOnayAlmadanKapat.Text = "Hayır";
            }
        }
    }
}