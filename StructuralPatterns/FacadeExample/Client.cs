namespace StructuralPatterns.FacadeExample;

internal class Client
{
    public void Start()
    {
        Facade facade = new Facade(new SystemOne(), new SystemTwo(), new SystemThree());

        facade.OperationOne();
        facade.OperationTwo();
    }
}
