using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PerFectNumber
{
    public class Fibnoccoseries
    {
        static void Main(string[] args)
        {
            int num, t1 = 0, t2 = 1, t3;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            t3 = t1 + t2;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(t3);
                t1 = t2;
                t2 = t3;
                t3 = t1 + t2;
                
            }

        }

    }
}
