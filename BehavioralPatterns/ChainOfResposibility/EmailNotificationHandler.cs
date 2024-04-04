namespace BehavioralPatterns.ChainOfResposibility;

internal class EmailNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if(receiver.EmailNotification == true)
        {
            Console.WriteLine("Выполнено уведомление по email");
        }

        if(Successor != null)
            Successor.Handle(receiver);
    }
}
