using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            float math, phy, chem, total, obtain, per;
            total = 300;
            Console.Write("Enter Marks for Math: ");
            math = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Marks for Physics: ");
            phy = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Marks for Chemistry: ");
            chem = Convert.ToInt16(Console.ReadLine());

            obtain = math + phy + chem;
            string grade = "";
            per = obtain / total * 100;
           
            
            if(per >= 80)
            {
                grade = "A +";
            }
            else if (per >= 70)
            {
                grade = "A";
            }
            else if(per >= 60)
            {
                grade = "B";
            }
            else if( per >= 50)
            {
                grade = "C";
            }
            if(per < 50)
            {
                grade = "Fail";
            }
            Console.WriteLine("Your obtain marks is: " + obtain);
            Console.WriteLine("Your percentage is: " + per);
            Console.Write("you are: " + grade);
            Console.ReadKey();
        }
    }
}
