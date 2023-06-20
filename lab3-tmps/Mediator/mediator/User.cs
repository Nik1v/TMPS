public class User : IUser
{
    private IChatMediator chatMediator;

    public string Name { get; private set; }

    public User(string name, IChatMediator chatMediator)
    {
        Name = name;
        this.chatMediator = chatMediator;
    }

    public void SendMessage(string message)
    {
        chatMediator.SendMessage(message, this);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine(Name + " received message: " + message);
    }
}