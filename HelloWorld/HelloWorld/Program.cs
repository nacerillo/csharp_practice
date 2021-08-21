using System;
// System contains a bunch of classes
// 
namespace HelloWorld
{
    class Program
    {

        // Main = Entry point of any program
        static void Main(string[] args)
        {
            //same as console.log from JS
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Nicholas!");
            //Console.Read reads next charcter for the console input stream
            //keeps the application open until input is given to the console.

            //undefined int will output zero;
            int myNumber = 5;
            string hello = "hello";
            //float can be used to be an decimal number. must use the F or f suffix;

            float pi = 3.1415f;
            char a = 'a'; 
            bool boolean = true;



            //PRIMATIVE DATA TYPES
            //use these different data types depeneidng on how much space you will need. 
            //Sbyte
            //can be whole numbers from -128 to 127;
            sbyte x = 120;

            //short
            // whole numbers from -32767 to 32767;
            short y = 20000;

            //INT
            //can store from -2.147 Billion t0 2.147 Billion
            int z = 1000000;

            //LONG 
            //can stor -9 billion-billion to 9 billion-billion
            long l = 10000000000;


            //FLOAT;
            //7 digit percision
            // can range from 1.5x10^-45 to 3.4x10^34
            float b = 99.99f;


            //DOUBLE
            // even higher range than floats;
            // 15-digit percision;
            double dd = 1.5;
            Console.Read();


            //DECIMAL 
            //higher than double
            //28-digit percision;
            double dec = 1.4;

            
            //variables must have types and data. 

        }
    }
}
