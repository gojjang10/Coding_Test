namespace problem_120822
{

    /// <summary>
    ///  2025년 8월 4일
    ///  문제 : 문자열 my_string이 매개변수로 주어집니다. 
    ///  my_string을 거꾸로 뒤집은 문자열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120822
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
            string answer = "";
            char[] charArray = my_string.ToCharArray();
            Array.Reverse(charArray);
            answer = new string(charArray);

            return answer;
        }
    }
}
