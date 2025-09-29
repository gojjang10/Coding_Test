namespace problem_120906
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
            int answer = 0;

            string nStr = n.ToString();
            char[] chars = nStr.ToCharArray();

            foreach (char c in chars)
            {
                // 자동으로 형변환 이루어짐
                answer += (c - '0');
            }

            return answer;
        }
    }
}
