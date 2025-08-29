namespace problem_120842
{

    /// <summary>
    ///  2025년 8월 25일
    ///  문제 : 정수 배열 num_list와 정수 n이 매개변수로 주어집니다. num_list를 다음 설명과 같이 2차원 배열로 바꿔 return하도록 solution 함수를 완성해주세요.
    ///  num_list가[1, 2, 3, 4, 5, 6, 7, 8] 로 길이가 8이고 n이 2이므로 num_list를 2 * 4 배열로 다음과 같이 변경합니다. 
    ///  2차원으로 바꿀 때에는 num_list의 원소들을 앞에서부터 n개씩 나눠 2차원 배열로 변경합니다.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120842
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
        public int[,] solution(int[] num_list, int n)
        {
            int rows = num_list.Length / n;
            int cols = n;
            int count = 0;
            int[,] answer = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    answer[i,j] = num_list[count];
                    count++;
                }
            }


            return answer;
        }
    }
}
