using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Dto
{
    public class RaporList : BaseEntity
    {
        public string RaporAdi { get; set; }
        public string Aciklama { get; set; }
    }
}