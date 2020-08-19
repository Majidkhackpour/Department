using System;
using PacketParser.Interfaces;

namespace EntityCache.WebBussines
{
    public class WebSmsPanels : ISmsPanels
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string LineNumber { get; set; }
        public string Api { get; set; }
    }
}
