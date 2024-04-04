namespace Module17.Singleton;

internal class DataBaseConnection
{
    private static DataBaseConnection Connection;

    public string Configuration { get; set; }

    protected DataBaseConnection(string configuration)
    {
        Configuration = configuration;
    }

    public static DataBaseConnection GetConnectionInstance(string dataBaseServer)
    {
        if(Connection == null)
            Connection = new DataBaseConnection(dataBaseServer);

        return Connection;
    }
}
