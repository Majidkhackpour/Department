﻿using System;
using System.ComponentModel.DataAnnotations;
using PacketParser.Interfaces;

namespace Persistence.Entities
{
    public class SmsLog : ISmsLog
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public Guid UserGuid { get; set; }
        [MaxLength(100)]
        public string Sender { get; set; }
        [MaxLength(100)]
        public string Reciver { get; set; }
        public string Description { get; set; }
    }
}