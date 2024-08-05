namespace problem_120805
{
    /// <summary>
    ///  2024년 8월 5일
    ///  문제 : 정수 num1, num2가 매개변수로 주어질 때, num1을 num2로 나눈 몫을 return 하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120805
    /// </summary>
    public class Solution
    {
        public int solution(int num1, int num2)
        {
            if(num1 > 0 && num1 <= 100 && num2 > 0 && num2 <= 100)
            {
                int answer = 0;
                answer = num1 / num2;
                return answer;
            }
            return 0;
        }
    }
}
