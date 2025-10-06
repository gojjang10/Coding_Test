namespace problem_120583
{

    /// <summary>
    ///  2025년 10월 6일
    ///  문제 : 정수가 담긴 배열 array와 정수 n이 매개변수로 주어질 때, array에 n이 몇 개 있는 지를 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120583

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int[] array, int n)
        {
            int count = 0;

            foreach (int num in array)
            {
                if ( num == n ) count++;
            }
            return count;
        }
    }
}
