namespace problem_120817
{

    /// <summary>
    ///  2025년 8월 1일
    ///  문제 : 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120817
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
        public double solution(int[] numbers)
        {
            double answer = 0;

            int totalNumbersValue = 0;
            int totalNumbers = numbers.Length;

            foreach (int i  in numbers)
            {
                totalNumbersValue += i;
            }

            answer = (double) totalNumbersValue / totalNumbers;
            
            return answer;
        }
    }
}
