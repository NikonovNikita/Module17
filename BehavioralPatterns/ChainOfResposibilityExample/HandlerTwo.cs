namespace BehavioralPatterns.ChainOfResposibilityExample;

internal class HandlerTwo : Handler
{
    public override void HandleRequest(int condition)
    {
        if(condition == 2)
        {
            Console.WriteLine("Завершение обработки обработчиком HandlerTwo");
            return;
        }
        if(Successor != null)
            Successor.HandleRequest(condition);
    }
}
