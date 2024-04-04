namespace SOLID.SingleResponsibility;

internal class PdfExporter : IExporter
{
    public void Export(string text)
    {
        Console.WriteLine($"{text} --> Экспортировано в .pdf");
    }
}
