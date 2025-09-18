namespace problem_120852
{

    /// <summary>
    ///  2025년 9월 12일
    ///  문제 : 소인수분해란 어떤 수를 소수들의 곱으로 표현하는 것입니다. 예를 들어 12를 소인수 분해하면 2 * 2 * 3 으로 나타낼 수 있습니다. 
    ///  따라서 12의 소인수는 2와 3입니다. 
    ///  자연수 n이 매개변수로 주어질 때 n의 소인수를 오름차순으로 담은 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120852

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int[] solution(int n)
        {
            // 배열의 크기를 미리 알 수 없으니 List로 구현
            List<int> factors = new List<int>();

            // 1을 제외하고 2부터 매개변수로 받은 n의 수만큼 반복하기
            for (int i = 2; i <= n; i++)
            {
                // 나누어 지는 수만 구하기 위한 조건
                while (n % i == 0)
                {
                    factors.Add(i);

                    // 나누어 지는 수로 나누는게 가능한 것이 판단되었으니 해당 수를 나누어 주어서 반복해주는 값도 줄이고 불필요한 연산을 줄이기 위해 나누기
                    n = n / i;
                }
            }

            // 중복되는 요소를 제거하고 배열화 시켜서 반환
            return factors.Distinct().ToArray();
        }
    }
}
