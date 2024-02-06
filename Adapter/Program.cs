using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DeviceWithSpecificPlug specificPlugDevice = new DeviceWithSpecificPlug();

           
            IStandardPowerPlug powerPlugAdapter = new SpecificToStandardAdapter(specificPlugDevice);

            ElectronicDevice electronicDevice = new ElectronicDevice(powerPlugAdapter);
            electronicDevice.UseDevice();
        }
    }
}
