namespace Adapter
{
   
    public class SpecificToStandardAdapter : IStandardPowerPlug
    {
        private readonly DeviceWithSpecificPlug device;

        public SpecificToStandardAdapter(DeviceWithSpecificPlug device)
        {
            this.device = device;
        }

        public void PlugIntoStandardOutlet()
        {
            
            device.PlugIntoSpecificOutlet();
        }
    }

}