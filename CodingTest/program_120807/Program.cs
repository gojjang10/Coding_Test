namespace problem_120807
{
    /// <summary>
    ///  2024년 8월 5일
    ///  문제 : 정수 num1과 num2가 매개변수로 주어집니다. 두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120807
    /// </summary>
    public class Solution
    {
        public int solution(int num1, int num2)
        {
            if ( num1 >= 0 && num1 <= 10000 && num2 >= 0 && num2 <= 10000)
            {
                if (num1 == num2)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            int answer = 0;
            return answer;
        }
    }
}
