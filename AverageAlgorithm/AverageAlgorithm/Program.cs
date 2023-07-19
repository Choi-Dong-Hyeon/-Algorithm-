namespace AverageAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //80점 이상 95점 이하인 점수의 평균

            int[] data = { 90, 65, 78, 50, 95 };
            int sum = default;
            int count = default;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 80 && data[i] < 95)
                {
                    sum += data[i];
                    count++;
                }
            }

            System.Console.WriteLine(sum/count);
        }
    }
}
