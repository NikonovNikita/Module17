using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.AbstractFactory;

internal class RunMovement : IMovement
{
    public void Move()
    {
        Console.WriteLine("Бежим");
    }
}
