namespace problem_120813
{
    /// <summary>
    ///  2024년 8월 26일
    ///  문제 : 정수 n이 매개변수로 주어질 때, n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120813
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int[] solution(int n)
            {
                List<int> list = new List<int>();

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 1)
                    {
                        list.Add(i);
                    }
                    else
                    {
                        continue;
                    }
                }
                return list.ToArray();
            }
        }
    }
}
