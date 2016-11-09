using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool result = false;
            while (!result)
            {
                result = IsPrime(n);
                n--;
            }
            Console.WriteLine(n + 1);
        }
        public static bool IsPrime(int n)
        {
            int checker = 2;

            while ((checker < n) & (n % checker != 0))
            {
                checker++;
            }
            if (checker == n)
                return true;
            else
                return false;
        }
    }
}
