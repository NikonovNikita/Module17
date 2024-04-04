namespace SOLID.DependencyInversionPrinciple
{
    internal class VideoAdapter
    {
        IHdmi device;
        public VideoAdapter(IHdmi hdmiDevice)
        {
            device = hdmiDevice;
        }

        public void Display(string text)
        {
            device.Display(text);
        }
    }
}
