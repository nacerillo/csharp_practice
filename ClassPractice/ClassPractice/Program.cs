using System;

namespace ClassPractice
{
    // a class is a blueprint of an object
    // it has actions/abilites - so called member functions
    // it has properties
    // and it can be inherited

    // object:
    // - also has properties
    // 
    class Program
    {
        static void Main(string[] args)
        {
            //in instance of a human class
            Human denis = new Human("Jack", "Cerillo", 24, "blue");
            //how to access a public variable
            //denis.firstName = "Denis";
            //denis.lastName = "Haufman";

            Human nick = new Human("Nicholas", "Cerillo");
            //nick.firstName = "Nicholas";
            //nick.lastName = "Cerillo";
            denis.IntroduceMyself();
            nick.IntroduceMyself();
            Console.ReadKey();
           //Console.WriteLine("Hello World!");
        }
    }
}
