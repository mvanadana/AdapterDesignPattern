using System;
namespace Adapter
{ 
    
    public class ElectronicDevice
    {
        private readonly IStandardPowerPlug powerPlug;

        public ElectronicDevice(IStandardPowerPlug powerPlug)
        {
            this.powerPlug = powerPlug;
        }

        public void UseDevice()
        {
            Console.WriteLine("Using the electronic device...");
            powerPlug.PlugIntoStandardOutlet();
        }
    }
}