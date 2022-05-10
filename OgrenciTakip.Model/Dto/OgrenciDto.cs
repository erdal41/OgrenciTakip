using DevExpress.DataAccess.ObjectBinding;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class OgrenciSingle : Ogrenci
    {
        public string KimlikIlAdi { get; set; }
        public string KimlikIlceAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }

    public class OgrenciList : BaseEntity
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public KanGrubu KanGrubu { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string KimlikSeri { get; set; }
        public string KimlikSiraNo { get; set; }
        public string KimlikIlAdi { get; set; }
        public string KimlikIlceAdi { get; set; }
        public string KimlikMahalleKoy { get; set; }
        public string KimlikCiltNo { get; set; }
        public string KimlikAileSiraNo { get; set; }
        public string KimlikBireySiraNo { get; set; }
        public string KimlikVerildigiYer { get; set; }
        public string KimlikVerilisNedeni { get; set; }
        public string KimlikKayitNo { get; set; }
        public DateTime? KimlikVerilisTarihi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }


    //üstteki list metodunu id ve kod alanlarına raporlama ekranında gerek olmadığından dolayı yeni class oluşturduk.
    [HighlightedClass] //bu attribute raporlara databing ile ekleme yaparken oradabulunan nesne listesinde sadece bu attributeleri olanlar gözükür.
    public class OgrenciRapor : IBaseEntity
    {
        public string OgrenciNo { get; set; }
        public string OkulNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string AdiSoyadi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public KanGrubu KanGrubu { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string KimlikSeri { get; set; }
        public string KimlikSiraNo { get; set; }
        public string KimlikIlAdi { get; set; }
        public string KimlikIlceAdi { get; set; }
        public string KimlikMahalleKoy { get; set; }
        public string KimlikCiltNo { get; set; }
        public string KimlikAileSiraNo { get; set; }
        public string KimlikBireySiraNo { get; set; }
        public string KimlikVerildigiYer { get; set; }
        public string KimlikVerilisNedeni { get; set; }
        public string KimlikKayitNo { get; set; }
        public DateTime? KimlikVerilisTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public string Sinif { get; set; }
        public string GeldigiOkul { get; set; }
        public string Kontenjan { get; set; }
        public string Rehber { get; set; }
        public string YabanciDil { get; set; }
        public string Tesvik { get; set; }
        public string DonemAdi { get; set; }
        public string SubeAdi { get; set; }
        public string SubeAdresi { get; set; }
        public string SubeAdresiIlAdi { get; set; }
        public string SubeAdresiIlceAdi { get; set; }
        public string SubeTelefon { get; set; }
        public string SubeFax { get; set; }
        public string SubeIbanNo { get; set; }
        public byte[] SubeLogo { get; set; }
        public IletisimBilgileriRapor VeliBilgileri { get; set; }
        public IletisimBilgileriRapor AnneBilgileri { get; set; }
        public IletisimBilgileriRapor BabaBilgileri { get; set; }
    }
}