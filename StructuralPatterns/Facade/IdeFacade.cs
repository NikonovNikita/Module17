namespace StructuralPatterns.Facade;

internal class IdeFacade
{
    readonly Editor editor;
    readonly Compiler compiler;
    readonly Runtime runtime;

    public IdeFacade(Editor editor, Compiler compiler, Runtime runtime)
    {
        this.editor = editor;
        this.compiler = compiler;
        this.runtime = runtime;
    }

    public void Start(string sourceCode)
    {
        editor.WriteCode(sourceCode);
        editor.Save();
        compiler.Compile();
        runtime.Execute();
    }

    public void Stop()
    {
        runtime.Finish();
    }
}
