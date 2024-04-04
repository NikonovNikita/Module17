namespace SOLID.SingleResponsibility;

internal class Document
{
    public string Text { get; set; }

    public void ScrollUp() { }
    public void ScrollDown() { }
    public void ZoomIn() { }
    public void Export(IExporter exporter)
    {
        exporter.Export(Text);
    }
}
