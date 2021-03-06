using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Attributes;
using OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciTakip.Model.Entities
{
    public class MailParametre : BaseEntity
    {
        [Required, StringLength(50), ZorunluAlan("E-Mail", "txtEmail")]
        public string EMail { get; set; }

        [Required, StringLength(50), ZorunluAlan("E-Mail", "txtEmail")]
        public string Sifre { get; set; }

        [ZorunluAlan("Port No", "txtPortNo")]
        public int PortNo { get; set; }

        [Required, StringLength(50), ZorunluAlan("Host", "txtHost")]
        public string Host { get; set; }
        public EvetHayir SLLKullan { get; set; } = EvetHayir.Evet;
    }
}