using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Sinif : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]

        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Sınıf Adı", "txtSinifAdi")]
        public string SinifAdi { get; set; }
        
        [Required, ZorunluAlan("Grup Adı","txtSinifGrup")]
        public long GrupId { get; set; }

        public int HedefOgrenciSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal HedefCiro { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long SubeId { get; set; }


        public SinifGrup Grup { get; set; }

        public Sube Sube { get; set; }
    }
}