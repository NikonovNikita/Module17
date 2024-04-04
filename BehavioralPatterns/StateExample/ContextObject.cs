namespace BehavioralPatterns.StateExample;

internal class ContextObject
{
    public State State { get; set; }

    public ContextObject(State state)
    {
        State = state;
    }

    public void Switch()
    {
        State.Handle(this);
    }
}
