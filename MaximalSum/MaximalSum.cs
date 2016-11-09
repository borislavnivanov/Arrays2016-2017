using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaxSumSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }  


            Console.WriteLine(GetBestSequence(numbers));
     }

    private static string GetBestSequence(int[] numbers)
    {
        
        int tempSum = 0;
        int bestSum = 0;
        StringBuilder sequenceJoined = new StringBuilder();
        List<int> sequence = new List<int>();

        foreach (var number in numbers)
        {
            sequence.Add(number);
            tempSum += number;
            if (tempSum <= 0)
            {
                tempSum = 0;
                sequence.Clear();
            }
            else if (tempSum > bestSum)
            {
                bestSum = tempSum;
                //sequenceJoined.Clear().AppendLine("{" + string.Join(", ", sequence) + "}");
                //sequenceJoined.AppendLine(bestSum.ToString());
            }
        }

        return bestSum.ToString();
    }
}
