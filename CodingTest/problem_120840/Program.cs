namespace problem_120840
{

    /// <summary>
    ///  2025년 8월 25일
    ///  문제 : 머쓱이는 구슬을 친구들에게 나누어주려고 합니다. 구슬은 모두 다르게 생겼습니다. 
    ///  머쓱이가 갖고 있는 구슬의 개수 balls와 친구들에게 나누어 줄 구슬 개수 share이 매개변수로 주어질 때, 
    ///  balls개의 구슬 중 share개의 구슬을 고르는 가능한 모든 경우의 수를 return 하는 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120840
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
         public long solution(int balls, int share)
         {
            if (share == 0 || share == balls) return 1;

            if (share > balls - share) share = balls - share;

            long result = 1;
            for (int i = 1; i <= share; i++)
            {
                result = result * (balls - i + 1) / i;
            }
            return result;
         }

    }
}
