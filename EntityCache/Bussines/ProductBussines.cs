using System;
using PacketParser.Interfaces;

namespace EntityCache.Bussines
{
    public class ProductBussines : IProduct
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
    }
}
