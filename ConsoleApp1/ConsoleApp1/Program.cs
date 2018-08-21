using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //members variables
        //static string name, fatherName, CNIC;
        //static int 
        
        static void Main(string[] args)
        {
            Console.Write("\n Write your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Gender");
            string gender = Console.ReadLine();
            Console.Write("\n Write your father name:");
            string fname = Console.ReadLine();
            Console.Write("\n Write your CNiC: ");
            string cnic = Console.ReadLine();
            Console.Write("\n Write your Math marks: ");
            string math = Console.ReadLine();
            int mathnum = Convert.ToInt32(math);
            Console.Write("\n Write your Physics marks:");
            string phy = Console.ReadLine();
            int phynum = Convert.ToInt32(phy);

            int total = mathnum + phynum;
            Console.WriteLine("\n Hellow " + name + " " + fname +"\n" + "\nYour CNIC is " 
                + cnic +"\n"+"Congratulations you got " + "\n Total marks " + total);

        }
    }
}
