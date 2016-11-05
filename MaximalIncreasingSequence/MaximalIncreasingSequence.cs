using System;


namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            double[] array = new double[size];
            int sequence = 1;
            int bestSequence = 0;

            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    sequence++;
                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                    }
                }
                else
                {
                    sequence = 1;
                }
            }
            Console.WriteLine(bestSequence);
        }
    }
}
