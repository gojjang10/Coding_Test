namespace problem_120882
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
        public int[] solution(int[,] score)
        {
            // 1. score.GetLength(0)을 사용해 정확한 사람 수만큼 배열을 만듭니다.
            int len = score.GetLength(0);
            int[] totalScores = new int[len];
            int[] answer = new int[len];

            // 1단계: 정수 나눗셈 오류를 피하기 위해 '총점'을 구해서 저장합니다.
            for (int i = 0; i < len; i++)
            {
                totalScores[i] = score[i, 0] + score[i, 1];
            }

            // 2단계: 모든 사람을 서로 비교하며 등수를 매깁니다. (이중 반복문)
            for (int i = 0; i < len; i++)
            {
                int rank = 1; // 등수는 1등부터 시작합니다.

                for (int j = 0; j < len; j++)
                {
                    // 나(i)보다 총점이 높은 사람(j)이 있다면 내 등수를 뒤로 밀어냅니다.
                    if (totalScores[j] > totalScores[i])
                    {
                        rank++;
                    }
                }

                // 계산된 최종 등수를 정답 배열에 넣습니다.
                answer[i] = rank;
            }

            return answer;
        }
    }
}
