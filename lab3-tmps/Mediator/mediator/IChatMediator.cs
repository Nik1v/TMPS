public interface IChatMediator
{
    void SendMessage(string message, IUser sender);
    void AddUser(IUser user);
}