using DevExpress.XtraBars;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaPlaniEditForm : BaseEditForm
    {
        public FaturaPlaniEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            BaseKartTuru = KartTuru.Fatura;    //Kartturu form isimleri için
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            btnSil.Caption = "İptal Et";
        }

        public override void Yukle()
        {
            TabloYukle();

            using (var bll = new HizmetBilgileriBll())
            {
                var list = bll.FaturaPlaniList(x => x.TahakkukId == Id).ToList();

                txtOkulNo.Text = list[0].OkulNo;
                txtAdi.Text = list[0].Adi;
                txtSoyadi.Text = list[0].Soyadi;
                txtSinifAdi.Text = list[0].SinifAdi;
                txtVeliAdi.Text = list[0].VeliAdi;
                txtVeliSoyadi.Text = list[0].VeliSoyadi;
                txtYakinlik.Text = list[0].VeliYakinlikAdi;
                txtMeslek.Text = list[0].VeliMeslekAdi;

                view.GridControl.DataSource = list;
            }
        }

        protected internal override void ButtonEnabledDurumu()
        {
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnGerial, faturaPlaniTable.TableValueChanged);
        }

        protected override void TabloYukle()
        {
            faturaPlaniTable.OwnerForm = this;
            faturaPlaniTable.Yukle();
        }

        protected override bool EntityInsert()
        {
            return faturaPlaniTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            return faturaPlaniTable.Kaydet();
        }

        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Fatura planı iptal edilecek. Onaylıyor musunuz?", "İptal Onayı") != DialogResult.Yes) return;

            var source = faturaPlaniTable.Tablo.DataController.ListSource.Cast<FaturaPlaniList>().Where(x => x.TahakkukTarih == null).ToList();

            if (source.Count == 0) return;

            source.ForEach(x => x.Delete = true);
            faturaPlaniTable.Tablo.RefreshDataSource();
            faturaPlaniTable.TableValueChanged = true;
            ButtonEnabledDurumu();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            faturaPlaniTable.Tablo.Focus();
        }
    }
}