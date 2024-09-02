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
                    int start = i * n;
                    // 시작되는 글자 지점

                    int length = n;
                    // n 만큼 자르는 수
                    
                    if(start + n > arr.Length)
                        // 자르기 시작되는 글자에서 n을 더했을때 배열의 총 길이를 넘어간다면
                    {
                        length = arr.Length - start;
                    }
                    answer[i] = my_str.Substring(start, length);
                }

                return answer;
            }
        }
    }
}
