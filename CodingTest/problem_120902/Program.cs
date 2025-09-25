using System.Data;

namespace problem_120902
{

    /// <summary>
    ///  2025년 9월 26일
    ///  문제 : my_string은 "3 + 5"처럼 문자열로 된 수식입니다. 문자열 my_string이 매개변수로 주어질 때, 
    ///  수식을 계산한 값을 return 하는 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120902

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
            string[] parts = my_string.Split(' ');

            // 1. 첫 번째 숫자로 결과를 초기화합니다.
            int result = int.Parse(parts[0]);

            // 2. 연산자들을 순회합니다 (i는 연산자의 위치: 1, 3, 5...)
            // parts.Length까지 반복하고, i+1을 접근하므로 i < parts.Length - 1 로 해도 됩니다.
            for (int i = 1; i < parts.Length; i += 2)
            {
                string op = parts[i];
                int nextNum = int.Parse(parts[i + 1]);

                if (op == "+")
                {
                    result += nextNum;
                }
                else // op == "-"
                {
                    result -= nextNum;
                }
            }

            return result;
        }
    }
}
