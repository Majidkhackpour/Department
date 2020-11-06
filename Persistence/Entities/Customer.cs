using System;
using System.ComponentModel.DataAnnotations;
using PacketParser.Interfaces;

namespace Persistence.Entities
{
    public class Customer : ICustomers
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string CompanyName { get; set; }
        [MaxLength(20)]
        public string NationalCode { get; set; }
        [MaxLength(50)]
        public string AppSerial { get; set; }
        public string Address { get; set; }
        [MaxLength(20)]
        public string PostalCode { get; set; }
        [MaxLength(15)]
        public string Tell1 { get; set; }
        [MaxLength(15)]
        public string Tell2 { get; set; }
        [MaxLength(15)]
        public string Tell3 { get; set; }
        [MaxLength(15)]
        public string Tell4 { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime ExpireDate { get; set; }
        public Guid UserGuid { get; set; }
    }
}
