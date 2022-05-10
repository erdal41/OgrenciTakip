using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;

namespace OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimEditForm : BaseEditForm
    {
        public IletisimEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IletisimBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            //Enum ile combobox doldurma
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            BaseKartTuru = KartTuru.Iletisim;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            // işlem turu insert ise yeni oluştur. Update ise databaseden sorgulama yap 
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IletisimSingle() : ((IletisimBll)Bll).Single(FilterFunctions.Filter<Iletisim>(Id));
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);

            //Yeni kod oluştur -- HizmetTuru için sube ve donem idleri eşitse o donem ve şubeye ait HizmetTurular gelecektir.
            txtKod.Text = ((IletisimBll)Bll).YeniKodVer();

            //txte focuslanır
            txtTcKimlikNo.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IletisimSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtEvTelefonu.Text = entity.EvTelefonu;
            txtIsTelefonu1.Text = entity.IsTelefonu1;
            txtIsTelefonu2.Text = entity.IsTelefonu2;
            txtDahili1.Text = entity.Dahili1;
            txtDahili2.Text = entity.Dahili2;
            txtCepTelefonu1.Text = entity.CepTelefonu1;
            txtCepTelefonu2.Text = entity.CepTelefonu2;
            txtWeb.Text = entity.Web;
            txtEmail.Text = entity.Email;
            txtIbanNo.Text = entity.IbanNo;
            txtKartNo.Text = entity.KartNo;
            txtEvAdresi.Text = entity.EvAdresi;
            txtEvAdresiIl.Id = entity.EvAdresiIlId;
            txtEvAdresiIl.Text = entity.EvAdresiIlAdi;
            txtEvAdresiIlce.Id = entity.EvAdresiIlceId;
            txtEvAdresiIlce.Text = entity.EvAdresiIlceAdi;
            txtIsAdresi.Text = entity.IsAdresi;
            txtIsAdresiIl.Id = entity.IsAdresiIlId;
            txtIsAdresiIl.Text = entity.IsAdresiIlAdi;
            txtIsAdresiIlce.Id = entity.IsAdresiIlceId;
            txtIsAdresiIlce.Text = entity.IsAdresiIlceAdi;
            txtMeslek.Id = entity.MeslekId;
            txtMeslek.Text = entity.MeslekAdi;
            txtIsyeri.Id = entity.IsyeriId;
            txtIsyeri.Text = entity.IsyeriAdi;
            txtGorev.Id = entity.GorevId;
            txtGorev.Text = entity.GorevAdi;
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnaAdi.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKanGrubu.Text = entity.KanGrubu.ToName();
            txtKimlikSeriNo.Text = entity.KimlikSeri;
            txtKimlikSiraNo.Text = entity.KimlikSiraNo;
            txtKimlikIl.Id = entity.KimlikIlId;
            txtKimlikIl.Text = entity.KimlikIlAdi;
            txtKimlikIlce.Id = entity.KimlikIlceId;
            txtKimlikIlce.Text = entity.KimlikIlceAdi;
            txtKimlikMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtKimlikCiltNo.Text = entity.KimlikCiltNo;
            txtKimlikAileSiraNo.Text = entity.KimlikAileSiraNo;
            txtKimlikBireySiraNo.Text = entity.KimlikBireySiraNo;
            txtKimlikVerildigiYer.Text = entity.KimlikVerildigiYer;
            txtKimlikVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKimlikKayitNo.Text = entity.KimlikKayitNo;
            txtKimlikVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = txtOzelKod2.Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Iletisim
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                EvTelefonu = txtEvTelefonu.Text,
                IsTelefonu1 = txtIsTelefonu1.Text,
                IsTelefonu2 = txtIsTelefonu2.Text,
                Dahili1 = txtDahili1.Text,
                Dahili2 = txtDahili2.Text,
                CepTelefonu1 = txtCepTelefonu1.Text,
                CepTelefonu2 = txtCepTelefonu2.Text,
                Web = txtWeb.Text,
                Email = txtEmail.Text,
                IbanNo = txtIbanNo.Text,
                KartNo = txtKartNo.Text,
                EvAdresi = txtEvAdresi.Text,
                EvAdresiIlId = txtEvAdresiIl.Id,
                EvAdresiIlceId = txtEvAdresiIlce.Id,
                IsAdresi = txtIsAdresi.Text,
                IsAdresiIlId = txtIsAdresiIl.Id,
                IsAdresiIlceId = txtIsAdresiIlce.Id,
                MeslekId = txtMeslek.Id,
                IsyeriId = txtIsyeri.Id,
                GorevId = txtGorev.Id,
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                KimlikSeri = txtKimlikSeriNo.Text,
                KimlikSiraNo = txtKimlikSiraNo.Text,
                KimlikIlId = txtKimlikIl.Id,
                KimlikIlceId = txtKimlikIlce.Id,
                KimlikMahalleKoy = txtKimlikMahalleKoy.Text,
                KimlikCiltNo = txtKimlikCiltNo.Text,
                KimlikAileSiraNo = txtKimlikAileSiraNo.Text,
                KimlikBireySiraNo = txtKimlikBireySiraNo.Text,
                KimlikVerildigiYer = txtKimlikVerildigiYer.Text,
                KimlikVerilisNedeni = txtKimlikVerilisNedeni.Text,
                KimlikKayitNo = txtKimlikKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtKimlikVerilisTarihi.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtEvAdresiIl)
                {
                    sec.Sec(txtEvAdresiIl);
                }
                else if (sender == txtEvAdresiIlce)
                {
                    sec.Sec(txtEvAdresiIlce, txtEvAdresiIl);
                }
                else if (sender == txtIsAdresiIl)
                {
                    sec.Sec(txtIsAdresiIl);
                }
                else if (sender == txtIsAdresiIlce)
                {
                    sec.Sec(txtIsAdresiIlce, txtIsAdresiIl);
                }
                else if (sender == txtMeslek)
                {
                    sec.Sec(txtMeslek);
                }
                else if (sender == txtIsyeri)
                {
                    sec.Sec(txtIsyeri);
                }
                else if (sender == txtGorev)
                {
                    sec.Sec(txtGorev);
                }
                else if (sender == txtKimlikIl)
                {
                    sec.Sec(txtKimlikIl);
                }
                else if (sender == txtKimlikIlce)
                {
                    sec.Sec(txtKimlikIlce, txtKimlikIl);
                }
                else if (sender == txtOzelKod1)
                {
                    sec.Sec(txtOzelKod1, KartTuru.Iletisim);
                }
                else if (sender == txtOzelKod2)
                {
                    sec.Sec(txtOzelKod2, KartTuru.Iletisim);
                }
            }
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtEvAdresiIl && sender != txtIsAdresiIl && sender != txtKimlikIl) return;

            if (sender == txtEvAdresiIl)
            {
                txtEvAdresiIl.ControlEnabledChange(txtEvAdresiIlce);
            }
            else if (sender == txtIsAdresiIl)
            {
                txtIsAdresiIl.ControlEnabledChange(txtIsAdresiIlce);
            }
            else if (sender == txtKimlikIl)
            {
                txtKimlikIl.ControlEnabledChange(txtKimlikIlce);
            }
        }
    }
}