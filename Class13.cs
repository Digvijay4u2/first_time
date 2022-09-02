using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class13
    {
        
        public static void Main_()
        {
            int a;
           

            Console.Write("Input upto the table number starting from 1 : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nMultiplication table from 1 to {0}\n", a);

            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=a;j++)
                {

                    Console.Write("{0}*{1} = {2},   ", j, i, i * j);
                }
                Console.WriteLine();
            }


            

            Console.ReadKey();

        }
    }
}
