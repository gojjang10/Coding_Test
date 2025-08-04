namespace problem_120821
{

    /// <summary>
    ///  2025년 8월 4일
    ///  문제 : 정수가 들어 있는 배열 num_list가 매개변수로 주어집니다. 
    ///  num_list의 원소의 순서를 거꾸로 뒤집은 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120821
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
            int[] answer = new int[num_list.Length];
            int k = 0;

            for (int i = num_list.Length - 1; i >= 0; i-- )
            {
                answer[k] = num_list[i];
                k++;
            }

            return answer;
        }
    }
}
