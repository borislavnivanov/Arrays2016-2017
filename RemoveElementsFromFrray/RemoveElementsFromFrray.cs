﻿
using System;
using System.Collections.Generic;
using System.Linq;

namespace _18.RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nArray = new int[n];
            for (int i = 0; i <= nArray.Length - 1; i++)
            {
                nArray[i] = int.Parse(Console.ReadLine());
            }

            int[] LIS = new int[n];
            for (int i = 0; i <= LIS.Length - 1; i++)
            {
                LIS[i] = 1;
            }

            for (int masterIndex = 1; masterIndex < n; masterIndex++)
            {
                for (int subIndex = 0; subIndex < masterIndex; subIndex++)
                {
                    if ((nArray[masterIndex] >= nArray[subIndex]) && (LIS[subIndex] >= LIS[masterIndex]))
                    {
                        LIS[masterIndex] = LIS[subIndex] + 1;
                    }
                }
            }

            Array.Sort(LIS);
            int printResult = n - LIS[LIS.Length - 1];
            Console.WriteLine(printResult);
        }
    }
}
