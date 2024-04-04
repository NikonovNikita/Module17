namespace StructuralPatterns.AdapterExample;

internal class Adapter : DataSource
{
    private DataConsumer _dataConsumer = new DataConsumer();

    public override void GetData()
    {
        _dataConsumer.GetSpecificData();
    }
}
