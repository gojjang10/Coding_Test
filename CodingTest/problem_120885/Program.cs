namespace problem_120885
{

    /// <summary>
    ///  2026년 5월 27일
    ///  문제 : 이진수를 의미하는 두 개의 문자열 bin1과 bin2가 매개변수로 주어질 때, 두 이진수의 합을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120885

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public string solution(string bin1, string bin2)
        {
            int sum = Convert.ToInt32(bin1, 2) + Convert.ToInt32(bin2, 2);

            // 합을 다시 이진수로 변환하여 반환
            return Convert.ToString(sum, 2);
        }
    }
}
