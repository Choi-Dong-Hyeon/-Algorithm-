using System;

namespace NearAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //근삿값 가까운 값 찾기

            int Abs(int number) => (number < 0) ? -number : number;

            int[] numbers = { 10, 20, 30, 27, 17 };

            int min = int.MaxValue;
            int target = 25;
            int near = default;


            for (int i = 0; i < numbers.Length; i++)
            {
                int abs = Abs(numbers[i] - target);

                if (abs < min)
                {
                    min = abs; 
                    near = numbers[i];
                }
            }

            Console.WriteLine($"{target}과 가까운 값{near} (차이값){min}");

        }
    }
}
