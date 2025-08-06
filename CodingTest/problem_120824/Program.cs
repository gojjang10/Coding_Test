namespace problem_120824
{

    /// <summary>
    ///  2025년 8월 5일
    ///  문제 : 정수가 담긴 리스트 num_list가 주어질 때, 
    ///  num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120824
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
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[2];

            foreach (int i in num_list)
            {
                if( i % 2 == 0 )
                {
                    answer[0]++;
                }
                else
                {
                    answer[1]++;
                }
            }

            return answer;
        }
    }
}
