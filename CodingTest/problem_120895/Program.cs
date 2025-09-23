using System.Text;

namespace problem_120895
{

    /// <summary>
    ///  2025년 9월 24일
    ///  문제 : 문자열 my_string과 정수 num1, num2가 매개변수로 주어질 때, 
    ///  my_string에서 인덱스 num1과 인덱스 num2에 해당하는 문자를 바꾼 문자열을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120895

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public string solution(string my_string, int num1, int num2)
        {
            StringBuilder sb = new StringBuilder(my_string);
            char temp = sb[num1];
            sb[num1] = sb[num2];
            sb[num2] = temp;
            return sb.ToString();
        }
    }
}
