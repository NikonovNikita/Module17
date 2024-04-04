using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.AbstractFactoryExample;

internal class ConcreteFactory2 : IAbstractFactory
{
    public AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}
