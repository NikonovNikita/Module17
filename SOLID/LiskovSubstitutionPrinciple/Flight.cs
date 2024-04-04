namespace SOLID.LiskovSubstitutionPrinciple;

internal abstract class Flight
{
    public string Name { get; set; }
    public List<string> PassengerList;

    public Flight(string name, List<string> passengers = null)
    {
        Name = name;
        PassengerList = passengers ?? new List<string>();
    }

    public void CountPassengers()
    {
        Console.WriteLine($"На рейсе {Name} {PassengerList.Count} пассажиров");
    }
}
