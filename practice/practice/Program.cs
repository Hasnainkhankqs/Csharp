using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, total = 0 , count = 0;
            
            Console.Write("Input the limit of prime numbers: ");

            string num = Console.ReadLine();

            int number = Convert.ToInt32(num);

            for (a = 2 ; a <= number; a++)
            {
               
                for (b = 1; b <= a; b++)
                {
                    if(a % b == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write(" " + a + " ");
                    total++;
                }
                count = 0;

            }
            Console.Write("\n" + "The total number of prime number is : " + total);

            Console.ReadKey();
        }
    }
}
