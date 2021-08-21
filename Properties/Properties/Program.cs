using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // BoxMakerControl();    
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();
         
        }

        public static void BoxMakerControl()
        {
            Console.WriteLine("Welcome to Box Maker: Give us dimension and we will calculate the volume!");
            Console.Write("Length: ");
            string length = Console.ReadLine();
            Console.Write("Width: ");
            string width = Console.ReadLine();
            Console.Write("Height: ");
            string height = Console.ReadLine();

            Box box1 = new Box();
            box1.Length = Int32.Parse(length);
            box1.Width = Int32.Parse(width);
            box1.Height = Int32.Parse(height);
            //box1.setLength(Int32.Parse(length));
            // box1.setHeight(Int32.Parse(width));
            // box1.setWidth(Int32.Parse(height));
            Console.WriteLine("The Final Volumne is! {0}", box1.getVolume());
            Console.Read();
        }
    }
}
