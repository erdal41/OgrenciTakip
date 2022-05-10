using DevExpress.XtraBars;
using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.General;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.KullaniciForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System;
using System.Linq;

namespace OgrenciTakip.UI.Win.UserControls.UserControl.GenelEditFormTable
{
    public partial class RolYetkileriTable : BaseTablo
    {
        public RolYetkileriTable()
        {
            InitializeComponent();
            Bll = new RolYetkileriBll();
            Tablo = view;
            ShowItems = new BarItem[] { btnTumunuSec, btnTumSecimleriKaldir };
            EventsLoad();
        }

        #region Functions

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            view.GridControl.DataSource = ((RolYetkileriBll)Bll).List(x => x.RolId == OwnerForm.Id).ToBindingList<RolYetkileriList>();
        }
        protected override void HareketEkle()
        {
            byte CheckBoxValue(KartTuru kartTuru)
            {
                //Eğer giden kartturu 2 olarak dönerse o kart için işlem yapılamaz yani ekleme, değiştirme ve silme işlemi o kartta mevcut değildir.
                if (kartTuru == KartTuru.AylikKayitRaporu ||
                    kartTuru == KartTuru.OdemesiGecikenAlacaklarRaporu ||
                    kartTuru == KartTuru.GelirDagilimRaporu ||
                    kartTuru == KartTuru.GenelAmacliRapor ||
                    kartTuru == KartTuru.HizmetAlimRaporu ||
                    kartTuru == KartTuru.IndirimDagilimRaporu ||
                    kartTuru == KartTuru.MesleklereGoreKayitRaporu ||
                    kartTuru == KartTuru.NetUcretRaporu ||
                    kartTuru == KartTuru.OdemeBelgeleriRaporu ||
                    kartTuru == KartTuru.SinifRaporlari ||
                    kartTuru == KartTuru.TahsilatRaporu ||
                    kartTuru == KartTuru.UcretOrtalamalariRaporu ||
                    kartTuru == KartTuru.UcretVeOdemeRaporu ||
                    kartTuru == KartTuru.BankaOdemePlaniRaporu ||
                    kartTuru == KartTuru.IndirimDilekcesiRaporu ||
                    kartTuru == KartTuru.KayitSozlesmesiRaporu ||
                    kartTuru == KartTuru.KrediKartliOdemeTalimatiRaporu ||
                    kartTuru == KartTuru.KullaniciTanimliRapor ||
                    kartTuru == KartTuru.MebKayitSozlesmesiRaporu ||
                    kartTuru == KartTuru.OdemeSenediRaporu ||
                    kartTuru == KartTuru.OgrenciKartiRaporu ||
                    kartTuru == KartTuru.BelgeSecim ||
                    kartTuru == KartTuru.RaporTasarim ||
                    kartTuru == KartTuru.BelgeHareketleri ||
                    kartTuru == KartTuru.FaturaDonemIcmalRaporu ||
                    kartTuru == KartTuru.FaturaOgrenciIcmalRaporu ||
                    kartTuru == KartTuru.FaturaRaporu)
                {
                    return 2;
                }

                //Giden kartturu 0 olarak giderse checkbox seçilmeden gelir.
                return 0;
            }

            var source = view.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<RolYetkileriList>().Where(x => !x.Delete).Select(x => (long)x.KartTuru).ToList();

            var entities = ShowListForms<RolYetkiKartlariListForm>.ShowDialogListForm(ListeDisiTutulacakKayitlar, true).EntityListConvert<RolYetki>();
            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new RolYetkileriList
                {
                    RolId = OwnerForm.Id,
                    KartTuru = entity.KartTuru,
                    Ekleyebilir = CheckBoxValue(entity.KartTuru),
                    Degistirebilir = CheckBoxValue(entity.KartTuru),
                    Silebilir = CheckBoxValue(entity.KartTuru),
                    Insert = true,                    
                };

                source.Add(row);
            }


            //AŞAĞIDAKİ AÇIKLAMA SADECE ÇOK BÜYÜK PROJELERDE GEÇERLİDİR.
            //Burada ekleme yaparken daha çok tablolu programlarda farklı ve "string" bir şekilde yetki kaydetme yapabiliriz. Şöyle ki:
            //"45=1,1,0,0;47=1,0,1,0;65=0,0,0,0"(tırnak içindeki veriler stringtir. Select yaparken split ile bölerek okuruz.) gibi sadece bir satırlık ve sutunluk kayıt ekleme şablonu yaparsak; programın bu string ifadeyi denetlemesi daha hızlı olacaktır.


