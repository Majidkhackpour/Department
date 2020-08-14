using System;

namespace PacketParser.Interfaces
{
    public interface IPanelLineNumbers : IHasGuid
    {
        Guid PanelGuid { get; set; }
        string LineNumber { get; set; }
    }
}
