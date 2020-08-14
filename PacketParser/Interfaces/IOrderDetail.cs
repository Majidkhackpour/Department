using System;

namespace PacketParser.Interfaces
{
    public interface IOrderDetail : IHasGuid
    {
        Guid PrdGuid { get; set; }
        decimal Price { get; set; }
    }
}
