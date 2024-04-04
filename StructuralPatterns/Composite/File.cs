namespace StructuralPatterns.CompositeExample;

internal class File : Component
{
    public File(string name) : base(name) { }

    public override void Display()
    {
        Console.WriteLine(Name);
    }

    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }
}
