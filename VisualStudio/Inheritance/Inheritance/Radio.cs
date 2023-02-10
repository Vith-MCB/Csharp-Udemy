using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
        }

        //Listen to the radio
        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                Console.WriteLine("The radio is off, switch it on to listen to the radio!");
            }
        }
    }
}
