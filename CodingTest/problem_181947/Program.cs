namespace problem_181947
{
    /// <summary>
    ///  2025년 7월 15일
    ///  문제 : 두 정수 a, b가 주어질 때 다음과 같은 형태의 계산식을 출력하는 코드를 작성해 보세요.
    ///         a + b = c
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/181947
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }


}
