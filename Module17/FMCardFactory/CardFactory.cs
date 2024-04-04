using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.FMCardFactory;

internal abstract class CardFactory
{
    protected abstract ICard MakeProduct();

    public ICard CreateProduct()
    {
        return this.MakeProduct();
    }
}
