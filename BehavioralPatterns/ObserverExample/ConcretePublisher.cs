namespace BehavioralPatterns.ObserverExample;

internal class ConcretePublisher : IPublisher
{
    private List<ISubscriber> _subscribers;

    public ConcretePublisher()
    {
        _subscribers = new List<ISubscriber>();
    }

    public void AddSubscriber(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Publish()
    {
        foreach(var sub in _subscribers)
            sub.Update();
    }

    public void RemoveSubscriber(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }
}
