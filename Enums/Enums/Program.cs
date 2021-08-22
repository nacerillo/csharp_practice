using System;

namespace Enums
{
    // ENUM = A value type defined by a set of named constants of the underlying integral numeric type. 
    enum Day { Mon, Tue, Wed, Thr, Fri, Sat, Sun};
    enum Months { Jan = 1, Feb = 2, Mar = 3, Apr = 4, May = 5, Jun = 6, Jul = 7, Aug = 8, Sep = 9, Oct = 10, Nov = 11, Dec = 12};

    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fri;
            Day su = Day.Sun;
            Day x = Day.Fri;

            Console.WriteLine(fr == x); //
            Console.WriteLine(Day.Mon); // can grab the value
            Console.WriteLine((int)Day.Mon); // can get index of the value in the enumeration

            Console.WriteLine(Months.Feb);
            Console.WriteLine((int)Months.Feb); // can reassign the index of an item;
        }
    }
}
