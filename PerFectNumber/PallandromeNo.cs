using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFectNumber
{
    public class PallandromeNo
    {
        static void Main(string[] args)
        {
            int num, rem, sum=0, temp;
            Console.WriteLine("Accept Number");
            num=Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num > 0)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Number  is Pallandrome");
            }
            else
            {
                Console.WriteLine("Number is not Pallandrome");
            }
        }
    }
}
