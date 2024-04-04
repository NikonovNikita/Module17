namespace Module17.FactoryMethod;

internal class SmsMessage : Message
{
    public SmsMessage()
    {
        Console.WriteLine("SMS отправлено");
    }
}
