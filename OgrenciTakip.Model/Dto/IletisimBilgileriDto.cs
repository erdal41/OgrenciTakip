using DevExpress.DataAccess.ObjectBinding;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class IletisimBilgileriList : IletisimBilgileri, IBaseHareketEntity
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string EvTelefonu { get; set; }
        public string CepTelefonu1 { get; set; }
        public string CepTelefonu2 { get; set; }
        public string IsTelefonu1 { get; set; }
        public string IsTelefonu2 { get; set; }
        public string EvAdresi { get; set; }
        public string EvAdresiIlAdi { get; set; }
        public string EvAdresiIlceAdi { get; set; }
        public string IsAdresi { get; set; }
        public string IsAdresiIlAdi { get; set; }
        public string IsAdresiIlceAdi { get; set; }
        public string YakinlikAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class IletisimBilgileriRapor
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string AdiSoyadi { get; set; }
        public string EvTelefonu { get; set; }
        public string CepTelefonu1 { get; set; }
        public string CepTelefonu2 { get; set; }
        public string IsTelefonu1 { get; set; }
        public string IsTelefonu2 { get; set; }
        public string EvAdresi { get; set; }
        public string EvAdresiIlAdi { get; set; }
        public string EvAdresiIlceAdi { get; set; }
        public string EvAdresiTam { get; set; }
        public string IsAdresi { get; set; }
        public string IsAdresiIlAdi { get; set; }
        public string IsAdresiIlceAdi { get; set; }
        public string IsAdresiTam { get; set; }
        public string YakinlikAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }
    }
}