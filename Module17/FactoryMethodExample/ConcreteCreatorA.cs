using System;
using System.Collections.Generic;
using System.Linq;
namespace Module17.FactoryMethodExample;

internal class ConcreteCreatorA : Creator
{
    //  Переопределенный Фабричный метод здесь возвращает конкретную реализацию
    public override BaseClass FactoryMethod()
    {
        return new ConcreteClassA();
    }
}
