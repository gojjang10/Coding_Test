namespace problem_120851
{

    /// <summary>
    ///  2025년 9월 12일
    ///  문제 : 문자열 my_string이 매개변수로 주어집니다. my_string안의 모든 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120851
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
        public int solution(string my_string)
        {
            int result = 0;

            foreach (char c in my_string)
            {
                if(char.IsDigit(c))
                {
                    result += (c - '0');
                }
            }
            return result;
        }
    }
}
