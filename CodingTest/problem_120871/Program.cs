namespace problem_120871
{
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
            int count = 0; // '착한 숫자'를 몇 개 찾았는지 세는 카운터
            int num = 0;   // 실제 확인하는 숫자 (1부터 시작할 것이므로 0으로 초기화)

            // '착한 숫자'를 n개 찾을 때까지 반복
            while (count < n)
            {
                num++; // 다음 숫자로 이동해서 확인 시작

                // 현재 숫자(num)가 3의 배수도 아니고 '3'도 포함하지 않는지 확인
                if (num % 3 != 0 && !num.ToString().Contains('3'))
                {
                    // '착한 숫자'를 찾았으므로 카운트 증가
                    count++;
                }
            }

            // count가 n이 되는 순간의 num 값이 n번째 '착한 숫자'
            return num;
        }
    }
}
