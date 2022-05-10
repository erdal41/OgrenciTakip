using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class Fatura : BaseHareketEntity
    {
        public long TahakkukId { get; set; }

        [Column(TypeName = "date")]
        public DateTime PlanTarih { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "money")]
        public decimal PlanTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal PlanIndirimTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal PlanNetTutar { get; set; }

        [StringLength(300)]
        public string Aciklama { get; set; }
        public int? FaturaNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TahakkukTarih { get; set; }

        [Column(TypeName = "money")]
        public decimal? TahakkukTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal? TahakkukIndirimTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal? TahakkukNetTutar { get; set; }

        public KdvSekli? KdvSekli { get; set; }
        public byte? KdvOrani { get; set; }

        [Column(TypeName = "money")]
        public decimal? KdvHaricTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal? KdvTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToplamTutar { get; set; }

        [StringLength(50)]
        public string ToplamTutarYazi { get; set; }

        [StringLength(300)]
        public string FaturaAdresi { get; set; }
        public long? FaturaAdresiIlId { get; set; }
        public long? FaturaAdresiIlceId { get; set; }


        public Tahakkuk Tahakkuk { get; set; }
        public Il FaturaAdresiIl { get; set; }
        public Ilce FaturaAdresiIlce { get; set; }
    }
}