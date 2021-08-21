using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    //blueprint for a data type
    class Human
    {
        //member variable
        private string firstName;
        private string lastName = "Harris";
        private int age;
        private string eyeColor;

        //constructor = 
        public Human(string firstName, string lastName, int age, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }


        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hello there! my name is {0} {1}, and I am {2} years old", firstName, lastName, age);
        }

    }
}
