using System;
using Services;

namespace PacketParser.Interfaces
{
    public interface IUserLog : IHasGuid
    {
        DateTime Date { get; set; }
        Guid UserGuid { get; set; }
        EnLogType Type { get; set; }
        string Description { get; set; }
    }
}
