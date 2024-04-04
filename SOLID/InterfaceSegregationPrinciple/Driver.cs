namespace SOLID.InterfaceSegregationPrinciple;

internal class Driver
{
    public void Drive(ICar car)
    {
        car.Drive();
    }
}
