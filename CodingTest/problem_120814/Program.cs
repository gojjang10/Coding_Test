namespace problem_120814
{
    /// <summary>
    ///  2024년 8월 26일
    ///  문제 : 머쓱이네 피자가게는 피자를 일곱 조각으로 잘라 줍니다. 
    ///  피자를 나눠먹을 사람의 수 n이 주어질 때, 모든 사람이 피자를 한 조각 이상 먹기 위해 필요한 피자의 수를 
    ///  return 하는 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120814
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int n)
            {
                int pizza = 1;

                if(n  > 7)
                {
                    pizza = n / 7;

                    if(n % 7 >= 1)
                    {
                        pizza++;
                    }
                }

                int pizzaPiece = 7 * pizza;

                if(pizzaPiece - n >= 0)
                {
                    return pizza;
                }


                return pizza;
            }
        }
    }
}
