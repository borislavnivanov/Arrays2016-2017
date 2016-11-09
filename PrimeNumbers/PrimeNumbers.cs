using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (i % j == 0 && i > result)
                    {
                        result = i;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
