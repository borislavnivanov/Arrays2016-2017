using System;


namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }
            bool compare = true;
            for (int i = 0; i < n; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    compare = false;
                }
            }
            if (compare == false)
            {
                Console.WriteLine("Not equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
