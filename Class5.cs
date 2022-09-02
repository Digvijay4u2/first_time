using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class5
    {
        static bool isEligible(int a)
        {
            return a >= 18 ;
        }
        public static void Main_()
        {
            int a;

            Console.WriteLine("Input Number : ");
            a = Convert.ToInt32(Console.ReadLine());




            if (isEligible(a))
                Console.WriteLine("congratulation! You are eligible for casting your vote.");
            else
                Console.WriteLine("Oops! You are Not eligible for casting your vote.");

            Console.ReadKey();

        }
    }
}
