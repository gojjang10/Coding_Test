namespace problem_120923
{

    /// <summary>
    ///  2026년 6월 8일
    ///  문제 : 연속된 세 개의 정수를 더해 12가 되는 경우는 3, 4, 5입니다. 두 정수 num과 total이 주어집니다. 
    ///  연속된 수 num개를 더한 값이 total이 될 때, 정수 배열을 오름차순으로 담아 return하도록 solution함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120923

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int[] solution(int num, int total)
        {
            int[] answer = new int[num];

            int sum = (num -1) * num / 2;
            int start = (total - sum) / num;

            for(int i = 0; i < num; i++)
            {
                answer[i] = start + i;
            }
            return answer;
        }
    }
}
