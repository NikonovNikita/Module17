namespace StructuralPatterns.FacadeExample;

internal class Facade
{
    private SystemOne _sys1;
    private SystemTwo _sys2;
    private SystemThree _sys3;

    public Facade(SystemOne sys1, SystemTwo sys2, SystemThree sys3)
    {
        _sys1 = sys1;
        _sys2 = sys2;
        _sys3 = sys3;
    }

    public void OperationOne()
    {
        _sys1.S1Method();
        _sys2.S2Method();
        _sys3.S3Method();
    }

    public void OperationTwo()
    {
        _sys2.S2Method();
        _sys3.S3Method();
    }
}
