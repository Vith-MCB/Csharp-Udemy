using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ElectricalDevice
    {
        //Parent class

        //Boolean to determine the state of the radio
        public bool IsOn { get; set; }

        //String for the brand of the radio
        public string Brand { get; set; }

        //Constructor of the radio
        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        //Switch the radio
        public void SwitchOn()
        {
            Console.WriteLine("\nTurning defice ON\n");
            IsOn = true;
        }
        public void SwitchOff()
        {
            Console.WriteLine("\nTurning defice OFF\n");
            IsOn = false;
        }
    }
}
