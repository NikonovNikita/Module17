using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResposibilityExample
{
    internal class HandlerOne : Handler
    {
        public override void HandleRequest(int condition)
        {
            if(condition == 1)
            {
                Console.WriteLine("Завершение обработки обработчиком HandlerOne");
                return;
            }
            if(Successor != null)
                Successor.HandleRequest(condition);
        }
    }
}
