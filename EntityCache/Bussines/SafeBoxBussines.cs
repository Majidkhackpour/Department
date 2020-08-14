using System;
using PacketParser.Interfaces;
using Services;

namespace EntityCache.Bussines
{
    public class SafeBoxBussines : ISafeBox
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public EnSafeBox Type { get; set; }
    }
}
