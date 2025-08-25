using System.Text;

namespace problem_120839
{

    /// <summary>
    ///  2025년 8월 25일
    ///  문제 : 가위는 2 바위는 0 보는 5로 표현합니다. 가위 바위 보를 내는 순서대로 나타낸 문자열 rsp가 매개변수로 주어질 때, 
    ///  rsp에 저장된 가위 바위 보를 모두 이기는 경우를 순서대로 나타낸 문자열을 return하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120839
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
        public string solution(string rsp)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in rsp)
            {
                if (c == '2')
                {
                    sb.Append('0');
                }
                else if (c == '0')
                {
                    sb.Append('5');
                }
                else if (c == '5')
                {
                    sb.Append('2');
                }
            }
            
            return sb.ToString();
        }
    }
}
