using System;

namespace Structs
{

    /// <summary>
    /// differneces between struct and class:
    /// 
    /*
     Struct cannot have a default constructor (a constructor without parameters) or a destructor.
     Structs are value types and are copied on assignment.
     Structs are value types while classes are reference types.
     Structs can be instantiated without using a new operator.
     A struct cannot inherit from another struct or class, and it cannot be the base of a class. All structs inherit directly from System.ValueType, which inherits from System.Object.
     Struct cannot be a base class. So, Struct types cannot abstract and are always implicitly sealed.
     Abstract and sealed modifiers are not allowed and struct member cannot be protected or protected internals.
     Function members in a struct cannot be abstract or virtual, and the override modifier is allowed only to the override methods inherited from System.ValueType.
     Struct does not allow the instance field declarations to include variable initializers. But, static fields of a struct are allowed to include variable initializers.
     A struct can implement interfaces.
     A struct can be used as a nullable type and can be assigned a null valu
     */
    /// 
    /// NOTE: CAN have DEFINED Constructors
    /// 
    /// </summary>
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate){
             this.name = name;
             this.developer = developer;
             this.rating = rating;
             this.releaseDate = releaseDate; 
        }

        public void Display(){
            Console.WriteLine("Game 1's name is :{0}", name);
            Console.WriteLine("Game 1's developer is :{0}",developer);
            Console.WriteLine("Game 1's rationg was {0}/5", rating);
            Console.WriteLine("Game 1 was realesed on {0}", releaseDate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemen Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";
                          
            Console.WriteLine("Game 1's name is :{0}", game1.name);
            Console.WriteLine("Game 1's developer is :{0}", game1.developer);
            Console.WriteLine("Game 1's rationg was {0}/5", game1.rating);
            Console.WriteLine("Game 1 was realesed on {0}", game1.releaseDate);

            game1.Display();

        }
    }
}
