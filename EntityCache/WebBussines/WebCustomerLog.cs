﻿using System;
using PacketParser.Interfaces;

namespace EntityCache.WebBussines
{
    public class WebCustomerLog : ICustomerLog
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerGuid { get; set; }
        public string SideName { get; set; }
        public string Description { get; set; }
    }
}
