namespace problem_120905
{

    /// <summary>
    ///  2025년 9월 29일
    ///  문제 : 정수 n과 정수 배열 numlist가 매개변수로 주어질 때, 
    ///  numlist에서 n의 배수가 아닌 수들을 제거한 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120905

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int[] solution(int n, int[] numlist)
        {
            List<int> result = new List<int>();

            foreach (int num in numlist)
            {
                if (num % n == 0)
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }
    }
}
