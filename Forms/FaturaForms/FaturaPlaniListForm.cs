using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.GenelForms;
using OgrenciTakip.UI.Win.Show;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class FaturaPlaniListForm : BaseListForm
    {
        public FaturaPlaniListForm()
        {
            InitializeComponent();
            Bll = new TahakkukBll();
            HideItems = new BarItem[] { btnYeni, barYeni, barYeniAciklama, barSil, barSilAciklama, btnAktifPasifKartlar };
            ShowItems = new BarItem[] { btnTahakkukYap };
            btnSil.Caption = "Fatura Planını İptal Et";
            btnTahakkukYap.Caption = "Toplu Fatura Planı";
            btnYazdir.CreateDropDownMenu(new BarItem[] { btnTabloYazdir });
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Fatura;
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TahakkukBll)Bll).FaturaTahakkukList(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
        protected override void ShowEditForm(long id)
        {
            var entity = view.GetRow<FaturaList>();
            if (entity == null) return;

            if (entity.HizmetNetTutar == 0)
            {
                Messages.HataMesaji("Öğrencinin net ücreti sıfır(0) olduğu için fatura planı oluşturamazsınız.");
                return;
            }

            var result = ShowEditForms<FaturaPlaniEditForm>.ShowDialogEditForm(KartTuru.Fatura, id, null);
            ShowEditFormDefault(result);
        }

        protected override void TahakkukYap()
        {
            var source = new List<FaturaList>();
            for (int i = 0; i < view.DataRowCount; i++)
            {
                source.Add(view.GetRow<FaturaList>(i));
            }

            if (source.Count == 0) return;

            if (ShowEditForms<TopluFaturaPlaniEditForm>.ShowDialogEditForm(KartTuru.Fatura, source))
            {
                Listele();
            }
        }

        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Seçilen öğrencilere ait hareket görmeyen tüm fatura planları iptal edilecektir. Onaylıyor musunuz?", "İptal Onay") != DialogResult.Yes) return;

            var source = new List<FaturaList>();
            for (int i = 0; i < view.DataRowCount; i++)
            {
                source.Add(view.GetRow<FaturaList>(i));
            }
            
            if (source.Count == 0) return;

            using (var bll = new FaturaBll())
            {
                var position = 0.0;
                progressBarControl.Visible = true;
                progressBarControl.Left = (ClientSize.Width - progressBarControl.Width) / 2;
                progressBarControl.Top = (ClientSize.Height - progressBarControl.Height) / 2;

                source.ForEach(x =>
                {
                    var yuzde = 100.0 / source.Count;
                    position += yuzde;

                    var planSource = bll.List(y => y.TahakkukId == x.Id).Where(y => ((FaturaPlaniList)y).TahakkukTarih == null).ToList();
                    bll.Delete(planSource);

                    progressBarControl.Position = (int)position;
                    progressBarControl.Update();
                });
            }

            progressBarControl.Visible = false;
            Messages.BilgiMesaji("Seçilen öğrencilere ait fatura planları başarılı bir şekilde iptal edilmiştir.");
            Listele();
        }

        protected override void Yazdir()
        {
            var source = new List<FaturaRapor>();

            using (var bll = new FaturaBll())
            {
                for (int i = 0; i < view.DataRowCount; i++)
                {
                    var entity = view.GetRow<FaturaList>(i);
                    if (entity == null) return;

                    var list = bll.FaturaTahakkukList(x => x.TahakkukId == entity.Id).Cast<FaturaPlaniList>();

                    list.ForEach(x =>
                    {
                        var row = new FaturaRapor
                        {
                            TahakkukId = x.TahakkukId,
                            OkulNo = x.OkulNo,
                            TcKimlikNo = x.TcKimlikNo,
                            Adi = x.Adi,
                            Soyadi = x.Soyadi,
                            SinifAdi = x.SinifAdi,
                            VeliTcKimlikNo = x.VeliTcKimlikNo,
                            VeliAdi = x.VeliAdi,
                            VeliSoyadi = x.VeliSoyadi,
                            VeliYakinlikAdi = x.VeliYakinlikAdi,
                            VeliMeslekAdi = x.VeliMeslekAdi,
                            FaturaAdresi = x.FaturaAdresi,
                            FaturaAdresIlAdi = x.FaturaAdresIlAdi,
                            FaturaAdresIlceAdi = x.FaturaAdresIlceAdi,
                            Aciklama = x.Aciklama,
                            Tarih = x.TahakkukTarih,
                            FaturaNo = x.FaturaNo,
                            Tutar = x.TahakkukTutari,
                            Indirim = x.TahakkukIndirimTutari,
                            NetTutar = x.TahakkukNetTutar,
                            KdvSekli = x.KdvSekli,
                            KdvOrani = x.KdvOrani,
                            KdvHaricTutar = x.KdvHaricTutar,
                            KdvTutari = x.KdvTutari,
                            ToplamTutar = x.ToplamTutar,
                            TutarYazi = x.ToplamTutarYazi,
                            PlanTutar = entity.PlanTutari,
                            PlanIndirim = entity.PlanIndirimTutari,
                            PlanNetTutar = entity.PlanNetTutar,
                            Sube = x.Sube,
                            Donem = x.Donem
                        };

                        source.Add(row);
                    });
                }
            }
            ShowListForms<RaporSecim>.ShowDialogListForm(KartTuru.Rapor, false, RaporBolumTuru.FaturaGenelRaporlari, source);
        }

        #endregion
    }
}