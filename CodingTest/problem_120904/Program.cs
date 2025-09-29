namespace problem_120904
{
    /// <summary>
    ///  2025년 9월 29일
    ///  문제 : 정수 num과 k가 매개변수로 주어질 때, 
    ///  num을 이루는 숫자 중에 k가 있으면 num의 그 숫자가 있는 자리 수를 return하고 없으면 -1을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120904

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int num, int k)
        {
            string numStr = num.ToString();
            char kar = k.ToString()[0];
            char[] chars = numStr.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == kar)
                {
                    return i + 1;
                }
            }
            return - 1;
        }
    }
}
