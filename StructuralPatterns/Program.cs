using StructuralPatterns.Adapter;
using StructuralPatterns.CompositeExample;
using StructuralPatterns.Facade;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //<Adapter>//

        var imageDrawer = new ImageDrawer();
        PaperPrinter paperPrinter = new PaperPrinter();
        imageDrawer.DrawWith(paperPrinter);

        CanvasPainter canvasPainter = new CanvasPainter();

        var imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);

        imageDrawer.DrawWith(imagePrinter);

        Console.WriteLine("\n\n");

        //</Adapter>//

        //<Composite>//

        StructuralPatterns.CompositeExample.Component rootFolder = new Folder("Root");
        StructuralPatterns.CompositeExample.Component myFile = new StructuralPatterns.CompositeExample.File("MyFile.txt");

        Folder documentsFolder = new Folder("MyDocuments");
        StructuralPatterns.CompositeExample.Component someFile = new StructuralPatterns.CompositeExample.File("SomeFile.txt");
        documentsFolder.Add(someFile);

        rootFolder.Add(myFile);
        rootFolder.Add(documentsFolder);
        rootFolder.Display();
        Console.WriteLine("\n\n");

        //</Composite>//

        //<Facade>//

        Editor textEditor = new Editor();
        Compiler compiler = new Compiler();
        Runtime runtime = new Runtime();

        IdeFacade ide = new IdeFacade(textEditor, compiler, runtime);

        ide.Start("Console.WriteLine(\"Hello world!\")");
        ide.Stop();

        //</Facade>//
    }
}