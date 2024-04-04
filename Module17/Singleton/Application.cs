namespace Module17.Singleton;

internal class Application
{
    public DataBaseConnection DBConnection { get; set; }

    public void Launch(string dataBaseServer)
    {
        DBConnection = DataBaseConnection.GetConnectionInstance(dataBaseServer);
    }
}
