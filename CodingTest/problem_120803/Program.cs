namespace problem_120803
{
    /// <summary>
    ///  2024년 8월 5일
    ///  문제 : 정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 soltuion 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120803
    /// </summary>

    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;
            if (num1 >= -50000 && num1 <= 50000 && num2 >= -50000 && num2 <= 50000)
            {
                answer = num1 - num2;
                return answer;
            }
            return answer;
        }
    }
}

