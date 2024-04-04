namespace BehavioralPatterns.State
{
    internal class UpperElevatorState : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся на первый этаж. . .");
            elevator.ElevatorState = new GroundElevatorState();
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("Перемещаемся еще выше. . .");
        }
    }
}
