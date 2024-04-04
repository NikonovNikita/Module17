namespace BehavioralPatterns.ObserverExample;

internal interface IPublisher
{
    void AddSubscriber(ISubscriber subscriber);
    void RemoveSubscriber(ISubscriber subscriber);
    void Publish();
}
