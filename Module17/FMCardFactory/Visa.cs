using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.FMCardFactory;

internal class Visa : ICard
{
    public string Id
    {
        get
        {
            return "#112233";
        }
    }

    public void Pay()
    {
        Console.WriteLine("Покупаем :)");
    }
}
