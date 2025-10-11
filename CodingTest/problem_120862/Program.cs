namespace problem_120862
{

    /// <summary>
    ///  2025년 10월 11일
    ///  문제 : 정수 배열 numbers가 매개변수로 주어집니다. 
    ///  numbers의 원소 중 두 개를 곱해 만들 수 있는 최댓값을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120862

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int[] numbers)
        {
            Array.Sort(numbers);

            int n = numbers.Length;

            int productFromStart = numbers[0] * numbers[1];

            int productFromEnd = numbers[n - 1] * numbers[n - 2];

            return Math.Max(productFromStart, productFromEnd);
        }
    }
}
