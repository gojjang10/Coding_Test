namespace problem_120887
{

    /// <summary>
    ///  2026년 5월 28일
    ///  문제 : 1부터 13까지의 수에서, 1은 1, 10, 11, 12, 13 이렇게 총 6번 등장합니다. 정수 i, j, k가 매개변수로 주어질 때,
    ///  i부터 j까지 k가 몇 번 등장하는지 return 하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120887

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int i, int j, int k)
        {
            char target = k.ToString()[0];
            int count = 0;

            for(; i <= j; i++)
            {
                string numberStr = i.ToString();
                for(int x = 0; x < numberStr.Length; x++)
                {
                    if (numberStr[x] == target)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

}
