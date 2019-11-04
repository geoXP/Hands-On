using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
