using System;

namespace SelectionSortAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //선택 정렬 알고리즘

            int[] data = { 3, 2, 1, 4, 5 };
            int N = data.Length;

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (data[i] > data[j])
                    {
                        int temp = data[j];
                        data[j] = data[i];
                        data[i] = temp;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{data[i]}");
            }
        }
    }
}
