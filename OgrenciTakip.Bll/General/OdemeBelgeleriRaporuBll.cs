﻿using OgrenciTakip.Bll.Base;
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
    public class OdemeBelgeleriRaporuBll : BaseHareketBll<OdemeBilgileri, OgrenciTakipContext>
    {
        public IEnumerable<OdemeBelgeleriRaporuList> List(Expression<Func<OdemeBilgileri, bool>> filter, IEnumerable<BelgeDurumu> belgeDurumlari)
        {
            return List(filter, x => new
            {
                Odeme = x,
                Toplamlar = x.MakbuzHareketleri.GroupBy(y => y.OdemeBilgileriId).DefaultIfEmpty().Select(y => new
                {
                    Tahsil = y.Where(c => c.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BlokeCozumu || c.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || c.BelgeDurumu == BelgeDurumu.MahsupEtme || c.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || c.BelgeDurumu == BelgeDurumu.TahsilEtmeKasa || c.BelgeDurumu == BelgeDurumu.TahsilEtmeBanka).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),
                    Iade = y.Where(c => c.BelgeDurumu == BelgeDurumu.MusteriyeGeriIade).Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum(),
                    Tahsilde = y.Where(c => c.BelgeDurumu == BelgeDurumu.AvukataGonderme || c.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme || c.BelgeDurumu == BelgeDurumu.CiroEtme || c.BelgeDurumu == BelgeDurumu.BlokeAlma)
                    .Select(c => c.IslemTutari).DefaultIfEmpty(0).Sum() -
                    x.MakbuzHareketleri
                    .Where(c => c.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || c.BelgeDurumu == BelgeDurumu.BlokeCozumu || c.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme
                    || c.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || c.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || c.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade)
                    .Select(c => c.IslemTutari)
                    .DefaultIfEmpty(0).Sum(),
                    BelgeDurumu = y.Any() ? y.OrderByDescending(z => z.Id).FirstOrDefault().BelgeDurumu : BelgeDurumu.Portfoyde,
                    BelgeSubeAdi = y.Any() ? y.OrderByDescending(z => z.Id).FirstOrDefault().EskiSube.SubeAdi : x.Tahakkuk.Sube.SubeAdi,
                    SonHareketTarihi = (DateTime?)y.OrderByDescending(z => z.Id).FirstOrDefault().Makbuz.Tarih,
                    SonIslemYeri = y.OrderByDescending(z => z.Id).Select(z => z.Makbuz.AvukatHesapId != null ? z.Makbuz.AvukatHesap.AdiSoyadi : z.Makbuz.BankaHesap != null ? z.Makbuz.BankaHesap.HesapAdi :
                      z.Makbuz.CariHesap != null ? z.Makbuz.CariHesap.CariAdi :
                      z.Makbuz.KasaHesapId != null ? z.Makbuz.KasaHesap.KasaAdi :
                      z.Makbuz.SubeHesap.SubeAdi).FirstOrDefault(),

                }).FirstOrDefault(),




                //AsEnumerable() Aşağıdaki gibi birden çok select durumunda sorguları hızlandırır
            }).Select(x => new OdemeBelgeleriRaporuList
            {
                TahakkukId = x.Odeme.TahakkukId,
                SubeId = x.Odeme.Tahakkuk.SubeId,
                OgrenciSubeAdi = x.Odeme.Tahakkuk.Sube.SubeAdi,
                DonemId = x.Odeme.Tahakkuk.DonemId,
                OgrenciNo = x.Odeme.Tahakkuk.Kod,
                Adi = x.Odeme.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Odeme.Tahakkuk.Ogrenci.Soyadi,
                KayitTarihi = x.Odeme.Tahakkuk.KayitTarihi,
                KayitSekli = x.Odeme.Tahakkuk.KayitSekli,
                KayitDurumu = x.Odeme.Tahakkuk.KayitDurumu,
                IptalDurumu = x.Odeme.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                SinifAdi = x.Odeme.Tahakkuk.Sinif.SinifAdi,
                SinifGrupAdi = x.Odeme.Tahakkuk.Sinif.Grup.GrupAdi,
                BelgeSubeAdi = x.Toplamlar.BelgeSubeAdi,
                OdemeTuruAdi = x.Odeme.OdemeTuru.OdemeTuruAdi,
                PortfoyNo = x.Odeme.Id,
                GirisTarihi = x.Odeme.GirisTarihi,
                Vade = x.Odeme.Vade,
                HesabaGecisTarihi = x.Odeme.HesabaGecisTarihi,
                AsilBorclu = x.Odeme.AsilBorclu,
                Ciranta = x.Odeme.Ciranta,
                BankaAdi = x.Odeme.Banka.BankaAdi,
                BankaSubeAdi = x.Odeme.BankaSube.BankaSubeAdi,
                BlokeGunSayisi = x.Odeme.BlokeGunSayisi,
                BankaHesapAdi = x.Odeme.BankaHesap.HesapAdi,
                HesapNo = x.Odeme.HesapNo,
                TakipNo = x.Odeme.TakipNo,
                BelgeNo = x.Odeme.BelgeNo,
                Tutar = x.Odeme.Tutar,
                Iade = x.Toplamlar.Iade,
                NetTutar = x.Odeme.Tutar - x.Toplamlar.Iade,
                Tahsil = x.Toplamlar.Tahsil,
                Tahsilde = x.Toplamlar.Tahsilde,
                Kalan = x.Odeme.Tutar - (x.Toplamlar.Tahsil + x.Toplamlar.Iade),
                BelgeDurumu = x.Toplamlar.BelgeDurumu,
                SonHareketTarihi = x.Toplamlar.SonHareketTarihi,
                SonIslemYeri = x.Toplamlar.SonIslemYeri,
                Aciklama = x.Odeme.Aciklama,
                OzelKod1 = x.Odeme.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.Odeme.Tahakkuk.OzelKod2.OzelKodAdi,
                OzelKod3 = x.Odeme.Tahakkuk.OzelKod3.OzelKodAdi,
                OzelKod4 = x.Odeme.Tahakkuk.OzelKod4.OzelKodAdi,
                OzelKod5 = x.Odeme.Tahakkuk.OzelKod5.OzelKodAdi,

            }).Where(x => belgeDurumlari.Contains(x.BelgeDurumu)).OrderBy(x => x.PortfoyNo).ToList();
        }
    }
}