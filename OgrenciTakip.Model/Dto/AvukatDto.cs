using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class AvukatSingle : Avukat
    {
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }

    public class AvukatList : BaseEntity
    {
        public string AdiSoyadi { get; set; }
        public string SozlesmeNo { get; set; }
        public DateTime? SozlesmeBaslamaTarihi { get; set; }
        public DateTime? SozlesmeBitisTarihi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string Aciklama { get; set; }
    }
}