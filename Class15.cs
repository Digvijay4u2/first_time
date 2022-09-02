using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class15
    {
        public static void Main_()
        {
            int a;

            Console.Write("Enter the number : ");
            a = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=a;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
