namespace problem_120876
{
    /// <summary>
    ///  2026년 5월 6일
    ///  문제 : 선분 3개가 평행하게 놓여 있습니다. 세 선분의 시작과 끝 좌표가 [[start, end], [start, end], [start, end]] 형태로 들어있는 2차원 배열 lines가 매개변수로 주어질 때,
    ///  두 개 이상의 선분이 겹치는 부분의 길이를 return 하도록 solution 함수를 완성해보세요.
    ///  lines가[[0, 2], [-3, -1], [-2, 1]] 일 때 그림으로 나타내면 다음과 같습니다.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120876

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int[,] lines)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < lines.GetLength(0); i++)
            {
                int start = lines[i, 0];
                int end = lines[i, 1];

                for (int j = start; j < end; j++)
                {
                    if (dict.ContainsKey(j))
                    {
                        dict[j]++;
                    }
                    else
                    {
                        dict[j] = 1;
                    }
                }
            }

            int overlapLength = 0;

            foreach (var item in dict)
            {
                if (item.Value >= 2)
                {
                    overlapLength++;
                }
            }

            return overlapLength;
        }
    }
}
