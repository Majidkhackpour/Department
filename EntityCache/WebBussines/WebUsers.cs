using System;
using PacketParser.Interfaces;
using Services;

namespace EntityCache.WebBussines
{
    public class WebUsers : IUsers
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool IsBlock { get; set; }
        public EnUserType Type { get; set; }
    }
}
