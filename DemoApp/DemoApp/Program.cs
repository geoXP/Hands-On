using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            string firstName = "James";
            string lastName = "Leo";

            person.FirstName = firstName;
            person.LastName = lastName;
             
            string fullName = person.GetFullName();
            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
