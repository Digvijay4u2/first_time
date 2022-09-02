using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class14
    {
       
        public static void Main_()
        {
            int a;

            Console.Write("Input Number of terms : ");
            a = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int number = 1;
            int sum = 0;
            Console.Write("The odd numbers are : ");
            while(count<a)
            {
                Console.Write(number+" ");
                sum += number;
                number += 2;
                count++;
                
            }
            Console.WriteLine("\nThe sum of odd Natural number upto {0} terms : {1}", a, sum);
            

            Console.ReadKey();

        }
    }
}
