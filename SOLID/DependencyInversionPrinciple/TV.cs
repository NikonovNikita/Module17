using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    internal class TV : IHdmi
    {
        public void Display(string text)
        {
            Console.WriteLine($"Вывод на телевизор: {text}");
        }
    }
}
