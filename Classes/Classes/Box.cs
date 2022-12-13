using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Box
    {
        private int length;
        private int height;
        private int width;
        private int volume;

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }



        public int Width {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    width = -value;
                }
                else { width = value; }

            }
        }

        public int Height
        {
            get { return height; }
            set { 
                if(value < 0)
                {
                    height = -value;
                } else { height = value; }
                
            }
        }

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0!");
            }
            this.length = length;
        }

        public int GetLength() { return this.length; }

        public int Volume {
            get { 
                return this.height * this.width * this.length; 
            }

        }

        public int FrontSurface
        {
            get { return height * length; }
        }

        /*
        public int GetVolume()
        {
            return this.height * this.width * this.length;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine("Length: {0} // Height: {1} // width: {2} // volume: {3}", length, height, width, volume = length * height * width);
        }
        */

    }
}
