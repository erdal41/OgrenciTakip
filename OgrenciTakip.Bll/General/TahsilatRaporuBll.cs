using OgrenciTakip.Bll.Base;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Contexts;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.Bll.General
{
    public class TahsilatRaporuBll : BaseHareketBll<MakbuzHareketleri, OgrenciTakipContext>
    {
        public IEnumerable<TahsilatRaporuList> List(Expression<Func<MakbuzHareketleri, bool>> filter)
        {
            return List(filter, x => new TahsilatRaporuList
            {

                SubeId = x.Makbuz.SubeId,
                OgrenciSubeAdi = x.OdemeBilgileri.Tahakkuk.Sube.SubeAdi,
                DonemId = x.Makbuz.DonemId,
                OgrenciNo = x.OdemeBilgileri.Tahakkuk.Kod,
                Adi = x.OdemeBilgileri.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.OdemeBilgileri.Tahakkuk.Ogrenci.Soyadi,
                KayitTarihi = x.OdemeBilgileri.Tahakkuk.KayitTarihi,
                KayitSekli = x.OdemeBilgileri.Tahakkuk.KayitSekli,
                KayitDurumu = x.OdemeBilgileri.Tahakkuk.KayitDurumu,
                IptalDurumu = x.OdemeBilgileri.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                SinifAdi = x.OdemeBilgileri.Tahakkuk.Sinif.SinifAdi,
                SinifGrupAdi = x.OdemeBilgileri.Tahakkuk.Sinif.Grup.GrupAdi,
                BelgeSubeAdi = x.Makbuz.Sube.SubeAdi,
                OdemeTuruAdi = x.OdemeBilgileri.OdemeTuru.OdemeTuruAdi,
                PortfoyNo = x.OdemeBilgileri.Id,
                GirisTarihi = x.OdemeBilgileri.GirisTarihi,
                Vade = x.OdemeBilgileri.Vade,
                HesabaGecisTarihi = x.OdemeBilgileri.HesabaGecisTarihi,
                AsilBorclu = x.OdemeBilgileri.AsilBorclu,
                Ciranta = x.OdemeBilgileri.Ciranta,
                BankaAdi = x.OdemeBilgileri.Banka.BankaAdi,
                BankaSubeAdi = x.OdemeBilgileri.BankaSube.BankaSubeAdi,
                BlokeGunSayisi = x.OdemeBilgileri.BlokeGunSayisi,
                BankaHesapAdi = x.OdemeBilgileri.BankaHesap.HesapAdi,
                HesapNo = x.OdemeBilgileri.HesapNo,
                TakipNo = x.OdemeBilgileri.TakipNo,
                BelgeNo = x.OdemeBilgileri.BelgeNo,
                Tutar = x.OdemeBilgileri.Tutar,
                IslemOncesiTutar = x.IslemOncesiTutar,
                IslemTutari = x.IslemTutari,
                Kalan = x.IslemOncesiTutar - x.IslemTutari,
                BelgeDurumu = x.BelgeDurumu,
                Aciklama = x.OdemeBilgileri.Aciklama,
                MakbuzId = x.MakbuzId,
                MakbuzNo = x.Makbuz.Kod,
                MakbuzTarihi = x.Makbuz.Tarih,
                MakbuzTuru = x.Makbuz.MakbuzTuru,
                MakbuzHesapTuru = x.Makbuz.MakbuzHesapTuru,
                IslemYeri = x.Makbuz.AvukatHesapId != null ? x.Makbuz.AvukatHesap.AdiSoyadi :
                      x.Makbuz.BankaHesap != null ? x.Makbuz.BankaHesap.HesapAdi :
                      x.Makbuz.CariHesap != null ? x.Makbuz.CariHesap.CariAdi :
                      x.Makbuz.KasaHesapId != null ? x.Makbuz.KasaHesap.KasaAdi :
                      x.Makbuz.SubeHesap.SubeAdi,
                TahsilEden = x.Kullanici.Kod,
                OzelKod1 = x.OdemeBilgileri.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.OdemeBilgileri.Tahakkuk.OzelKod2.OzelKodAdi,
                OzelKod3 = x.OdemeBilgileri.Tahakkuk.OzelKod3.OzelKodAdi,
                OzelKod4 = x.OdemeBilgileri.Tahakkuk.OzelKod4.OzelKodAdi,
                OzelKod5 = x.OdemeBilgileri.Tahakkuk.OzelKod5.OzelKodAdi,

            }).OrderBy(x => x.MakbuzTarihi).ToList();
        }
    }
}