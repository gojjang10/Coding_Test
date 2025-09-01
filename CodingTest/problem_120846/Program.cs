namespace problem_120846
{

    /// <summary>
    ///  2025년 9월 1일
    ///  문제 : 약수의 개수가 세 개 이상인 수를 합성수라고 합니다. 
    ///  자연수 n이 매개변수로 주어질 때 n이하의 합성수의 개수를 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120846
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
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if(Result(i) == true)
                {
                    answer++;
                }
            }

            return answer;
        }

        public bool Result(int n)
        {
            bool result = false;
            int count = 0;  

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    count++;
                }
            }

            if(count >= 3)
            {
                result = true;
            }

            return result;
        }
    }
}
