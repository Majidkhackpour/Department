using System;
using PacketParser.Interfaces;

namespace EntityCache.Bussines
{
    public class SmsPanelBussines : ISmsPanels
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Api { get; set; }
    }
}
