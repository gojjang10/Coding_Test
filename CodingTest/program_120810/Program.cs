namespace program_120810
{
    /// <summary>
    ///  2024년 8월 7일
    ///  문제 : 정수 num1, num2가 매개변수로 주어질 때,
    ///  num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120810
    /// </summary>
    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = -1;
            if (num1 > 0 && num1 <= 100 &&
                num2 > 0 && num2 <= 100)
            {
                answer = num1 % num2;
            }
            return answer;
        }
    }
}
