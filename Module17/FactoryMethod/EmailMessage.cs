namespace Module17.FactoryMethod;

internal class EmailMessage : Message
{
    public EmailMessage()
    {
        Console.WriteLine("Email отправлено");
    }
}
