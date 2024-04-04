namespace SOLID.DependencyInversionPrinciple;

internal class Monitor : IHdmi
{
    public void Display(string text)
    {
        Console.WriteLine($"Вывод на монитор: {text}");
    }
}
