namespace problem_120890
{

    /// <summary>
    ///  2025년 9월 23일
    ///  문제 : 정수 배열 array와 정수 n이 매개변수로 주어질 때, 
    ///  array에 들어있는 정수 중 n과 가장 가까운 수를 return 하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120890


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
            int closeNum = int.MaxValue;
            int result = 0;

            foreach (int num in array)
            {
                if (Math.Abs(num - n) < closeNum)
                {
                    closeNum = Math.Abs(num - n);

                    result = num;
                }

                else if (Math.Abs(num - n) == closeNum && num < result)
                {
                    result = num;
                }
            }
            return result;
        }
    }
}
