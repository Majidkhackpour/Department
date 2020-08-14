using System;
using PacketParser.Interfaces;

namespace EntityCache.WebBussines
{
    public class WebPanelLineNumbers : IPanelLineNumbers
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public Guid PanelGuid { get; set; }
        public string LineNumber { get; set; }
    }
}
