using System;


namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] inputOne = Console.ReadLine().ToCharArray();
            char[] inputTwo = Console.ReadLine().ToCharArray();

            for (int i = 0; i < Math.Min(inputOne.Length, inputTwo.Length); i++)
            {
                if (inputOne[i] < inputTwo[i])
                {
                    Console.WriteLine("<");
                    return;
                }
                else if (inputOne[i] > inputTwo[i])
                {
                    Console.WriteLine(">");
                    return;
                }
            }
            if (inputOne.Length == inputTwo.Length)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine(inputOne.Length < inputTwo.Length ? "<" : ">");
            }
        }
    }
}
