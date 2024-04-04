namespace StructuralPatterns.Adapter;

internal class CanvasPainter : IPainter
{
    public void Paint()
    {
        Console.WriteLine("Рисуем на холсте");
    }
}
