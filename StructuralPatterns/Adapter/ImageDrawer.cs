namespace StructuralPatterns.Adapter;

internal class ImageDrawer
{
    public void DrawWith(IPrinter printer)
    {
        printer.Print();
    }
}
