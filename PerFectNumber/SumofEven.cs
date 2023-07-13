using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PerFectNumber
{
    public class SumofEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1; i <=num; i++)
            {
                if(i%2== 0)//if(i%2==1)
                {
                    sum=sum+i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}