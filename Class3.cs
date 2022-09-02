using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class3
    {
        static bool isPositive(int a)
        {
            return a>0;
        }
        public static void Main_()
        {
            int a;

            Console.WriteLine("Input Number : ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("0 is neither Positive Nor Negative");

            }

           else if (isPositive(a))
                Console.WriteLine("{0} is a Positive Integer", a);
            else
                Console.WriteLine("{0} is a Negative Integer", a);

            Console.ReadKey();

        }
    }
}
