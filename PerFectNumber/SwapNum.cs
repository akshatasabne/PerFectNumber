using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PerFectNumber
{
    public class SwapNum
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter First Number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());

            //a=a+b;
            //b=a-b;
            //a = a-b;
            c= a;
            a = b;
            b= c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
