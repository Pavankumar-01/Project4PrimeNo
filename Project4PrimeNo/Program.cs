using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4PrimeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr= 0,i,n;
            Console.WriteLine("\nEnter a number to check : ");
            n = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    ctr++;
                }
            }
            if (ctr == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
