using System;


namespace MergeAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2개의 배열을 1나의 배열로 합친다
            //오름차순 정렬을 먼저 해야한다
            //정렬이 되어 있다 가정하고

            int[] first = { 1, 3, 5 };
            int[] second = { 2, 4 };
            int M = first.Length;
            int N = second.Length;
            int[] merge = new int[M + N];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < M && j < N)
            {
                if (first[i] <= second[j])
                {
                    merge[k++] = first[i++];
                }
                else
                {
                    merge[k++] = second[j++];
                }
            }

            while (i < M)
            {
                merge[k++] = first[i++];
            }

            while (j < N)
            {
                merge[k++] = second[j++];
            }


            foreach (int m in merge)
            {
                Console.Write($"{m}\t");
            }
            Console.WriteLine();

        }
    }
}
