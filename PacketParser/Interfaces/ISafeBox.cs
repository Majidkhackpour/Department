using Services;

namespace PacketParser.Interfaces
{
    public interface ISafeBox : IHasGuid
    {
        string Name { get; set; }
        EnSafeBox Type { get; set; }
    }
}
