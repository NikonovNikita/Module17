using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.State
{
    internal class GroundElevatorState : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся на подвальный этаж. . .");
            elevator.ElevatorState = new LowerElevatorState();
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("Поднимаемся на верхний этаж. . .");
            elevator.ElevatorState = new UpperElevatorState();
        }
    }
}
