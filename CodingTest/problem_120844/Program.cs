namespace problem_120844
{

    /// <summary>
    ///  2025년 9월 1일
    ///  문제 : 정수가 담긴 배열 numbers와 문자열 direction가 매개변수로 주어집니다.
    ///  배열 numbers의 원소를 direction방향으로 한 칸씩 회전시킨 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120844
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
        public int[] solution(int[] numbers, string direction)
        {
            int[] answer = new int[numbers.Length];
            int index = 0;

            if(direction == "right")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    index = (i + 1) % numbers.Length;
                    answer[index] = numbers[i];
                }
            }
            else if(direction == "left")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    index = (i - 1 + numbers.Length) % numbers.Length;
                    answer[index] = numbers[i];
                }
            }
            return answer;
        }
    }
}
