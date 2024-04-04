namespace Module17.FactoryMethod;

internal abstract class MessageSender
{
    public string From { get; set; }
    
    public MessageSender(string @from)
    {
        From = @from;
    }

    abstract public Message Send(string text);
}
