namespace BehavioralPatterns.StateExample;

internal class StateTwo : State
{
    public override void Handle(ContextObject contextObject)
    {
        contextObject.State = new StateOne();
    }
}
