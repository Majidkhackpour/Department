using System;
using PacketParser.Interfaces;

namespace EntityCache.WebBussines
{
    public class WebSmsLog : ISmsLog
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public Guid UserGuid { get; set; }
        public string Sender { get; set; }
        public string Reciver { get; set; }
        public string Description { get; set; }
    }
}
