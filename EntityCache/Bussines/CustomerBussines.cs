using System;
using PacketParser.Interfaces;

namespace EntityCache.Bussines
{
    public class CustomerBussines : ICustomers
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NationalCode { get; set; }
        public string AppSerial { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Tell1 { get; set; }
        public string Tell2 { get; set; }
        public string Tell3 { get; set; }
        public string Tell4 { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
