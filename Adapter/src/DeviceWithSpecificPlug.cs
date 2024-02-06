using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    using System;

    
    public class DeviceWithSpecificPlug
    {
        public void PlugIntoSpecificOutlet()
        {
            Console.WriteLine("Plugged into a specific power outlet");
        }
    }

    

}
