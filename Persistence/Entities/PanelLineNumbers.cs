using System;
using System.ComponentModel.DataAnnotations;
using PacketParser.Interfaces;

namespace Persistence.Entities
{
    public class PanelLineNumbers : IPanelLineNumbers
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public Guid PanelGuid { get; set; }
        [MaxLength(200)]
        public string LineNumber { get; set; }
    }
}
