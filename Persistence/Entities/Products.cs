using System;
using System.ComponentModel.DataAnnotations;
using PacketParser.Interfaces;

namespace Persistence.Entities
{
    public class Products : IProduct
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal BckUpPrice { get; set; }
    }
}
