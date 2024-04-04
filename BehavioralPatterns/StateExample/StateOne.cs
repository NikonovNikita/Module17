namespace BehavioralPatterns.StateExample;

internal class StateOne : State
{
    public override void Handle(ContextObject contextObject)
    {
        contextObject.State = new StateTwo();
    }
}
