using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter;

internal class CanvasPainterToPrinterAdapter : IPrinter
{
    private IPainter _canvasPainter;

    public CanvasPainterToPrinterAdapter(IPainter canvasPainter)
    {
        _canvasPainter = canvasPainter;
    }

    public void Print()
    {
        _canvasPainter.Paint();
    }
}
