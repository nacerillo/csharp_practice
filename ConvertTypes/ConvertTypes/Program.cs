using System;

namespace ConvertTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;
            //explicit conversion
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            //implicit conversion
            int num = 12344566;
            long bigNum = num;

            float myFloat = 13.37F;
            double newDouble = myFloat;


            //type conversion
            string myString = myDouble.ToString();
            Console.WriteLine(myString);
            string myFloatString = myFloat.ToString();
            Console.WriteLine(myFloatString);


            bool isSunOut = true;
            string sunny = isSunOut.ToString();
            Console.WriteLine(sunny);



            //// Parsing String To Int
            string num1 = "13a";
            string num2 = "14";

            int parsedNum1 = Int32.Parse(num1);
            int parsedNum2 = Int32.Parse(num2);
            Console.WriteLine(parsedNum1 + parsedNum2);
            Console.Read();
        }
    }
}
