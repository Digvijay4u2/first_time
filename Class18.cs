using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class18
    {
        public static void Main_()
        {
            int a;

            Console.Write("Enter the number : ");
            a = Convert.ToInt32(Console.ReadLine());
            int temp = 1;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ",temp);
                    temp++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
