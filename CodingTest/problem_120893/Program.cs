using System.Text;

namespace problem_120893
{

    /// <summary>
    ///  2025년 9월 23일
    ///  문제 : 문자열 my_string이 매개변수로 주어질 때, 대문자는 소문자로 소문자는 대문자로 변환한 문자열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120893

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public string solution(string my_string)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in my_string)
            {
                if (char.IsUpper(c))
                {
                    sb.Append(char.ToLower(c));
                }
                else
                {
                    sb.Append(char.ToUpper(c));
                }
            }
            return sb.ToString();
        }
    }
}
