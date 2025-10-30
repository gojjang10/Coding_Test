namespace problem_120871
{

    /// <summary>
    ///  2025년 10월 22일
    ///  문제 : 3x 마을 사람들은 3을 저주의 숫자라고 생각하기 때문에 3의 배수와 숫자 3을 사용하지 않습니다. 3x 마을 사람들의 숫자는 다음과 같습니다.
    ///  정수 n이 매개변수로 주어질 때, n을 3x 마을에서 사용하는 숫자로 바꿔 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120871

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
            int count = 0;
            int resultNumber = 0;

            while (count < n)   // 반환되야 하는 숫자를 찾을 때까지 반복
            {
                resultNumber++; // 결과 숫자 1씩 증가

                if (resultNumber % 3 != 0 && !resultNumber.ToString().Contains('3')) // 3의 배수도 아니고 숫자 3도 포함하지 않을 때
                {
                    count++;    // 카운트 증가
                }
               
            }

            return resultNumber;
        }
    }
}
