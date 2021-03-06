﻿using System;
using System.ComponentModel.DataAnnotations;
using PacketParser.Interfaces;
using Services;

namespace Persistence.Entities
{
    public class UserLog : IUserLog
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public Guid UserGuid { get; set; }
        public EnLogType Type { get; set; }
        public string Description { get; set; }
    }
}
