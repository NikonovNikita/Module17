namespace BehavioralPatterns.ChainOfResposibilityExample;

internal abstract class Handler
{
    public Handler Successor { get; set; }

    public abstract void HandleRequest(int condition);
}
