namespace StructuralPatterns.CompositeExample;

internal class Folder : Component
{
    List<Component> subfolders = new List<Component>();

    public Folder(string name) : base(name) { }

    public override void Add(Component component)
    {
        subfolders.Add(component);
        Console.WriteLine($"В {Name} добавлено: {component.Name}");
    }

    public override void Remove(Component component)
    {
        subfolders.Remove(component);
        Console.WriteLine($"Из {Name} удалено: {component.Name}");
    }

    public override void Display()
    {
        Console.WriteLine();
        Console.WriteLine(Name + " содержит:");

        foreach(var component in subfolders)
            component.Display();
    }
}
