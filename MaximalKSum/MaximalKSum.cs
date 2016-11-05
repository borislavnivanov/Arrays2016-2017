using System;


namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = (array.Length - 1); i >= (array.Length - k); i--)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
