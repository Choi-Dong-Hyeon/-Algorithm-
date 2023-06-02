using System;

namespace SumAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int _sum = default;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >= 80)
                {
                    _sum += scores[i];
                }

            }

            Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점: {_sum}");

        }
    }
}
