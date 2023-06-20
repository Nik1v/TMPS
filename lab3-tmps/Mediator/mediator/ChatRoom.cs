public class ChatRoom : IChatMediator
{
    private List<IUser> users;

    public ChatRoom()
    {
        users = new List<IUser>();
    }

    public void SendMessage(string message, IUser sender)
    {
        foreach (var user in users)
        {
            if (user != sender)
            {
                user.ReceiveMessage(message);
            }
        }
    }

    public void AddUser(IUser user)
    {
        users.Add(user);
    }
}