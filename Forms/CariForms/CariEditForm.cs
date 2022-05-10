using DevExpress.XtraEditors;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;

namespace OgrenciTakip.UI.Win.Forms.CariForms
{
    public partial class CariEditForm : BaseEditForm
    {
        public CariEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new CariBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Cari;    //Kartturu form isimleri için
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CariSingle() : ((CariBll)Bll).Single(FilterFunctions.Filter<Cari>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariBll)Bll).YeniKodVer();
            txtCariAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtCariAdi.Text = entity.CariAdi;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtTelefon1.Text = entity.Telefon1;
            txtTelefon2.Text = entity.Telefon2;
            txtTelefon3.Text = entity.Telefon3;
            txtTelefon4.Text = entity.Telefon4;
            txtFax.Text = entity.Fax;
            txtWeb.Text = entity.Web;
            txtEmail.Text = entity.Email;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtVergiNo.Text = entity.VergiNo;
            txtAdres.Text = entity.Adres;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Cari
            {
                Id = Id,
                Kod = txtKod.Text,
                CariAdi = txtCariAdi.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Telefon1 = txtTelefon1.Text,
                Telefon2 = txtTelefon2.Text,
                Telefon3 = txtTelefon3.Text,
                Telefon4 = txtTelefon4.Text,
                Fax = txtFax.Text,
                Web = txtWeb.Text,
                Email = txtEmail.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text,
                Adres = txtAdres.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((CariBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod);
        }

        protected override bool EntityUpdate()
        {
            return ((CariBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOzelKod1)
                {
                    sec.Sec(txtOzelKod1, KartTuru.Cari);
                }
                else if (sender == txtOzelKod2)
                {
                    sec.Sec(txtOzelKod2, KartTuru.Cari);
                }
            }
        }
    }
}