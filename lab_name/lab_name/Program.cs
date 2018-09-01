using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_name
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, num, count = 0;
            Console.WriteLine("give number to check wheter prime or not");
            num =Convert.ToInt32(Console.ReadLine());

            for( a = 2; a <= num; a++)
            {
                count = 0;
                if (num % a == 0)
                {
                    count++;
                }
                
            }
            if (count == 2)
            {
                Console.WriteLine("the number " + num + " is prime");
                
            }



            Console.ReadKey();
        }
    }
}
