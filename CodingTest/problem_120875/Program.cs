namespace problem_120875
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
        public int solution(int[,] dots)
        {
            // 2차원 배열을 다루기 쉽게 점들로 분리 (가독성을 위해)
            int[] p1 = new int[] { dots[0, 0], dots[0, 1] };
            int[] p2 = new int[] { dots[1, 0], dots[1, 1] };
            int[] p3 = new int[] { dots[2, 0], dots[2, 1] };
            int[] p4 = new int[] { dots[3, 0], dots[3, 1] };

            // Case 1: (1-2) vs (3-4)
            if (AreParallel(p1, p2, p3, p4))
                return 1;

            // Case 2: (1-3) vs (2-4)
            if (AreParallel(p1, p3, p2, p4))
                return 1;

            // Case 3: (1-4) vs (2-3)
            if (AreParallel(p1, p4, p2, p3))
                return 1;

            // 3가지 경우 모두 평행하지 않음
            return 0;
        }


        private bool AreParallel(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            // A = (y2 - y1)
            long deltaY1 = p2[1] - p1[1];
            // B = (x2 - x1)
            long deltaX1 = p2[0] - p1[0];

            // C = (y4 - y3)
            long deltaY2 = p4[1] - p3[1];
            // D = (x4 - x3)
            long deltaX2 = p4[0] - p3[0];

            // A * D == C * B
            // (int끼리 곱하면 범위를 넘어갈 수 있으니 long으로 계산하는 것이 안전합니다)
            return deltaY1 * deltaX2 == deltaY2 * deltaX1;
        }
    }
}
