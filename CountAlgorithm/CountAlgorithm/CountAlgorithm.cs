
using System.Linq;

internal class CountAlgorithm
{
    static void Main(string[] args)
    {
        //[?] 1부터 1000까지의 정수 중 13의 배수의 개수

        int[] _numbers = Enumerable.Range(1, 1000).ToArray();
        int _count = default;

        for (int i = 0; i < _numbers.Length; i++)
        {
            if (_numbers[i] % 13 == 0)
            {
                _count++;
            }
        }

        System.Console.WriteLine(_count);
    }
}

