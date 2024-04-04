namespace Module17.FactoryMethod;

internal class EmailMessageSender : MessageSender
{
    public EmailMessageSender(string @from) : base(@from) { }

    public override Message Send(string text)
    {
        return new EmailMessage();
    }
}
