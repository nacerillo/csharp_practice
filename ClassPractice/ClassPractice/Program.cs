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

    //ACCESS MODIFIERS
    // private = only accessble inside of parent class
    // protected = only accessible inside of parent and child class
    // public = accessible to all 
    // internal = only accessible inside its own assembly (Project)
    // protected internal = accessible inside assembly or in children. 
    // private protected = access inside the containg class, or in the children
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
