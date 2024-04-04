using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
    internal class Suv : ICar, IOffRoadPack, IPremiumPack, ISportPack
    {
        public void CruiseControl()
        {
            Console.WriteLine("Сладко катим на круизе");
        }

        public void DescentAssist()
        {
            Console.WriteLine("Помощь при спуске");
        }

        public void Drive()
        {
            Console.WriteLine("Едем");
        }

        public void DriveDown()
        {
            Console.WriteLine("Понижаем передачу");
        }

        public void FourWheelDrive()
        {
            Console.WriteLine("Катим везде на 4 колесах");
        }

        public void LockDifferential()
        {
            Console.WriteLine("Блокируем дифференциал");
        }
    }
}
