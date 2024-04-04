namespace BehavioralPatterns.State;

internal interface IElevatorState
{
    void Up(Elevator elevator);
    void Down(Elevator elevator);
}
