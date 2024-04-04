namespace StructuralPatterns.CompositeExample;

internal abstract class Component
{
    public readonly string Name;
    
    protected Component(string name)
    {
        Name = name;
    }

    public abstract void Display();
    public abstract void Add(Component c);
    public abstract void Remove(Component c);
}
