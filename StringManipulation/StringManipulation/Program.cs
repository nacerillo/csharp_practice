using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string myString1 = "Nicholas";
            string myString2 = "Cerillo";
            Console.WriteLine("My name is {0} {1}", myString1, myString2);

            //string interpulation 
            // string uses $ at the start which will allow us to write our 
            //variables like this {var}
            Console.WriteLine("String Interpulation");
            Console.WriteLine($"Hello my name is {myString1} {myString2}");

            //Verbatim Strings

            //putting @ in front of the string will tell the compiler to take in 
            // the string literally and ignore all spaces and escape characters like \n

            //useful for printing out file paths, ignoring things like \User\Admin\Data
            Console.WriteLine(@"ignore all of the spaces in this string");


            ///STRING METHODS
            ///
            string testString = "make me a substring";
            string subString = testString.Substring(10); //substring
            Console.WriteLine(subString);

            Console.WriteLine(testString.IndexOf("substring"));
            Console.WriteLine(String.IsNullOrWhiteSpace(testString));

            string fullName = string.Concat(myString1," ", myString2);
            Console.WriteLine(fullName);

            //String Format;
            Console.WriteLine(String.Format("Hello there, {1}", myString1, myString2));


            ///CHALLENGE1
            ///
            //string challengeString;
            /* Console.Write("Please Enter your First Name: ");
             challengeString = Console.ReadLine();

             string myNameToUpper = String.Format("Name Entered Successfully. Welcome {0}", challengeString.ToUpper());
             string myNameToLower = String.Format("Name Entered Successfully. Welcome {0}", challengeString.ToLower());
             string trimmedName = challengeString.Trim(); //trims white space from front and end of string. 
             Console.WriteLine(myNameToUpper);
             Console.WriteLine(myNameToLower);
             Console.WriteLine(trimmedName);*/

            string inputString;
            char inputChar;
            Console.Write("Enter a string: ");
            inputString = Console.ReadLine();
            Console.Write("Find a character in the string:");
            inputChar = Console.ReadLine()[0];
            bool doesStringContainChar = inputString.Contains(inputChar);
            Console.WriteLine(doesStringContainChar);

            Console.Read();

            
           
        }
    }
}
