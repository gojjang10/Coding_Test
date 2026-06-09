namespace problem_120924
{
    /// <summary>
    ///  2026년 6월 9일
    ///  문제 : 등차수열 혹은 등비수열 common이 매개변수로 주어질 때, 마지막 원소 다음으로 올 숫자를 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120924

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int[] common)
        {
            int answer = 0;
            // 1. 등차수열인지 판단
            if(common[1] - common[0] == common[2] - common[1])
            {
                answer = common.Last() + (common[1] - common[0]);
            }
            // 2. 문제에서 무조건 등차수열과 등비수열로만 구성된 매개변수를 입력받는다는 조항이 있기에 배재하는 조건문
            else
            {
                answer = common.Last() * (common[1] / common[0]);
            }
            return answer;
        }
    }
}
