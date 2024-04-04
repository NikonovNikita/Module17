using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.AbstractFactoryExample;

internal class ConcreteFactory1 : IAbstractFactory
{
    public AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    public AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}
