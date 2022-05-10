using DevExpress.XtraBars;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Functions;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class RolYetkiKartlariListForm : BaseListForm
    {
        public RolYetkiKartlariListForm()
        {
            InitializeComponent();
            HideItems = new BarItem[] {

                btnYeni, barYeni, barYeniAciklama,
                btnSil, barSil, barSilAciklama,
                btnDuzelt, barDuzenle, barDuzenleAciklama,
                btnKolonlar, barKolonlar, barKolonlarAciklama,
            };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;

            //filtreleme için kullandık
            BaseKartTuru = KartTuru.Yetki;
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            //enum tanımlı KartTuru listesini çekmek için kullandık.
            var enumList = Enum.GetValues(typeof(KartTuru)).Cast<KartTuru>().ToList();
            var liste = new List<RolYetki>();

            enumList.ForEach(x =>
            {
                var entity = new RolYetki
                {
                    KartTuru = x,
                };

                liste.Add(entity);
            });

            var list = liste.Where(x => !ListeDisiTutulacakKayitlar.Contains((long)x.KartTuru)).OrderBy(x => x.KartTuru.ToName());
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())  //list te değer veya kayıt var ise
            {
                EklenebilecekEntityVar = true;
            }
            else
            {
                Messages.KartBulunamadiMesaji("Kart");
            }
        }
    }
}