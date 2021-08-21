using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Members
    {

        //member - private field
        private string membername;
        private string jobTitle;
        private int salary = 20000;

        //member - public field;
        public int age;



        //member - property - exposes jobTitle safely - "properties start with a capital letter"
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi there! my name is {0}, and my Job Title is {1}, and I am {2}", membername, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is {0}", salary);
        }

        public Members()
        {
            age = 30;
            membername = "Lucy";
            salary = 500000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            // clean up statements

            Console.WriteLine("Deconstruction of Memebers");
            Debug.Write("");
        }
    }
}
