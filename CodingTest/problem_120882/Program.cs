namespace problem_120882
{

    /// <summary>
    ///  2025년 9월 18일
    ///  문제 : 영어 점수와 수학 점수의 평균 점수를 기준으로 학생들의 등수를 매기려고 합니다. 
    ///  영어 점수와 수학 점수를 담은 2차원 정수 배열 score가 주어질 때, 영어 점수와 수학 점수의 평균을 기준으로 매긴 등수를 담은 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120882

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
