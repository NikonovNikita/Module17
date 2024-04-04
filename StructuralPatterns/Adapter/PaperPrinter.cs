namespace StructuralPatterns.Adapter;

internal class PaperPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Печатаем на бумаге");
    }
}
