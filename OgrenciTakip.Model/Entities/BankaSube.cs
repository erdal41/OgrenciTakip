using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class BankaSube : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false )]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Banka Şube Adı", "txtBankaSubeAdi")]
        public string BankaSubeAdi { get; set; }
        public long BankaId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public Banka Banka { get; set; }
    }
}
