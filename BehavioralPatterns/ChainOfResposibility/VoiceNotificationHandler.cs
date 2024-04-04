namespace BehavioralPatterns.ChainOfResposibility;

internal class VoiceNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if(receiver.VoiceNotification == true)
        {
            Console.WriteLine("Выполнено голосовое уведомление");
        }

        if(Successor != null)
            Successor.Handle(receiver);
    }
}
