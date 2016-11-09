using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int freqNumber = 0;
            int freqQTY = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                int tempN = array[i];
                int tempQTY = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        tempQTY++;
                    }
                }
                if (freqQTY < tempQTY)
                {
                    freqQTY = tempQTY;
                    freqNumber = tempN;
                }
            }
            Console.WriteLine("{0} ({1} times)", freqNumber, freqQTY);
        }
    }
}
