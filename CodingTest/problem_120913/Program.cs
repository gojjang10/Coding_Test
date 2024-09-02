namespace problem_120913
{
    internal class Program
    {
        public class Solution
        {
            public string[] solution(string my_str, int n)
            {
                char[] arr = my_str.ToCharArray();
                int allChar = arr.Length / n;
                
                if(arr.Length % n !=0)
                {
                    allChar = arr.Length / n + 1;
                }

                string[] answer = new string[allChar];

                for (int i = 0; i < allChar; i++)
                {
                    answer[i] = my_str.Substring(i * n, n);
                }

                return answer;
            }
        }
    }
}
