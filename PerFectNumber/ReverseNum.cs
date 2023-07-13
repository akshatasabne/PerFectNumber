using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFectNumber
{
    public class ReverseNum
    {
        static void Main(string[] args)
        {
            int num, rev = 0, rem;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            while(num!=0)
            {
                rem = num % 10;
                rev=rev*10+rem;
                num=num/10;
            }
            Console.WriteLine(rev);
        }
    }
}
