using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResposibilityExample;

internal class Client
{
    public void Start()
    {
        var handler1 = new HandlerOne();
        var handler2 = new HandlerTwo();

        handler1.Successor = handler2;
        handler1.HandleRequest(2);
    }
}
