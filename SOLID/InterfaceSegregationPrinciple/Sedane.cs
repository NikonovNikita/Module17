namespace SOLID.InterfaceSegregationPrinciple;

internal class Sedane : ICar, IPremiumPack
{
    public void CruiseControl()
    {
        Console.WriteLine("Сладко едем на круизе");
    }

    public void Drive()
    {
        Console.WriteLine("Едем");
    }
}
