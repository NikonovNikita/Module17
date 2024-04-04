namespace BehavioralPatterns.ChainOfResposibility;

internal class SmsNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if(receiver.SmsNotification == true)
        {
            Console.WriteLine("Выполнено уведомление по sms");
        }

        if(Successor != null)
            Successor.Handle(receiver);
    }
}
