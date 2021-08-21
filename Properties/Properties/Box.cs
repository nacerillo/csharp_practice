using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        private int length = 3;
        private int height = 3;
        private int width = 3;
        private int volume;

        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public int FrontSurface
        {
            get { return this.Height * this.Length; }
        }

        public int Volume
        {
            get
            {
                return this.Width * this.Height * this.Length;
            }
  
        }
        //ENCAPSULATION

        //GETTERS

       /* public int Height {

            get {
                return height;
            }

            set {
                 if (value < 0)
                {
                throw new Exception("Height must be positive");
                }
                height = value;
            }
        }

        public int Width {

            get {
            return width;
            } 

            set {
                if (value < 0)
                {
                throw new Exception("Width must be positive");
                }
                width = value;
            }
        }

        public int Length {

            get {
            return length;
            }

            set {
                if(value < 0)
                {
                throw new Exception("Length must be positive");
                }
                length = value;
            }
        }
         
      /*  public int getLength()
        {
            return this.length;
        }
        public int getHeight()
        {
            return this.height;
        }
        public int getWidth()
        {
            return this.width;
        }*/
       
        public int getVolume()
        {
            return this.Length * this.Height * this.Width;
        }

        //SETTERS
       /* public void setLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length must be positive");
            }
            this.length = length;
        }
        public void setHeight(int height)
        {
            if (height < 0)
            {
                throw new Exception("Height must be positive");
            }
            this.height = height;
        }
        public void setWidth(int width)
        {
            if (width < 0)
            {
                throw new Exception("Width must be positive");
            }
            this.width = width;
        }*/
        public void DisplayBoxProps()
        {
            Console.WriteLine("Length: ", length);
            Console.WriteLine("Height: ", height);
            Console.WriteLine("Width: ", width);
            Console.WriteLine("Volume: ", volume);

        }

        public static int calculateVolumen()
        {
            return 0;
        }

      
    }
}
