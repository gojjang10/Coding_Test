namespace problem_120906
{

    /// <summary>
    ///  2025년 9월 29일
    ///  문제 : 정수 n이 매개변수로 주어질 때 n의 각 자리 숫자의 합을 return하도록 solution 함수를 완성해주세요
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120906

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

            string nStr = n.ToString();
            char[] chars = nStr.ToCharArray();

            foreach (char c in chars)
            {
                // 자동으로 형변환 이루어짐
                answer += (c - '0');
            }

            return answer;
        }
    }
}
