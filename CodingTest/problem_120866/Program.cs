using static System.Net.Mime.MediaTypeNames;

namespace problem_120866
{

    /// <summary>
    ///  2025년 10월 19일
    ///  문제 : 다음 그림과 같이 지뢰가 있는 지역과 지뢰에 인접한 위, 아래, 좌, 우 대각선 칸을 모두 위험지역으로 분류합니다.
    ///  지뢰는 2차원 배열 board에 1로 표시되어 있고 board에는 지뢰가 매설 된 지역 1과, 지뢰가 없는 지역 0만 존재합니다.
    ///  지뢰가 매설된 지역의 지도 board가 매개변수로 주어질 때, 안전한 지역의 칸 수를 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120866


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int[,] board)
        {
            int answer = 0;

            int rows = board.GetLength(0);  // 행의 개수
            int cols = board.GetLength(1);  // 열의 개수
            bool[,] isDangerous = new bool[rows, cols]; // 처음엔 모든 칸이 false (안전)

            for (int r = 0; r < rows; r++)  // 행 순회
            {
                for (int c = 0; c < cols; c++)  // 열 순회
                {
                    if (board[r, c] == 1) // 지뢰가 있는 칸을 찾으면
                    {
                        // 해당 칸과 인접한 8칸을 위험한 칸으로 표시
                        for (int dr = -1; dr <= 1; dr++)    // 행 변화량
                        {
                            for (int dc = -1; dc <= 1; dc++)    // 열 변화량
                            {
                                int nr = r + dr;    // 새로운 행 인덱스
                                int nc = c + dc;    // 새로운 열 인덱스
                                if (nr >= 0 && nr < rows && nc >= 0 && nc < cols)   // 경계 체크
                                {
                                    isDangerous[nr, nc] = true;
                                }
                            }
                        }
                    }
                }
            }

            foreach(bool cell in isDangerous)   // 모든 칸 순회
            {
               if (!cell) answer++; // 안전한 칸 개수 증가
            }
            return answer;
        }
    }

}
