namespace PacketParser.Interfaces
{
    public interface ISmsPanels : IHasGuid
    {
        string UserName { get; set; }
        string Password { get; set; }
        string Api { get; set; }
    }
}
