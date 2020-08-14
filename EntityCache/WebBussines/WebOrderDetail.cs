using System;
using PacketParser.Interfaces;

namespace EntityCache.WebBussines
{
    public class WebOrderDetail : IOrderDetail
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public Guid PrdGuid { get; set; }
        public decimal Price { get; set; }
    }
}
