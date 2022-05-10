using OgrenciTakip.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class KurumBilgileriSingle: KurumBilgileri
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }
}