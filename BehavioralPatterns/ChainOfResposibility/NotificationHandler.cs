namespace BehavioralPatterns.ChainOfResposibility;

internal abstract class NotificationHandler
{
    public NotificationHandler Successor { get; set; }

    public abstract void Handle(Receiver receiver);
}
