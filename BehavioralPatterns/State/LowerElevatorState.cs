namespace BehavioralPatterns.State;

internal class LowerElevatorState : IElevatorState
{
    public void Down(Elevator elevator)
    {
        Console.WriteLine("Опускаемся еще ниже. . .");
    }

    public void Up(Elevator elevator)
    {
        Console.WriteLine("Поднимаемся на первый этаж. . .");
        elevator.ElevatorState = new GroundElevatorState();
    }
}
