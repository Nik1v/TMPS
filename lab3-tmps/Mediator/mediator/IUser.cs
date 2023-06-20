public interface IUser
{
    string Name { get; }
    void SendMessage(string message);
    void ReceiveMessage(string message);
}