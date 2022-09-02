using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class6
    {
        
        public static void Main_()
        {
            int a;

            Console.WriteLine("Enter your height in centimeter: ");
            a = Convert.ToInt32(Console.ReadLine());




            if (a < 150)
                Console.WriteLine("The Person is Dwarf");
            else if (a >= 150 && a < 180)
                Console.WriteLine("The person is having Average height");
            else
                Console.WriteLine("The person is taller");

            Console.ReadKey();

        }
    }
}
