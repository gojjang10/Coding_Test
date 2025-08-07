namespace problem_120826
{

    /// <summary>
    ///  2025년 8월 7일
    ///  문제 : 문자열 my_string과 문자 letter이 매개변수로 주어집니다.
    ///  my_string에서 letter를 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120826
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
        public string solution(string my_string, string letter)
        {
            return my_string.Replace(letter, "");
        }
    }

}
