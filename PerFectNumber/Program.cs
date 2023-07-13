using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFectNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            //perfect Number
            int num, temp, sum = 0;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            temp = num;
            for(int i = 0; i < num; i++)
            {
                if(num% i == 0)
                {
                    sum=sum+i;
                }
            }
            if(sum == num)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }
        }
    }
}

