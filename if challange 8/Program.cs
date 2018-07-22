using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_challange_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = 8;

            if (myvar > 10)
            {
                Console.WriteLine("My Variable is greater than 10");
            }
            else
            {
                Console.WriteLine("My Varaible is less than 10");
           
            }

            int myvar1 = 10, myvar2 = 5, myvar3 = 9;

            if ((myvar1 < 11) || ((myvar2 == 5) && (myvar3 >= 8)))
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false"); }
                    

            if ((myvar1 < 11) || ((myvar2 == 6) && (myvar3 >= 8)))

            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }



            Console.ReadKey();
        }
    }
}
