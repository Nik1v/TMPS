public class EventListener : IEventListener
{
    private string name;

    public EventListener(string name)
    {
        this.name = name;
    }

    public void Update(string eventData)
    {
        Console.WriteLine("Listener " + name + " received event data: " + eventData);
    }
}