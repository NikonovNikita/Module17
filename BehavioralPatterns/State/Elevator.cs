namespace BehavioralPatterns.State;

internal class Elevator
{
    public IElevatorState ElevatorState { get; set; }

    public Elevator(IElevatorState elevatorState)
    {
        ElevatorState = elevatorState;
    }

    public void Up()
    {
        ElevatorState.Up(this);
    }

    public void Down()
    {
        ElevatorState.Down(this);
    }
}
