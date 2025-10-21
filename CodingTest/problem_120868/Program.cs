namespace problem_120868
{

    /// <summary>
    ///  2025년 10월 21일
    ///  문제 : 선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.
    ///  가장 긴 변의 길이는 다른 두 변의 길이의 합보다 작아야 합니다.
    ///  삼각형의 두 변의 길이가 담긴 배열 sides이 매개변수로 주어집니다.나머지 한 변이 될 수 있는 정수의 개수를 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120868

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

public class Solution
{
    public int solution(int[] sides)
    {
        int max = sides.Max();
        int min = sides.Min();

        // 가능한 세 번째 변 x의 범위: max - min < x < max + min
        // 이 범위를 만족하는 정수의 개수는 (max + min - 1) - (max - min) = 2 * min - 1 입니다.
        return 2 * min - 1;
    } 
}
