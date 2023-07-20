namespace MaxAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //주어진 자료들 중 가장 큰 값

            int max = int.MinValue;

            int[] numbers = { -2, -5, -3, -7, -1, 8 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            System.Console.WriteLine(max);
        }
    }
}
