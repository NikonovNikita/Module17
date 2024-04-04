using System.Data.Common;

namespace StructuralPatterns.AdapterExample;

internal class Client
{
    public void Request(DataSource dataSource) //Сюда можно загрузить Adapter, т.к он является наследником DataSource//
    {
        dataSource.GetData();
    }
}
