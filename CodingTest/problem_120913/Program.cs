namespace problem_120913
{
    internal class Program
    {
        public class Solution
        {
            public string[] solution(string my_str, int n)
            {
                char[] arr = my_str.ToCharArray();
                // 문자열을 char타입 배열로 만들기

                int result = arr.Length / n;
                // n만큼 잘랐을때 얼만큼 자를 수 있는지 만들기
                
                if(arr.Length % n !=0)
                    // 만약 나누었을때 딱 떨어지지 않는다면
                {
                    result = arr.Length / n + 1;
                    // 나눠서 나온 몫에 한번 더 잘라야하기에 +1
                }

                string[] answer = new string[result];
                // 반환되는 문자열 개수

                for (int i = 0; i < result; i++)
                {
                    int start = i * n;
                    // 자르기 시작되는 글자 지점

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
