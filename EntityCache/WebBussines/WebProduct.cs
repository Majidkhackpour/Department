using System;
using PacketParser.Interfaces;

namespace EntityCache.WebBussines
{
    public class WebProduct : IProduct
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal BckUpPrice { get; set; }
    }
}
