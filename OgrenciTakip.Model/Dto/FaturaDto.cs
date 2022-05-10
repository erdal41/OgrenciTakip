using DevExpress.DataAccess.ObjectBinding;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    public class FaturaList
    {
        public long Id { get; set; }
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public string OkulNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public decimal HizmetTutar { get; set; }
        public decimal HizmetTutari { get; set; }
        public decimal HizmetIndirimTutari { get; set; }
        public decimal HizmetNetTutar { get; set; }
        public decimal PlanTutari { get; set; }
        public decimal PlanIndirimTutari { get; set; }
        public decimal PlanNetTutar { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string OzelKod5 { get; set; }
    }

    [NotMapped]
    public class FaturaPlaniList : Fatura, IBaseHareketEntity
    {
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public string OkulNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string VeliTcKimlikNo { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string VeliEvAdresi { get; set; }
        public long? VeliEvAdresiIlId { get; set; }
        public string VeliEvAdresiIlAdi { get; set; }
        public long? VeliEvAdresiIlceId { get; set; }
        public string VeliEvAdresiIlceAdi { get; set; }
        public string VeliIsAdresi { get; set; }
        public long? VeliIsAdresiIlId { get; set; }
        public string VeliIsAdresiIlAdi { get; set; }
        public long? VeliIsAdresiIlceId { get; set; }
        public string VeliIsAdresiIlceAdi { get; set; }
        public string FaturaAdresIlAdi { get; set; }
        public string FaturaAdresIlceAdi { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string OzelKod5 { get; set; }
        public string Sube { get; set; }
        public string Donem { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    public class FaturaAlinanHizmetlerList
    {
        public long HizmetId { get; set; }
        public long TahakkukId { get; set; }
        public string OkulNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string HizmetAdi { get; set; }
        public decimal BrutUcret { get; set; }
        public decimal Indirim { get; set; }
        public decimal NetUcret { get; set; }
    }

    [HighlightedClass]
    public class FaturaRapor : IBaseEntity
    {
        public long TahakkukId { get; set; }
        public string OkulNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public string VeliTcKimlikNo { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliYakinlikAdi { get; set; }
        public string VeliMeslekAdi { get; set; }
        public string VeliEvAdresi { get; set; }
        public string FaturaAdresi { get; set; }
        public string FaturaAdresIlAdi { get; set; }
        public string FaturaAdresIlceAdi { get; set; }
        public int? FaturaNo { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal? Tutar { get; set; }
        public decimal? Indirim { get; set; }
        public decimal? NetTutar { get; set; }
        public KdvSekli? KdvSekli { get; set; }
        public byte? KdvOrani { get; set; }
        public decimal? KdvHaricTutar { get; set; }
        public decimal? KdvTutari { get; set; }
        public decimal? ToplamTutar { get; set; }
        public decimal? PlanTutar { get; set; }
        public decimal? PlanIndirim { get; set; }
        public decimal? PlanNetTutar { get; set; }
        public string TutarYazi { get; set; }
        public string Aciklama { get; set; }
        public string Sube { get; set; }
        public string Donem { get; set; }
    }
}