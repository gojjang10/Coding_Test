namespace problem_120806
{
    /// <summary>
    ///  2024년 8월 5일
    ///  문제 : 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 
    ///  return 하도록 soltuion 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120806
    /// </summary>
    public class Solution
    {
        public float solution(int num1, int num2)
        {
            if (num1 > 0 && num1 <= 100 && num2 > 0 && num2 <= 100)
            {
                float answer = 0;
                answer = ((float)num1 / (float)num2) * 1000;

                return (int)answer;
            }
            return 0;
        }
    }
}
