using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_08_18Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            softeng getname = new softeng();
            getname.exe_fun();
            Console.ReadKey();
        }
    }
    class Hr{
        public void get_employes()
        {
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
    class softeng
    {
        public void exe_fun()
        {
            Hr obj = new Hr();
            obj.get_employes();

            Hr obj2 = new Hr();
            obj2.get_employes();

            Hr obj3 = new Hr();
            obj3.get_employes();
        }
    }
}
