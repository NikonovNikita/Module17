namespace Module17.FactoryMethod;

internal class SmsMessageSender : MessageSender
{
    public SmsMessageSender(string @from) : base(@from) { }

    public override Message Send(string text)
    {
        return new SmsMessage();
    }
}
