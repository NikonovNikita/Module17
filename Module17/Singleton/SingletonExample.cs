namespace Module17.Singleton;

internal class SingletonExample
{
    private static SingletonExample Instance;

    private SingletonExample() { }

    public static SingletonExample GetInstance()
    {
        if( Instance == null )
            Instance = new SingletonExample();

        return Instance;
    }
}
