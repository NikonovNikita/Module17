﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.AbstractFactoryExample;

internal interface IAbstractFactory
{
    AbstractProductA CreateProductA();
    AbstractProductB CreateProductB();
}
