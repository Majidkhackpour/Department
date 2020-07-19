using System;
using PacketParser.Interfaces;

namespace EntityCache.Bussines
{
    public class UsersBussines : IUsers
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
