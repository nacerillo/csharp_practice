using System;

namespace MethodsAndFunctions
{
    class Program
    {
       
        static void Main(string[] args)
        {
            /*   Console.WriteLine("Hello World!");
               Add(2, 2);
               Console.WriteLine(Multiply(6, 3));
               GreetFriend("Ryan Wolf");
               Console.Read();*/
            getUserInput();
        }

        public static void Add(int num1, int num2)
        {
            Console.WriteLine( num1 + num2);
           
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static void GreetFriend(string friend)
        {
            Console.WriteLine(friend);
        }

        public static void getUserInput()
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int convertedInput = int.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input was not a number");
                Console.WriteLine("Please Enter Valid Input");

                getUserInput();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input was too large");
                Console.WriteLine("Please Enter Valid Input");
                getUserInput();
            }
            finally
            {
                Console.ReadKey();
            }
        }

    }
}
