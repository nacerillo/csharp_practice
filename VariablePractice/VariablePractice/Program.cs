using System;
//
namespace VariablePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            ///SUm of the primative data types
            int num1;
            int num2 = 23;
            num1 = 13;
            int sum = num1 + num2;
            //concatination
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dubdiv = d1 / d2;
            Console.WriteLine(dubdiv); //0.6159803921568628

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float floatdiv = f1 / f2;
            Console.WriteLine(floatdiv); // 0.6159804

            double dIDiv = d1 / num1;
            Console.WriteLine(dIDiv); // still a double;


            ////// STRINGS
            /// String is NOT a primative, it is a class

            string fname = "nicholas";
            string lname = "cerillo";
            Console.WriteLine("My name is " + fname + " " + lname);

            string name = "Nicholas Cerillo";
            string lower = name.ToLower();
            string upper = name.ToUpper();



            Console.Write("Take in some input:");
            string input = Console.ReadLine();
            Console.WriteLine("You have entered {0}", input);

            Console.Write("Enter another string: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey(); 

            //Console.Write("text") = prints and keeps cursor on the same line;
            //Console.WriteLine prints a new line;
            //ASCII American Standard Code for Information
            //Console.ReadLine() takes in a string and returns an output;
            //Console.Read() returns the reference to the input
            // Console.ReadKey() Takes in a type of string and returns the key info
            
        }
    }
}
