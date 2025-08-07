namespace problem_120825
{

    /// <summary>
    ///  2025년 8월 6일
    ///  문제 : 문자열 my_string과 정수 n이 매개변수로 주어질 때, 
    ///  my_string에 들어있는 각 문자를 n만큼 반복한 문자열을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120825
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
        public string solution(string my_string, int n)
        {
            string answer = "";
            int repeat = n;

            for(int i = 0; i < my_string.Length; i++ )
            {
                while(repeat > 0)
                {
                    answer += my_string[i];
                    repeat--;
                }
                repeat = n;
            }

            return answer;
        }
    }
}
