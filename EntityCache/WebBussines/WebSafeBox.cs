using System;
using PacketParser.Interfaces;
using Services;

namespace EntityCache.WebBussines
{
    public class WebSafeBox : ISafeBox
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public EnSafeBox Type { get; set; }
    }
}
