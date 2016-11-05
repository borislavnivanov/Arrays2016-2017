using System;
using System.Linq;


namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] inputOne = Console.ReadLine().ToCharArray();
            char[] inputTwo = Console.ReadLine().ToCharArray();
            int lengthComp = inputOne.Length.CompareTo(inputTwo.Length);

            if (lengthComp > 0)
            {
                Console.WriteLine(">");
            }
            else if (lengthComp == 0)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine("<");
            }
        }
    }
}
