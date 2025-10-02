namespace problem_120911
{

    /// <summary>
    ///  2025년 10월 3일
    ///  문제 : 영어 대소문자로 이루어진 문자열 my_string이 매개변수로 주어질 때,
    ///  my_string을 모두 소문자로 바꾸고 알파벳 순서대로 정렬한 문자열을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120911

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
            return string.Concat(my_string.ToLower().OrderBy(x => x));
        }
    }
}
