using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class SinifSingle : Sinif
    {
        public string GrupAdi { get; set; }
    }

    [NotMapped]
    public class SinifList : BaseEntity
    {
        public string SinifAdi { get; set; }

        public string GrupAdi { get; set; }

        public int HedefOgrenciSayisi { get; set; }
                
        public decimal HedefCiro { get; set; }

        public string Aciklama { get; set; }

    }
}