namespace problem_120894
{

    /// <summary>
    ///  2025년 9월 23일
    ///  문제 : 영어가 싫은 머쓱이는 영어로 표기되어있는 숫자를 수로 바꾸려고 합니다. 
    ///  문자열 numbers가 매개변수로 주어질 때, numbers를 정수로 바꿔 return 하도록 solution 함수를 완성해 주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120894

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public long solution(string numbers)
        {
            long answer = 0;

            string[] numStr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (int i = 0; i < numStr.Length; i++)
            {
                numbers = numbers.Replace(numStr[i], i.ToString());
            }
            answer = long.Parse(numbers);

            return answer;
        }
    }

}
