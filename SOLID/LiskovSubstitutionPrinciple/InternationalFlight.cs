namespace SOLID.LiskovSubstitutionPrinciple;

internal class InternationalFlight : Flight
{
    public InternationalFlight(string name, List<string> passengers = null) : base(name, passengers)
    {
    }
}
