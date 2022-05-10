using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class GecikmeAciklamalariSingle : GecikmeAciklamalari
    {
        public string KullaniciAdi { get; set; }
    }

    public class GecikmeAciklamalariList : BaseEntity
    {
        public int PortfoyNo { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Aciklama { get; set; }
    }
}