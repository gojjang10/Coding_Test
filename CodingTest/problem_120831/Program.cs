namespace problem_120831
{

    /// <summary>
    ///  2025년 8월 9일
    ///  문제 : 정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120831
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
        public int solution(int n)
        {
            int answer = 0;

            for(int i = 0; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    answer += i;
                }
                else
                {
                    continue;
                }
            }

            return answer;
        }
    }
}
