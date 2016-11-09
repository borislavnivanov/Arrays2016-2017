using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int number = int.Parse(Console.ReadLine());
            int index = GetIndex(numbers, number, 0, numbers.Length - 1);
            Console.WriteLine(index);
        }

        private static int GetIndex(int[] numbers, int number, int low, int high)
        {
            if (high < low)
                return -1;

            int mid = (low + high) / 2;

            if (numbers[mid] < number)
                return GetIndex(numbers, number, mid + 1, high);
            else if (numbers[mid] > number)
                return GetIndex(numbers, number, low, mid - 1);
            else
                return mid;
        }

        /*for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == search)
            {
                Console.WriteLine(i);
            }*/
    }
}

