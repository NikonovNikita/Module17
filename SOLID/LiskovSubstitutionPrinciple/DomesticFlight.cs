using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple;

internal class DomesticFlight : Flight
{
    public DomesticFlight(string name, List<string> passengers = null) : base(name, passengers)
    {
    }
}
