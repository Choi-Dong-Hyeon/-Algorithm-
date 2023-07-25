using System;

namespace BinarySearchAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[1] 정렬이 되어 있어야 한다
            //주어진 데이터에서 원하는 데이터 찾기

            int[] data = { 1, 3, 5, 7, 9 }; //정렬 되었다고 가정 하고
            int N = data.Length;
            int search = 9;
            bool flag = default;
            int index = -1;

            int low = 0;
            int high = N - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (data[mid] == search)
                {
                    flag = true;
                    index = mid;
                    break;
                }
                if (data[mid] > search)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }



            if (flag)
            {
                Console.WriteLine($"{search}을 {index}위치에서 찾았습니다.");
            }
            else
            {
                Console.WriteLine("찾지 못했습니다.");
            }

        }
    }
}
