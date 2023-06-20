public class EventPublisher
{
    private List<IEventListener> listeners;

    public EventPublisher()
    {
        listeners = new List<IEventListener>();
    }

    public void Subscribe(IEventListener listener)
    {
        listeners.Add(listener);
    }

    public void Unsubscribe(IEventListener listener)
    {
        listeners.Remove(listener);
    }

    public void PublishEvent(string eventData)
    {
        Console.WriteLine("Publishing event: " + eventData);
        foreach (var listener in listeners)
        {
            listener.Update(eventData);
        }
    }
}