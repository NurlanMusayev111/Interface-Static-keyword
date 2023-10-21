using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    public class Customer
    {
        static int  count = 0;

        public Customer()
        {
            count++;
        }


        public static void GetCount()
        {
            Console.WriteLine(count);
        }
    }
}