            view.Focus();
            view.RefreshDataSource();
            view.FocusedRowHandle = view.DataRowCount - 1;

            ButtonEnabledDurumu(true);
        }

        protected override void RowCellAllowEdit()
        {
            if (view.DataRowCount == 0) return;

            var entity = view.GetRow<RolYetkileriList>();
            if (entity == null) return;

            colEkleyebilir.OptionsColumn.AllowEdit = entity.Ekleyebilir != 2;
            colDegistirebilir.OptionsColumn.AllowEdit = entity.Degistirebilir != 2;
            colSilebilir.OptionsColumn.AllowEdit = entity.Silebilir != 2;
        }

        protected override void TumunuSec()
        {
            var source = view.DataController.ListSource.Cast<RolYetkileriList>().ToList();

            for (int i = 0; i < source.Count; i++)
            {
                if (view.FocusedColumn == colGorebilir && source[i].Gorebilir == 0)
                {
                    source[i].Gorebilir = 1;
                }
                else if (view.FocusedColumn == colEkleyebilir && source[i].Ekleyebilir == 0)
                {
                    source[i].Ekleyebilir = 1;
                }
                else if (view.FocusedColumn == colDegistirebilir && source[i].Degistirebilir == 0)
                {
                    source[i].Degistirebilir = 1;
                }
                else if (view.FocusedColumn == colSilebilir && source[i].Silebilir == 0)
                {
                    source[i].Silebilir = 1;
                }
                else if (view.FocusedColumn == colKartTuru)
                {
                    if (source[i].Gorebilir == 0)
                    {
                        source[i].Gorebilir = 1;
                    }
                    if (source[i].Ekleyebilir == 0)
                    {
                        source[i].Ekleyebilir = 1;
                    }
                    if (source[i].Degistirebilir == 0)
                    {
                        source[i].Degistirebilir = 1;
                    }
                    if (source[i].Silebilir == 0)
                    {
                        source[i].Silebilir = 1;
                    }
                }

                if (!source[i].Insert)
                {
                    source[i].Update = true;
                }

                view.RefreshRow(i);
            }

            ButtonEnabledDurumu(true);
        }

        protected override void TumSecimleriKaldir()
        {
            var source = view.DataController.ListSource.Cast<RolYetkileriList>().ToList();

            for (int i = 0; i < source.Count; i++)
            {
                if (view.FocusedColumn == colGorebilir && source[i].Gorebilir == 1)
                {
                    source[i].Gorebilir = 0;
                }
                else if (view.FocusedColumn == colEkleyebilir && source[i].Ekleyebilir == 1)
                {
                    source[i].Ekleyebilir = 0;
                }
                else if (view.FocusedColumn == colDegistirebilir && source[i].Degistirebilir == 1)
                {
                    source[i].Degistirebilir = 0;
                }
                else if (view.FocusedColumn == colSilebilir && source[i].Silebilir == 1)
                {
                    source[i].Silebilir = 0;
                }
                else if (view.FocusedColumn == colKartTuru)
                {
                    if (source[i].Gorebilir == 1)
                    {
                        source[i].Gorebilir = 0;
                    }
                    if (source[i].Ekleyebilir == 1)
                    {
                        source[i].Ekleyebilir = 0;
                    }
                    if (source[i].Degistirebilir == 1)
                    {
                        source[i].Degistirebilir = 0;
                    }
                    if (source[i].Silebilir == 1)
                    {
                        source[i].Silebilir = 0;
                    }
                }

                if (!source[i].Insert)
                {
                    source[i].Update = true;
                }

                view.RefreshRow(i);
            }

            ButtonEnabledDurumu(true);
        }

        #endregion

        #region Events

        //her checkedit'e tıklandığında işlem yapar
        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            //her checkedit'e tıklandığında kaydetme işlemi yapar. Dolayısyla navigatordaki end edit de işlem sonu yani kaydetmedir.
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        #endregion
    }
}