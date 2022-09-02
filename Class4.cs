using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class4
    {
        static bool isLeapYear(int a)
        {
            if ((a % 4 == 0 && a % 100 != 0) || a % 400==0)
                return true;
            else
                return false;
        }
        public static void Main_()
        {
            int a;

            Console.WriteLine("Enter the Year : ");
            a = Convert.ToInt32(Console.ReadLine());




            if (isLeapYear(a))
                Console.WriteLine("{0} is a leap year", a);
            else
                Console.WriteLine("{0} is not a leap year", a);

            Console.ReadKey();

        }
    }
}
