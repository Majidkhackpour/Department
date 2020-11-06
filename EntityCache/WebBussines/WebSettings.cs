using System;
using PacketParser.Interfaces;

namespace EntityCache.WebBussines
{
    public class WebSettings : ISettings
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
