using System.Text;

namespace problem_120849
{

    /// <summary>
    ///  2025년 9월 9일
    ///  문제 : 영어에선 a, e, i, o, u 다섯 가지 알파벳을 모음으로 분류합니다. 
    ///  문자열 my_string이 매개변수로 주어질 때 모음을 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120849
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
        public string solution(string my_string)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in my_string)
            {
                if( c == 'a' || c == 'e' || c == 'i' || c == 'o' ||  c == 'u' )
                {
                    continue;
                }

                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
