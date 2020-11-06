namespace PacketParser.Interfaces
{
    public interface ISmsPanels : IHasGuid
    {
        string Name { get; set; }
        string LineNumber { get; set; }
        string Api { get; set; }
    }
}
