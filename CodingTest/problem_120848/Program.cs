namespace problem_120848
{

    /// <summary>
    ///  2025년 9월 4일
    ///  문제 : i팩토리얼 (i!)은 1부터 i까지 정수의 곱을 의미합니다. 
    ///  예를들어 5! = 5 * 4 * 3 * 2 * 1 = 120 입니다. 정수 n이 주어질 때 다음 조건을 만족하는 가장 큰 정수 i를 return 하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120848
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
            for (int i = 1; ; i++)
            {
                if (Factorial(i) == n)
                {
                    return i;
                }
                else if (Factorial(i) >= n)
                {
                    return i - 1;
                }

            }
        }

        public int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

    }
}
