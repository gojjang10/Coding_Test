namespace problem_120820
{
    /// <summary>
    ///  2025년 8월 3일
    ///  문제 :머쓱이는 선생님이 몇 년도에 태어났는지 궁금해졌습니다. 
    ///  2022년 기준 선생님의 나이 age가 주어질 때, 선생님의 출생 연도를 return 하는 solution 함수를 완성해주세요
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120820
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
        public int solution(int age)
        {
            int answer = 2022;

            answer = answer - age + 1;

            return answer;
        }
    }

}
