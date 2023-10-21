using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    public  class Person
    {

        static Person()
        {
            Console.WriteLine("Static constructor working");
        }

        public Person()
        {
            Console.WriteLine("Non-static constructor working");
        }
        public static string Name { get; set; }

        public static void ShowText()
        {
            Console.WriteLine("Show text");
        }
    }
}
