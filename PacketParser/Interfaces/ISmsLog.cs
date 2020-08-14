using System;

namespace PacketParser.Interfaces
{
    public interface ISmsLog : IHasGuid
    {
        DateTime Date { get; set; }
        Guid UserGuid { get; set; }
        string Sender { get; set; }
        string Reciver { get; set; }
        string Description { get; set; }
    }
}
