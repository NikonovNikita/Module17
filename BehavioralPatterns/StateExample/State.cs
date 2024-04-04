namespace BehavioralPatterns.StateExample;

internal abstract class State
{
    public abstract void Handle(ContextObject contextObject);
}
