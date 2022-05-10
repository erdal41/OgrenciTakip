using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class IndirimSingle : Indirim
    {
        public string IndirimTuruAdi { get; set; }
    }

    public class IndirimList : BaseEntity
    {
        public string IndirimAdi { get; set; }
        public long IndirimTuruId { get; set; }
        public string IndirimTuruAdi { get; set; }
        public string Aciklama { get; set; }
    }
}