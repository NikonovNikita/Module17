using SOLID.DependencyInversionPrinciple;
using SOLID.InterfaceSegregationPrinciple;
using SOLID.LiskovSubstitutionPrinciple;
using SOLID.OpenClosedPrinciple;
using SOLID.SingleResponsibility;

class Program
{
    static void Main(string[] args)
    {
        //<SOLID>//

        IExporter exporter = new PdfExporter();
        Document doc = new Document();
        doc.Text = "Hello world";
        doc.Export(exporter);

        //</SOLID>//

        //<OpenClosedPrinciple>//

        var boardComputerr = new BoardComputer();
        boardComputerr.PerformLanding(new WaterLandingProfile());
        Console.WriteLine("\n");
        boardComputerr.PerformLanding(new GroundLandingProfile());

        Console.WriteLine("\n\n");

        //</OpenClosedPrinciple>//

        //<LiskovSubstitutionPrinciple>//

        var flightList = new List<Flight>()
        {
            new DomesticFlight("Mow-32", new List<string> {"Вася, Малыха"}),
            new InternationalFlight("Spb-54", new List<string> {"Никита", "Алена"})
        };
        FlightPassengerCount(flightList);

        Console.WriteLine("\n\n");

        //</LiskovSubstitutionPrinciple>//

        //<InterfaceSegregationPrinciple>//

        var driver = new Driver();
        driver.Drive(new Suv());
        driver.Drive(new Sedane());

        Console.WriteLine("\n\n");

        //</InterfaceSegregationPrinciple>//

        //<DependencyInversionPrinciple>//

        var connectedDevice = new VideoAdapter(new SOLID.DependencyInversionPrinciple.Monitor());
        connectedDevice.Display("Hello world");
        connectedDevice = new VideoAdapter(new TV());
        connectedDevice.Display("Привет, мир");

        //</DependencyInversionPrinciple>//
    }

    static void FlightPassengerCount(List<Flight> flights)
    {
        foreach(var flight in flights)
            flight.CountPassengers();
    }
}