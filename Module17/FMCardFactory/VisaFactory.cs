using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.FMCardFactory;

internal class VisaFactory : CardFactory
{
    protected override ICard MakeProduct()
    {
        return new Visa();
    }
}
