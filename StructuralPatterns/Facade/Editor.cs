namespace StructuralPatterns.Facade;

internal class Editor
{
    public void WriteCode(string sourceCode)
    {
        Console.WriteLine($"Writing the code: {sourceCode}");
    }

    public void Save()
    {
        Console.WriteLine("Saving the code");
    }
}
