using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PerFectNumber
{
    public class SumOfNaturalNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1; i<=num; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
