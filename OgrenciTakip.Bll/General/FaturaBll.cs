using OgrenciTakip.Bll.Base;
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
    public class FaturaBll : BaseHareketBll<Fatura, OgrenciTakipContext>, IBaseHareketSelectBll<Fatura>
    {

        public IEnumerable<BaseHareketEntity> List(Expression<Func<Fatura, bool>> filter)
        {
            return List(filter, x => new FaturaPlaniList
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Aciklama = x.Aciklama,
                PlanTarih = x.PlanTarih,
                PlanTutari = x.PlanTutari,
                PlanIndirimTutari = x.PlanIndirimTutari,
                PlanNetTutar = x.PlanNetTutar,
                FaturaNo = x.FaturaNo,
                TahakkukTarih = x.TahakkukTarih,
                TahakkukTutari = x.TahakkukTutari,
                TahakkukIndirimTutari = x.TahakkukIndirimTutari,
                TahakkukNetTutar = x.TahakkukNetTutar,
            }).OrderBy(x => x.PlanTarih).ToList();
        }

        public IEnumerable<BaseHareketEntity> FaturaTahakkukList(Expression<Func<Fatura, bool>> filter)
        {
            return List(filter, x => new
            {
                Fatura = x,
                VeliBilgileri = x.Tahakkuk.IletisimBilgileri.Where(y => y.Veli).Select(z => new
                {
                    z.Iletisim,
                    z.Yakinlik
                }).FirstOrDefault()

            }).Select( x => new FaturaPlaniList
            {
                Id = x.Fatura.Id,
                TahakkukId = x.Fatura.TahakkukId,
                OkulNo = x.Fatura.Tahakkuk.Kod,
                TcKimlikNo = x.Fatura.Tahakkuk.Ogrenci.TcKimlikNo,
                Adi = x.Fatura.Tahakkuk.Ogrenci.Adi,
                Soyadi = x.Fatura.Tahakkuk.Ogrenci.Soyadi,
                SinifAdi = x.Fatura.Tahakkuk.Sinif.SinifAdi,
                KayitTarihi = x.Fatura.Tahakkuk.KayitTarihi,
                KayitSekli = x.Fatura.Tahakkuk.KayitSekli,
                KayitDurumu = x.Fatura.Tahakkuk.KayitDurumu,
                IptalDurumu = x.Fatura.Tahakkuk.Durum ? IptalDurumu.DevamEdiyor: IptalDurumu.IptalEdildi,
                VeliTcKimlikNo = x.VeliBilgileri.Iletisim.TcKimlikNo,
                VeliAdi = x.VeliBilgileri.Iletisim.Adi,
                VeliSoyadi = x.VeliBilgileri.Iletisim.Soyadi,
                VeliYakinlikAdi = x.VeliBilgileri.Yakinlik.YakinlikAdi,
                VeliMeslekAdi = x.VeliBilgileri.Iletisim.Meslek.MeslekAdi,
                VeliEvAdresi = x.VeliBilgileri.Iletisim.EvAdresi,
                VeliEvAdresiIlId = x.VeliBilgileri.Iletisim.EvAdresiIlId,
                VeliEvAdresiIlAdi = x.VeliBilgileri.Iletisim.EvAdresiIl.IlAdi,
                VeliEvAdresiIlceId = x.VeliBilgileri.Iletisim.EvAdresiIlceId,
                VeliEvAdresiIlceAdi = x.VeliBilgileri.Iletisim.EvAdresiIlce.IlceAdi,
                VeliIsAdresi = x.VeliBilgileri.Iletisim.IsAdresi,
                VeliIsAdresiIlId = x.VeliBilgileri.Iletisim.IsAdresiIlId,
                VeliIsAdresiIlAdi = x.VeliBilgileri.Iletisim.IsAdresiIl.IlAdi,
                VeliIsAdresiIlceId = x.VeliBilgileri.Iletisim.IsAdresiIlceId,
                VeliIsAdresiIlceAdi = x.VeliBilgileri.Iletisim.IsAdresiIlce.IlceAdi,
                OzelKod1 =x.Fatura.Tahakkuk.OzelKod1.OzelKodAdi,
                OzelKod2 = x.Fatura.Tahakkuk.OzelKod2.OzelKodAdi,
                OzelKod3 = x.Fatura.Tahakkuk.OzelKod3.OzelKodAdi,
                OzelKod4 = x.Fatura.Tahakkuk.OzelKod4.OzelKodAdi,
                OzelKod5 = x.Fatura.Tahakkuk.OzelKod5.OzelKodAdi,
                Aciklama = x.Fatura.Aciklama,
                PlanTarih = x.Fatura.PlanTarih,
                PlanTutari = x.Fatura.PlanTutari,
                PlanIndirimTutari = x.Fatura.PlanIndirimTutari,
                PlanNetTutar = x.Fatura.PlanNetTutar,
                FaturaNo = x.Fatura.FaturaNo,
                TahakkukTarih = x.Fatura.TahakkukTarih,
                TahakkukTutari = x.Fatura.TahakkukTutari,
                TahakkukIndirimTutari = x.Fatura.TahakkukIndirimTutari,
                TahakkukNetTutar = x.Fatura.TahakkukNetTutar,
                KdvOrani = x.Fatura.KdvOrani,
                KdvHaricTutar = x.Fatura.KdvHaricTutar,
                KdvTutari = x.Fatura.KdvTutari,
                ToplamTutar = x.Fatura.ToplamTutar,
                ToplamTutarYazi = x.Fatura.ToplamTutarYazi,
                KdvSekli = x.Fatura.KdvSekli,
                FaturaAdresi = x.Fatura.FaturaAdresi,
                FaturaAdresIlAdi = x.Fatura.FaturaAdresiIl.IlAdi,
                FaturaAdresIlceAdi = x.Fatura.FaturaAdresiIlce.IlceAdi,
                Sube = x.Fatura.Tahakkuk.Sube.SubeAdi,
                Donem = x.Fatura.Tahakkuk.Donem.DonemAdi,

            }).OrderBy(x => x.SinifAdi).ToList();
        }

        public IEnumerable<DateTime> FaturaDonemList(Expression<Func<Fatura, bool>> filter)
        {
            return List(filter, x => new
            {
                x.PlanTarih
            }).GroupBy(x => x.PlanTarih).Select(x => x.Key).ToList();
        }

        public int MaxFaturaNo(Expression<Func<Fatura, bool>> filter)
        {
            return List(filter, x => new
            {
                x.FaturaNo
            }).DefaultIfEmpty().Max(x => x.FaturaNo ?? 0);
        }
    }
}