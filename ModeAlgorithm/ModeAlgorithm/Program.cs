using System;

namespace ModeAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //최빈값 알고리즘
            //주어진 데이터에서 가장 많이 나온(중복된) 데이터값 찾기

            int[] score = { 1, 3, 4, 3, 5 };
            int[] indexes = new int[5 + 1];
            int max = int.MinValue;
            int mode = 0;

            for (int i = 0; i < score.Length; i++)
            {
                indexes[score[i]]++;
            }
            for(int i=0; i < indexes.Length; i++)
            {
                if (indexes[i] > max)
                {
                    max = indexes[i];
                    mode = i;
                }
            }

            Console.WriteLine($"최빈값 : {mode} - {max}번 나타남");

        }
    }
}
