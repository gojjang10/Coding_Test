using System.Text;

namespace problem_120888
{

    /// <summary>
    ///  2025년 9월 18일
    ///  문제 : 문자열 my_string이 매개변수로 주어집니다.
    ///  my_string에서 중복된 문자를 제거하고 하나의 문자만 남긴 문자열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120888

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
            List<char> letters = new List<char>();

            foreach (char c in my_string)
            {
                if(!letters.Contains(c))
                {
                    letters.Add(c);
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
