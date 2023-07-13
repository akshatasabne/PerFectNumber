using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFectNumber
{
    public class PrimeNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)

                {
                    sum++;
                }
            }
                if (sum == 2)
                {
                    Console.WriteLine("Number is Prime");
                }
                else
                {
                    Console.WriteLine("Number is not Prime");
                }
            
        }
    }
}
