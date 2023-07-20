using System;

namespace MinAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //주어진 자료들 중 가장 작은 값

            int min = int.MaxValue;

            int[] numbers = { -2, -5, -3, -1, -7 };


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine(min);

        }
    }
}
