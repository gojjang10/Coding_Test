namespace problem_120833
{

    /// <summary>
    ///  2025년 8월 9일
    ///  문제 : 정수 배열 numbers와 정수 num1, num2가 매개변수로 주어질 때, 
    ///  numbers의 num1번 째 인덱스부터 num2번째 인덱스까지 자른 정수 배열을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120833
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
        public int[] solution(int[] numbers, int num1, int num2)
        {
            int[] answer = new int[num2 - num1 +1];
            int k = num2 - num1;

            for (int i = 0 ; i <= k ; i++)
            {
                answer[i] = numbers[num1];
                num1++;
            }

            return answer;
        }
    }
}
