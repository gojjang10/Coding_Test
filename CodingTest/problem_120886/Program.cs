namespace problem_120886
{

    /// <summary>
    ///  2026년 5월 28일
    ///  문제 : 문자열 before와 after가 매개변수로 주어질 때, before의 순서를 바꾸어 after를 만들 수 있으면 1을, 만들 수 없으면 0을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120886

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(string before, string after)
        {
            int answer = 0;

            string sortedBefore = new string(before.OrderBy(c => c).ToArray());
            string sortedAfter = new string(after.OrderBy(c => c).ToArray());

            if (sortedBefore == sortedAfter)
            {
                answer = 1;
            }
            return answer;
        }
    }
}
