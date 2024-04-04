namespace Module17.FactoryMethodExample;

internal class ConcreteCreatorB : Creator
{
    public override BaseClass FactoryMethod()
    {
        return new ConcreteClassB();
    }
}
