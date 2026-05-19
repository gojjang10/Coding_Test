namespace problem_120880
{

    /// <summary>
    ///  2026년 5월 19일
    ///  문제 : 정수 n을 기준으로 n과 가까운 수부터 정렬하려고 합니다. 이때 n으로부터의 거리가 같다면 더 큰 수를 앞에 오도록 배치합니다. 
    ///  정수가 담긴 배열 numlist와 정수 n이 주어질 때 numlist의 원소를 n으로부터 가까운 순서대로 정렬한 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120880
    ///  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int[] solution(int[] numlist, int n)
        {
            return numlist
                .OrderBy(x => Math.Abs(x - n))  // n과의 거리를 기준으로 오름차순 정렬
                .ThenByDescending(x => x)       // 거리가 같을 때는 큰 수가 앞에 오도록 내림차순 정렬
                .ToArray();                     // 결과를 배열로 변환하여 반환
        }
    }
}
