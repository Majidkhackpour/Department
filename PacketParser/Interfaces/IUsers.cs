namespace PacketParser.Interfaces
{
    public interface IUsers : IHasGuid
    {
        string Name { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Mobile { get; set; }
        string Email { get; set; }
    }
}
