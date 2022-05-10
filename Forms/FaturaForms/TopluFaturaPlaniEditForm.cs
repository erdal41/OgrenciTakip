using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraLayout.Utils;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using OgrenciTakip.UI.Win.GenelForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Forms.FaturaForms
{
    public partial class TopluFaturaPlaniEditForm : BaseEditForm
    {
        #region Variables

        private readonly IList<FaturaAlinanHizmetlerList> _alinanHizmetlerSource;
        private readonly IList _faturaPlaniSource;
        private readonly IList<FaturaList> _faturaPlaniKartlari;

        #endregion

        public TopluFaturaPlaniEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni, btnKaydet, btnFarkliKaydet, btnGerial, btnSil, btnUygula };
            ShowItems = new BarItem[] { btnTaksitOlustur };

            txtOzetTahakkuk.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtAyBilgisi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
        }

        public TopluFaturaPlaniEditForm(params object[] prm) : this()
        {
            if (prm.Length == 1)
            {
                _faturaPlaniKartlari = (IList<FaturaList>)prm[0];
            }
            else
            {
                _alinanHizmetlerSource = (IList<FaturaAlinanHizmetlerList>)prm[0];
                _faturaPlaniSource = (IList)prm[1];
            }
        }

        #region Functions

        public override void Yukle()
        {
            btnTaksitOlustur.Caption = "Plan Oluştur";
            txtIlkFaturaTarihi.DateTime = DateTime.Now.Date;
            txtSabitTutar.Value = 0;
            txtOzetTahakkuk.SelectedItem = EvetHayir.Hayir.ToName();
            txtAyBilgisi.SelectedItem = EvetHayir.Hayir.ToName();

            if (_faturaPlaniKartlari != null)
            {
                MinimumSize = new Size(487, 280);
            }
            else
            {
                layoutControlProgress.Visibility = LayoutVisibility.Never;
                Root.OptionsTableLayoutGroup.RowDefinitions.RemoveAt(4);
                Root.Update();
                MaximumSize = new Size(487, 250);
            }
        }

        private static string AlinanHizmetler(IList<string> hizmetlerSource)
        {
            var alinanHizmetler = "";

            for (int i = 0; i < hizmetlerSource.Count; i++)
            {
                alinanHizmetler += hizmetlerSource[i];

                if (i + 1 < hizmetlerSource.Count)
                {
                    alinanHizmetler += ", ";
                }
            }
            return alinanHizmetler;
        }

        protected override void TaksitOlustur()
        {
            //toplu fatura oluşturma
            if (_faturaPlaniKartlari != null)
            {
                TopluFaturaPlani();
                return;
            }


            //tek tek fatura oluşturma
            var tahakkukId = _alinanHizmetlerSource.Select(x => x.TahakkukId).First();
            var alinanHizmetler = _alinanHizmetlerSource.Select(x => x.HizmetAdi).ToList();
            var hizmetlerToplami = _alinanHizmetlerSource.Sum(x => x.BrutUcret);
            var indirimlerToplami = _alinanHizmetlerSource.Sum(x => x.Indirim);

            var ilkFaturaTarihi = txtIlkFaturaTarihi.DateTime.Date;
            var faturaAdet = (int)txtAdet.Value;
            var sabitTutar = txtSabitTutar.Value;
            var ozetTahakkuk = txtOzetTahakkuk.Text.GetEnum<EvetHayir>();
            var ozetAciklama = txtOzetTahakkukAciklama.Text;

            var girilenBrutTutarToplami = _faturaPlaniSource.Cast<FaturaPlaniList>().Where(x => !x.Delete).Sum(x => x.PlanTutari);
            var girilenIndirimTutarToplami = _faturaPlaniSource.Cast<FaturaPlaniList>().Where(x => !x.Delete).Sum(x => x.PlanIndirimTutari);

            var girilecekBrutTutar = sabitTutar > 0 ? sabitTutar : Math.Round((hizmetlerToplami - girilenBrutTutarToplami) / faturaAdet, AnaForm.DonemParametreleri.FaturaTahakkukKurusKullan ? 2 : 0);
            var girilecekIndirimTutar = sabitTutar > 0 ? 0 : Math.Round((indirimlerToplami - girilenIndirimTutarToplami) / faturaAdet, AnaForm.DonemParametreleri.FaturaTahakkukKurusKullan ? 2 : 0);
            var girilecekNetTutar = girilecekBrutTutar - girilecekIndirimTutar;

            if (girilecekBrutTutar <= 0)
            {
                Messages.UyariMesaji("Verilen hizmetler toplamı kadar fatura planı zaten oluşturulmuş.");
                return;
            }

            for (int i = 0; i < faturaAdet; i++)
            {
                var row = new FaturaPlaniList
                {
                    TahakkukId = tahakkukId,
                    Aciklama = ozetTahakkuk == EvetHayir.Evet ? ozetAciklama : AlinanHizmetler(alinanHizmetler) + " Bedeli",
                    PlanTarih = ilkFaturaTarihi.AddMonths(i),
                    PlanTutari = girilecekBrutTutar,
                    PlanIndirimTutari = girilecekIndirimTutar,
                    PlanNetTutar = girilecekNetTutar,
                    Insert = true,
                };

                if (txtOzetTahakkuk.Text.GetEnum<EvetHayir>() == EvetHayir.Evet)
                {
                    row.Aciklama = ozetAciklama;
                }

                if (txtAyBilgisi.Text.GetEnum<EvetHayir>() == EvetHayir.Evet)
                {
                    var ay = (Aylar)row.PlanTarih.Month;
                    row.Aciklama = ay.ToName() + "-" + row.PlanTarih.Year + " Ayı " + row.Aciklama;
                }

                if (i + 1 == faturaAdet && sabitTutar == 0)
                {
                    row.PlanTutari = hizmetlerToplami - _faturaPlaniSource.Cast<FaturaPlaniList>().Where(x => !x.Delete).Sum(x => x.PlanTutari);
                    row.PlanIndirimTutari = indirimlerToplami - _faturaPlaniSource.Cast<FaturaPlaniList>().Where(x => !x.Delete).Sum(x => x.PlanIndirimTutari);
                    row.PlanNetTutar = row.PlanTutari - row.PlanIndirimTutari;
                }

                _faturaPlaniSource.Add(row);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void TopluFaturaPlani()
        {
            if (Messages.HayirSeciliEvetHayir("Toplu fatura planı oluşturulacaktır. Onaylıyor musunuz?", "Onay") != DialogResult.Yes) return;

            var ilkFaturaTarihi = txtIlkFaturaTarihi.DateTime.Date;
            var faturaAdet = (int)txtAdet.Value;
            var sabitTutar = txtSabitTutar.Value;
            var ozetTahakkuk = txtOzetTahakkuk.Text.GetEnum<EvetHayir>();
            var ozetAciklama = txtOzetTahakkukAciklama.Text;
            var position = 0.0;

            using (var faturaBll = new FaturaBll())
            {
                using (var hizmetBilgileriBll = new HizmetBilgileriBll())
                {
                    _faturaPlaniKartlari.ForEach(x =>
                    {
                        var yuzde = 100.0 / _faturaPlaniKartlari.Count;
                        position += yuzde;

                        var hizmetTutar = x.HizmetTutari;
                        var hizmetIndirimTutari = x.HizmetIndirimTutari;
                        var planTutari = x.PlanTutari;
                        var planIndirimTutari = x.PlanIndirimTutari;
                        var alinanHizmetler = AlinanHizmetler(hizmetBilgileriBll.FaturaPlaniList(y => y.TahakkukId == x.Id).Select(y => y.HizmetAdi).ToList());

                        var girilecekBrutTutar = sabitTutar > 0 ? sabitTutar : Math.Round((hizmetTutar - planTutari) / faturaAdet, AnaForm.DonemParametreleri.FaturaTahakkukKurusKullan ? 2 : 0);
                        var girilecekIndirimTutar = sabitTutar > 0 ? 0 : Math.Round((hizmetIndirimTutari - planIndirimTutari) / faturaAdet, AnaForm.DonemParametreleri.FaturaTahakkukKurusKullan ? 2 : 0);
                        var girilecekNetTutar = girilecekBrutTutar - girilecekIndirimTutar;

                        if (hizmetTutar == 0 || hizmetTutar == planTutari && hizmetIndirimTutari == planIndirimTutari)
                        {
                            progressBarControl.Position = 100;
                            return;
                        }

                        for (int i = 0; i < faturaAdet; i++)
                        {
                            var row = new FaturaPlaniList
                            {
                                TahakkukId = x.Id,
                                Aciklama = ozetTahakkuk == EvetHayir.Evet ? ozetAciklama : alinanHizmetler + " Bedeli",
                                PlanTarih = ilkFaturaTarihi.AddMonths(i),
                                PlanTutari = girilecekBrutTutar,
                                PlanIndirimTutari = girilecekIndirimTutar,
                                PlanNetTutar = girilecekNetTutar,
                                Insert = true,
                            };

                            if (txtOzetTahakkuk.Text.GetEnum<EvetHayir>() == EvetHayir.Evet)
                            {
                                row.Aciklama = ozetAciklama;
                            }

                            if (txtAyBilgisi.Text.GetEnum<EvetHayir>() == EvetHayir.Evet)
                            {
                                var ay = (Aylar)row.PlanTarih.Month;
                                row.Aciklama = ay.ToName() + "-" + row.PlanTarih.Year + " Ayı " + row.Aciklama;
                            }

                            if (i + 1 == faturaAdet && sabitTutar == 0)
                            {
                                row.PlanTutari = (hizmetTutar - planTutari) - (girilecekBrutTutar * i);
                                row.PlanIndirimTutari = (hizmetIndirimTutari - planIndirimTutari) - (girilecekIndirimTutar * i);
                                row.PlanNetTutar = row.PlanTutari - row.PlanIndirimTutari;
                            }

                            if (!faturaBll.InsertSingle(row)) return;
                            progressBarControl.Position = (int)position;
                            progressBarControl.Update();
                        }
                    });
                }
            }
            Messages.BilgiMesaji("Fatura planı oluşturma işlemi başarılı bir şekilde tamamlanmıştır. ");
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion

        #region Events

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtOzetTahakkuk) return;
            txtOzetTahakkukAciklama.Enabled = txtOzetTahakkuk.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
            txtOzetTahakkukAciklama.Focus();
        }

        #endregion
    }
}