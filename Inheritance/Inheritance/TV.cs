using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }

        //Watch TV
        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching to the TV!");
            }
            else
            {
                Console.WriteLine("The TV is off, switch it on to the watch!");
            }
        }
    }
}
