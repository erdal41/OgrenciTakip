﻿using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Contexts;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.Bll.General
{
    public class BelgeSecimBll : BaseHareketBll<OdemeBilgileri, OgrenciTakipContext>
    {
        public IEnumerable<BaseEntity> List(Expression<Func<OdemeBilgileri, bool>> filter, MakbuzTuru makbuzTuru, MakbuzHesapTuru makbuzHesapTuru, OdemeTipi odemeTipi, long? hesapId, long subeId)
        {
            //Anonim Tip
            return List(filter, x => new
            {

                OdemeBilgileri = x,
                x.Tahakkuk,

                //toplam alınırken ve bu toplam için gruplama yaparken null gelme olasılığı yüzünden hata verecektir. Bu yüzden DefaultIfEmpty() fonksiyonunu kullanarak null olan değeri sıfır yaparak hata durumunu yok eder.
                Toplamlar = x.MakbuzHareketleri.GroupBy(y => y.OdemeBilgileriId).DefaultIfEmpty().Select(y => new
                {
                   
                    Tahsil = y.Where(z => z.BelgeDurumu == BelgeDurumu.AvukatYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.BankaYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.BlokeCozumu || z.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || z.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || z.BelgeDurumu == BelgeDurumu.MahsupEtme || z.BelgeDurumu == BelgeDurumu.OdenmisOlarakIsaretleme || z.BelgeDurumu == BelgeDurumu.TahsilEtmeBanka || z.BelgeDurumu == BelgeDurumu.TahsilEtmeKasa).Select(z => z.IslemTutari).DefaultIfEmpty(0).Sum(),
                    Iade = y.Where(z => z.BelgeDurumu == BelgeDurumu.MusteriyeGeriIade).Select(z => z.IslemTutari).DefaultIfEmpty(0).Sum(),
                    BelgeDurumu = y.Any() ? y.OrderByDescending(z => z.Id).FirstOrDefault().BelgeDurumu : BelgeDurumu.Portfoyde,
                    SonHareketId = (int?)y.Max(z => z.Id),
                    SonHareketTarihi = (DateTime?)y.OrderByDescending(z => z.Id).FirstOrDefault().Makbuz.Tarih,
                    SonHesapId = y.OrderByDescending(z => z.Id).Select(z => z.Makbuz.AvukatHesapId ?? z.Makbuz.BankaHesapId ?? z.Makbuz.CariHesapId ?? z.Makbuz.KasaHesapId ?? z.Makbuz.SubeHesapId).FirstOrDefault(),
                    MakbuzHesapTuru = y.Any() ? y.OrderByDescending(z => z.Id).FirstOrDefault().Makbuz.MakbuzHesapTuru : 0,
                    BelgeSubeAdi = y.Any() ? y.OrderByDescending(z => z.Id).FirstOrDefault().EskiSube.SubeAdi : x.Tahakkuk.Sube.SubeAdi,
                    SubeId = !y.Any() ? x.Tahakkuk.SubeId : y.OrderByDescending(z => z.Id).FirstOrDefault().BelgeDurumu == BelgeDurumu.OnayBekliyor ? y.OrderByDescending(z => z.Id).FirstOrDefault().YeniSubeId : y.OrderByDescending(z => z.Id).FirstOrDefault().EskiSubeId,
                    SonIslemYeri = y.OrderByDescending(z => z.Id).Select(z =>
                            z.Makbuz.AvukatHesapId != null ? z.Makbuz.AvukatHesap.AdiSoyadi :
                            z.Makbuz.BankaHesapId != null ? z.Makbuz.BankaHesap.HesapAdi :
                            z.Makbuz.CariHesapId != null ? z.Makbuz.CariHesap.CariAdi :
                            z.Makbuz.KasaHesapId != null ? z.Makbuz.KasaHesap.KasaAdi :
                            z.Makbuz.SubeHesapId != null ? z.Makbuz.SubeHesap.SubeAdi :
                            null).FirstOrDefault(),
                
                }).FirstOrDefault(),

            }).Where(y => y.Toplamlar.SubeId == subeId).Where(y =>
            
            makbuzTuru == MakbuzTuru.AvukataGonderme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade) &&
                (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :
            makbuzTuru == MakbuzTuru.AvukatYoluylaTahsilEtme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.AvukataGonderme || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme) && y.Toplamlar.SonHesapId == hesapId :
            makbuzTuru == MakbuzTuru.BankayaTahsileGonderme || makbuzTuru == MakbuzTuru.CiroEtme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :
            makbuzTuru == MakbuzTuru.BaskaSubeyeGonderme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :
            makbuzTuru == MakbuzTuru.BlokeyeAlma ? y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde && y.OdemeBilgileri.OdemeTipi == odemeTipi :
            makbuzTuru == MakbuzTuru.BlokeCozumu ? y.Toplamlar.BelgeDurumu == BelgeDurumu.BlokeAlma && y.OdemeBilgileri.OdemeTipi == odemeTipi && y.Toplamlar.SonHesapId == hesapId :
            makbuzTuru == MakbuzTuru.GelenBelgeyiOnaylama ? y.Toplamlar.BelgeDurumu == BelgeDurumu.OnayBekliyor && y.Toplamlar.SonHesapId == hesapId :
            makbuzTuru == MakbuzTuru.KarsiliksizOlarakIsaretleme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :
            makbuzTuru == MakbuzTuru.MahsupEtme ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Cek || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :
            makbuzTuru == MakbuzTuru.MusteriyeGeriIade ? y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme :
            makbuzTuru == MakbuzTuru.OdenmisOlarakIsaretleme ? y.Toplamlar.BelgeDurumu == BelgeDurumu.CiroEtme :
            makbuzTuru == MakbuzTuru.PortfoyeGeriIade ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.CiroEtme || y.Toplamlar.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme) && y.Toplamlar.MakbuzHesapTuru == makbuzHesapTuru && y.Toplamlar.SonHesapId == hesapId :
            makbuzTuru == MakbuzTuru.PortfoyeKarsiliksizIade ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.CiroEtme || y.Toplamlar.BelgeDurumu == BelgeDurumu.AvukataGonderme || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiAvukatYoluylaTahsilEtme || y.Toplamlar.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme) && y.Toplamlar.MakbuzHesapTuru == makbuzHesapTuru && y.Toplamlar.SonHesapId == hesapId :
            makbuzTuru == MakbuzTuru.TahsilEtmeBanka || makbuzTuru == MakbuzTuru.TahsilEtmeKasa ? (y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme || y.Toplamlar.BelgeDurumu == BelgeDurumu.KismiTahsilEdildi || y.Toplamlar.BelgeDurumu == BelgeDurumu.Portfoyde || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade) && (y.OdemeBilgileri.OdemeTipi == OdemeTipi.Acik || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Elden || y.OdemeBilgileri.OdemeTipi == OdemeTipi.Senet) :
            makbuzTuru == MakbuzTuru.TahsiliImkansizHaleGelme ? y.Toplamlar.BelgeDurumu == BelgeDurumu.KarsiliksizOlarakIsaretleme || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeGeriIade || y.Toplamlar.BelgeDurumu == BelgeDurumu.PortfoyeKarsiliksizIade :
            makbuzTuru == MakbuzTuru.BankaYoluylaTahsilEtme ? y.Toplamlar.BelgeDurumu == BelgeDurumu.BankayaTahsileGonderme && y.Toplamlar.SonHesapId == hesapId :
            y.Toplamlar.BelgeDurumu == 0
            
            ).Select(x => new BelgeSecimList
            {
                OdemeBilgileriId = x.OdemeBilgileri.Id,
                OgrenciNo = x.Tahakkuk.Ogrenci.Kod,
                Adi = x.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Tahakkuk.Ogrenci.Soyadi,
                SinifAdi = x.Tahakkuk.Sinif.SinifAdi,
                OgrenciSubeAdi = x.Tahakkuk.Sube.SubeAdi,
                BelgeSubeAdi = x.Toplamlar.BelgeSubeAdi,
                OdemeTuruAdi = x.OdemeBilgileri.OdemeTuru.OdemeTuruAdi,
                OdemeTipi = x.OdemeBilgileri.OdemeTipi,
                BankaHesapAdi = x.OdemeBilgileri.BankaHesap.HesapAdi,
                TakipNo = x.OdemeBilgileri.TakipNo,
                GirisTarihi = x.OdemeBilgileri.GirisTarihi,
                Vade = x.OdemeBilgileri.Vade,
                HesabaGecisTarihi = x.OdemeBilgileri.HesabaGecisTarihi,
                Tutar = x.OdemeBilgileri.Tutar,
                Tahsil = x.Toplamlar.Tahsil,
                Iade = x.Toplamlar.Iade,
                Kalan = x.OdemeBilgileri.Tutar - (x.Toplamlar.Tahsil + x.Toplamlar.Iade),
                BankaAdi = x.OdemeBilgileri.Banka.BankaAdi,
                BelgeNo = x.OdemeBilgileri.BelgeNo,
                HesapNo = x.OdemeBilgileri.HesapNo,
                AsilBorclu = x.OdemeBilgileri.AsilBorclu,
                Ciranta = x.OdemeBilgileri.Ciranta,
                Aciklama = x.OdemeBilgileri.Aciklama,
                //odemebilgileri kayıtlarındaki en son id hangisi ise onu aldık
                SonHareketId = x.Toplamlar.SonHareketId,
                SonHareketTarihi = x.Toplamlar.SonHareketTarihi,
                SonIslemYeri = x.Toplamlar.SonIslemYeri,
                BelgeDurumu = x.Toplamlar.BelgeDurumu,
                MakbuzHesapTuru = x.Toplamlar.MakbuzHesapTuru,
                SubeId = x.Toplamlar.SubeId,
            
            }).OrderBy(x => x.Vade).ToList();
        }
    }
}