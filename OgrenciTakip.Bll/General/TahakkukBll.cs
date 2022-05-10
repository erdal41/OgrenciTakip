﻿using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class TahakkukBll : BaseGenelBll<Tahakkuk>, IBaseCommonBll
    {
        public TahakkukBll() : base(KartTuru.Tahakkuk) { }
        public TahakkukBll(Control ctrl) : base(ctrl, KartTuru.Tahakkuk) { }

        public override BaseEntity Single(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => new TahakkukSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                OgrenciId = x.OgrenciId,
                TcKimlikNo = x.Ogrenci.TcKimlikNo,
                Adi = x.Ogrenci.Adi,
                Soyadi = x.Ogrenci.Soyadi,
                BabaAdi = x.Ogrenci.BabaAdi,
                AnaAdi = x.Ogrenci.AnaAdi,
                OkulNo = x.OkulNo,
                KayitTarihi = x.KayitTarihi,
                KayitSekli = x.KayitSekli,
                KayitDurumu = x.KayitDurumu,
                SinifId = x.SinifId,
                SinifAdi = x.Sinif.SinifAdi,
                GeldigiOkulId = x.GeldigiOkulId,
                GeldigiOkulAdi = x.GeldigiOkul.OkulAdi,
                KontenjanId = x.KontenjanId,
                KontenjanAdi = x.Kontenjan.KontenjanAdi,
                YabanciDilId = x.YabanciDilId,
                YabanciDilAdi = x.YabanciDil.DilAdi,
                RehberId = x.RehberId,
                RehberAdi = x.Rehber.AdiSoyadi,
                TesvikId = x.TesvikId,
                TesvikAdi = x.Tesvik.TesvikAdi,
                SonrakiDonemKayitDurumu = x.SonrakiDonemKayitDurumu,
                SonrakiDonemKayitDurumuAciklamasi = x.SonrakiDonemKayitDurumuAciklamasi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Id = x.OzelKod3Id,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Id = x.OzelKod4Id,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Id = x.OzelKod5Id,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                SubeId = x.SubeId,
                DonemId = x.DonemId,
                Durum = x.Durum
            });
        }

        public OgrenciRapor SingleDetail(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => new OgrenciRapor
            {
                OgrenciNo = x.Kod,
                OkulNo = x.OkulNo,
                TcKimlikNo = x.Ogrenci.TcKimlikNo,
                Adi = x.Ogrenci.Adi,
                Soyadi = x.Ogrenci.Soyadi,
                AdiSoyadi = x.Ogrenci.Adi + " " + x.Ogrenci.Soyadi,
                Cinsiyet = x.Ogrenci.Cinsiyet,
                Telefon = x.Ogrenci.Telefon,
                KanGrubu = x.Ogrenci.KanGrubu,
                BabaAdi = x.Ogrenci.BabaAdi,
                AnaAdi = x.Ogrenci.AnaAdi,
                DogumYeri = x.Ogrenci.DogumYeri,
                DogumTarihi = x.Ogrenci.DogumTarihi,
                KimlikSeri = x.Ogrenci.KimlikSeri,
                KimlikSiraNo = x.Ogrenci.KimlikSiraNo,
                KimlikIlAdi = x.Ogrenci.KimlikIl.IlAdi,
                KimlikIlceAdi = x.Ogrenci.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.Ogrenci.KimlikMahalleKoy,
                KimlikCiltNo = x.Ogrenci.KimlikCiltNo,
                KimlikAileSiraNo = x.Ogrenci.KimlikAileSiraNo,
                KimlikBireySiraNo = x.Ogrenci.KimlikBireySiraNo,
                KimlikVerildigiYer = x.Ogrenci.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.Ogrenci.KimlikVerilisNedeni,
                KimlikKayitNo = x.Ogrenci.KimlikKayitNo,
                KimlikVerilisTarihi = x.Ogrenci.KimlikVerilisTarihi,
                KayitTarihi = x.KayitTarihi,
                KayitSekli = x.KayitSekli,
                KayitDurumu = x.KayitDurumu,
                Sinif = x.Sinif.SinifAdi,
                GeldigiOkul = x.GeldigiOkul.OkulAdi,
                Kontenjan = x.Kontenjan.KontenjanAdi,
                YabanciDil = x.YabanciDil.DilAdi,
                Rehber = x.Rehber.AdiSoyadi,
                Tesvik = x.Tesvik.TesvikAdi,
                DonemAdi = x.Donem.DonemAdi,
                SubeAdi = x.Sube.SubeAdi,
                SubeAdresi = x.Sube.Adres,
                SubeAdresiIlAdi = x.Sube.AdresIl.IlAdi,
                SubeAdresiIlceAdi = x.Sube.AdresIlce.IlceAdi,
                SubeTelefon = x.Sube.Telefon,
                SubeFax = x.Sube.Fax,
                SubeIbanNo = x.Sube.IbanNo,
                SubeLogo = x.Sube.Logo,

                VeliBilgileri = x.IletisimBilgileri
                .Where(y => y.Veli)
                .Select(y => new IletisimBilgileriRapor
                {
                    TcKimlikNo = y.Iletisim.TcKimlikNo,
                    Adi = y.Iletisim.Adi,
                    Soyadi = y.Iletisim.Soyadi,
                    AdiSoyadi = y.Iletisim.Adi + " " + y.Iletisim.Soyadi,
                    EvTelefonu = y.Iletisim.EvTelefonu,
                    IsTelefonu1 = y.Iletisim.IsTelefonu1,
                    IsTelefonu2 = y.Iletisim.IsTelefonu2,
                    CepTelefonu1 = y.Iletisim.CepTelefonu1,
                    CepTelefonu2 = y.Iletisim.CepTelefonu2,
                    EvAdresi = y.Iletisim.EvAdresi,
                    EvAdresiIlAdi = y.Iletisim.EvAdresiIl.IlAdi,
                    EvAdresiIlceAdi = y.Iletisim.EvAdresiIlce.IlceAdi,
                    EvAdresiTam = y.Iletisim.EvAdresi + " - " + y.Iletisim.EvAdresiIlce.IlceAdi + " / " + y.Iletisim.EvAdresiIl.IlAdi,
                    IsAdresi = y.Iletisim.IsAdresi,
                    IsAdresiIlAdi = y.Iletisim.IsAdresiIl.IlAdi,
                    IsAdresiIlceAdi = y.Iletisim.IsAdresiIlce.IlceAdi,
                    IsAdresiTam = y.Iletisim.IsAdresi + " - " + y.Iletisim.IsAdresiIlce.IlceAdi + " / " + y.Iletisim.IsAdresiIl.IlAdi,
                    YakinlikAdi = y.Yakinlik.YakinlikAdi,
                    MeslekAdi = y.Iletisim.Meslek.MeslekAdi,
                    IsyeriAdi = y.Iletisim.Isyeri.IsyeriAdi,
                    GorevAdi = y.Iletisim.Gorev.GorevAdi,

                }).FirstOrDefault(),

                AnneBilgileri = x.IletisimBilgileri
                .Where(y => y.Yakinlik.YakinlikAdi == "Anne")
                .Select(y => new IletisimBilgileriRapor
                {
                    TcKimlikNo = y.Iletisim.TcKimlikNo,
                    Adi = y.Iletisim.Adi,
                    Soyadi = y.Iletisim.Soyadi,
                    AdiSoyadi = y.Iletisim.Adi + " " + y.Iletisim.Soyadi,
                    EvTelefonu = y.Iletisim.EvTelefonu,
                    IsTelefonu1 = y.Iletisim.IsTelefonu1,
                    IsTelefonu2 = y.Iletisim.IsTelefonu2,
                    CepTelefonu1 = y.Iletisim.CepTelefonu1,
                    CepTelefonu2 = y.Iletisim.CepTelefonu2,
                    EvAdresi = y.Iletisim.EvAdresi,
                    EvAdresiIlAdi = y.Iletisim.EvAdresiIl.IlAdi,
                    EvAdresiIlceAdi = y.Iletisim.EvAdresiIlce.IlceAdi,
                    EvAdresiTam = y.Iletisim.EvAdresi + " - " + y.Iletisim.EvAdresiIlce.IlceAdi + " / " + y.Iletisim.EvAdresiIl.IlAdi,
                    IsAdresi = y.Iletisim.IsAdresi,
                    IsAdresiIlAdi = y.Iletisim.IsAdresiIl.IlAdi,
                    IsAdresiIlceAdi = y.Iletisim.IsAdresiIlce.IlceAdi,
                    IsAdresiTam = y.Iletisim.IsAdresi + " - " + y.Iletisim.IsAdresiIlce.IlceAdi + " / " + y.Iletisim.IsAdresiIl.IlAdi,
                    YakinlikAdi = y.Yakinlik.YakinlikAdi,
                    MeslekAdi = y.Iletisim.Meslek.MeslekAdi,
                    IsyeriAdi = y.Iletisim.Isyeri.IsyeriAdi,
                    GorevAdi = y.Iletisim.Gorev.GorevAdi,

                }).FirstOrDefault(),

                BabaBilgileri = x.IletisimBilgileri
                .Where(y => y.Yakinlik.YakinlikAdi == "Baba")
                .Select(y => new IletisimBilgileriRapor
                {
                    TcKimlikNo = y.Iletisim.TcKimlikNo,
                    Adi = y.Iletisim.Adi,
                    Soyadi = y.Iletisim.Soyadi,
                    AdiSoyadi = y.Iletisim.Adi + " " + y.Iletisim.Soyadi,
                    EvTelefonu = y.Iletisim.EvTelefonu,
                    IsTelefonu1 = y.Iletisim.IsTelefonu1,
                    IsTelefonu2 = y.Iletisim.IsTelefonu2,
                    CepTelefonu1 = y.Iletisim.CepTelefonu1,
                    CepTelefonu2 = y.Iletisim.CepTelefonu2,
                    EvAdresi = y.Iletisim.EvAdresi,
                    EvAdresiIlAdi = y.Iletisim.EvAdresiIl.IlAdi,
                    EvAdresiIlceAdi = y.Iletisim.EvAdresiIlce.IlceAdi,
                    EvAdresiTam = y.Iletisim.EvAdresi + " - " + y.Iletisim.EvAdresiIlce.IlceAdi + " / " + y.Iletisim.EvAdresiIl.IlAdi,
                    IsAdresi = y.Iletisim.IsAdresi,
                    IsAdresiIlAdi = y.Iletisim.IsAdresiIl.IlAdi,
                    IsAdresiIlceAdi = y.Iletisim.IsAdresiIlce.IlceAdi,
                    IsAdresiTam = y.Iletisim.IsAdresi + " - " + y.Iletisim.IsAdresiIlce.IlceAdi + " / " + y.Iletisim.IsAdresiIl.IlAdi,
                    YakinlikAdi = y.Yakinlik.YakinlikAdi,
                    MeslekAdi = y.Iletisim.Meslek.MeslekAdi,
                    IsyeriAdi = y.Iletisim.Isyeri.IsyeriAdi,
                    GorevAdi = y.Iletisim.Gorev.GorevAdi,

                }).FirstOrDefault(),

            });
        }

        public BaseEntity SingleSummary(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new TahakkukList
            {
                Id = x.Id,
                Kod = x.Kod,
                OgrenciId = x.OgrenciId,
                TcKimlikNo = x.Ogrenci.TcKimlikNo,
                Adi = x.Ogrenci.Adi,
                Soyadi = x.Ogrenci.Soyadi,
                BabaAdi = x.Ogrenci.BabaAdi,
                AnaAdi = x.Ogrenci.AnaAdi,
                OkulNo = x.OkulNo,
                KayitTarihi = x.KayitTarihi,
                KayitSekli = x.KayitSekli,
                KayitDurumu = x.KayitDurumu,
                SinifAdi = x.Sinif.SinifAdi,
                GeldigiOkulAdi = x.GeldigiOkul.OkulAdi,
                KontenjanAdi = x.Kontenjan.KontenjanAdi,
                YabanciDilAdi = x.YabanciDil.DilAdi,
                RehberAdi = x.Rehber.AdiSoyadi,
                TesvikAdi = x.Tesvik.TesvikAdi,
                SonrakiDonemKayitDurumu = x.SonrakiDonemKayitDurumu,
                SonrakiDonemKayitDurumuAciklamasi = x.SonrakiDonemKayitDurumuAciklamasi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                SubeAdi = x.Sube.SubeAdi,
                Durum = x.Durum
            }).OrderBy(x => x.Kod).ToList();
        }

        public IEnumerable<FaturaList> FaturaTahakkukList(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                Tahakkuk = x,
                VeliBilgileri = x.IletisimBilgileri.Where(y => y.Veli).Select(y => new
                {
                    y.Iletisim,
                    y.Yakinlik
                }).FirstOrDefault(),

                HizmetBilgileri = x.HizmetBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    //alına toplam null ise 0 döndür
                    NetHizmet = y.Select(z => z.NetUcret).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                IndirimBilgileri = x.IndirimBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    //alına toplam null ise 0 döndür
                    NetIndirim = y.Select(z => z.NetIndirim).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                FaturaBilgileri = x.FaturaBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    Aciklama = y.Select(z => z.Aciklama).FirstOrDefault(),
                    PlanTutari = y.Select(z => z.PlanTutari).DefaultIfEmpty(0).Sum(),
                    PlanIndirimTutari = y.Select(z => z.PlanIndirimTutari).DefaultIfEmpty(0).Sum(),
                    PlanNetTutar = y.Select(z => z.PlanNetTutar).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault()

            }).Select(x => new FaturaList
            {
                Id = x.Tahakkuk.Id,
                OkulNo = x.Tahakkuk.Kod,
                Adi = x.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Tahakkuk.Ogrenci.Soyadi,
                SinifAdi = x.Tahakkuk.Sinif.SinifAdi,
                VeliAdi = x.VeliBilgileri.Iletisim.Adi,
                VeliSoyadi = x.VeliBilgileri.Iletisim.Soyadi,
                VeliYakinlikAdi = x.VeliBilgileri.Yakinlik.YakinlikAdi,
                VeliMeslekAdi = x.VeliBilgileri.Iletisim.Meslek.MeslekAdi,
                KayitTarihi = x.Tahakkuk.KayitTarihi,
                KayitSekli = x.Tahakkuk.KayitSekli,
                KayitDurumu = x.Tahakkuk.KayitDurumu,
                IptalDurumu = x.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi,
                HizmetTutari = x.HizmetBilgileri.NetHizmet,
                HizmetIndirimTutari = x.IndirimBilgileri.NetIndirim,
                HizmetNetTutar = x.HizmetBilgileri.NetHizmet - x.IndirimBilgileri.NetIndirim,
                PlanTutari = x.FaturaBilgileri.PlanTutari,
                PlanIndirimTutari = x.FaturaBilgileri.PlanIndirimTutari,
                PlanNetTutar = x.FaturaBilgileri.PlanTutari - x.FaturaBilgileri.PlanIndirimTutari,
                OzelKod1 = x.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.Tahakkuk.OzelKod2.OzelKodAdi,
                OzelKod3 = x.Tahakkuk.OzelKod3.OzelKodAdi,
                OzelKod4 = x.Tahakkuk.OzelKod4.OzelKodAdi,
                OzelKod5 = x.Tahakkuk.OzelKod5.OzelKodAdi,
            }).OrderBy(x => x.OkulNo).ToList();
        }

        public IEnumerable<OgrenciTahakkukList> OgrenciTahakkukList(Expression<Func<Tahakkuk, bool>> filter)
        {
            return BaseList(filter, x => new
            {
                Tahakkuk = x,

                HizmetBilgileri = x.HizmetBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    BrutHizmet = y.Select(z => z.BrutUcret).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenHizmet = y.Select(z => z.KistDonemDusulenUcret).DefaultIfEmpty(0).Sum(),
                    //alına toplam null ise 0 döndür
                    NetHizmet = y.Select(z => z.NetUcret).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

                IndirimBilgileri = x.IndirimBilgileri.GroupBy(y => y.TahakkukId).DefaultIfEmpty().Select(y => new
                {
                    BrutIndirim = y.Select(z => z.BrutIndirim).DefaultIfEmpty(0).Sum(),
                    KistDonemDusulenIndirim = y.Select(z => z.KistDonemDusulenIndirim).DefaultIfEmpty(0).Sum(),
                    //alına toplam null ise 0 döndür
                    NetIndirim = y.Select(z => z.NetIndirim).DefaultIfEmpty(0).Sum(),
                }).FirstOrDefault(),

            }).Select(x => new OgrenciTahakkukList
            {
                TahakkukId = x.Tahakkuk.Id,
                SubeId = x.Tahakkuk.SubeId,
                SubeAdi = x.Tahakkuk.Sube.SubeAdi,
                DonemId = x.Tahakkuk.DonemId,
                DonemAdi = x.Tahakkuk.Donem.DonemAdi,
                BrutHizmet = x.HizmetBilgileri.BrutHizmet,
                KistDonemDusulenHizmet = x.HizmetBilgileri.KistDonemDusulenHizmet,
                NetHizmet = x.HizmetBilgileri.NetHizmet,
                BrutIndirim = x.IndirimBilgileri.BrutIndirim,
                KistDonemDusulenIndirim = x.IndirimBilgileri.KistDonemDusulenIndirim,
                NetIndirim = x.IndirimBilgileri.NetIndirim,
                NetUcret = x.HizmetBilgileri.NetHizmet - x.IndirimBilgileri.NetIndirim,
                IndirimOrani = x.HizmetBilgileri.NetHizmet == 0 ? 0 : x.IndirimBilgileri.NetIndirim / x.HizmetBilgileri.NetHizmet * 100,
            }).OrderBy(x => x.TahakkukId).ToList();
        }
    }
}