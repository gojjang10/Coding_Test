namespace problem_120860

{

    /// <summary>
    ///  2025년 10월 6일
    ///  문제 : 2차원 좌표 평면에 변이 축과 평행한 직사각형이 있습니다. 
    ///  직사각형 네 꼭짓점의 좌표 [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]가 담겨있는 배열 dots가 매개변수로 주어질 때,
    ///  직사각형의 넓이를 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120860

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

            List<int> x_coords = new List<int>();
            List<int> y_coords = new List<int>();

            for (int i = 0; i < dots.GetLength(0); i++)
            {
                x_coords.Add(dots[i, 0]); 
                y_coords.Add(dots[i, 1]); 
            }

            int width = x_coords.Max() - x_coords.Min();
            int height = y_coords.Max() - y_coords.Min();

            return width * height;
        }
    }
}


