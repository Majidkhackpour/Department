using System;
using System.ComponentModel.DataAnnotations;
using PacketParser.Interfaces;
using Services;

namespace Persistence.Entities
{
    public class SafeBox : ISafeBox
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public EnSafeBox Type { get; set; }
    }
}
