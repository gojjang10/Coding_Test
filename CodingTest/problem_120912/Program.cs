namespace problem_120912
{

    /// <summary>
    ///  2025년 10월 6일
    ///  문제 : 머쓱이는 행운의 숫자 7을 가장 좋아합니다. 
    ///  정수 배열 array가 매개변수로 주어질 때, 7이 총 몇 개 있는지 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120912

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int[] array)
        {
            int count = 0;
            string[] strings = array.Select(x => x.ToString()).ToArray();

            foreach(string s in strings)
            {
                foreach(char c in s)
                {
                    if(c == '7')
                    {
                        count++;
                    }
                }
            }

            return count;   
        }
    }
}
