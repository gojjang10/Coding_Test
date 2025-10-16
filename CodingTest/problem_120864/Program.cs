using System.Text;

namespace problem_120864
{

    /// <summary>
    ///  2025년 10월 16일
    ///  문제 : 문자열 my_string이 매개변수로 주어집니다. 
    ///  my_string은 소문자, 대문자, 자연수로만 구성되어있습니다. my_string안의 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120864

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
    public int solution(string my_string)
    {
        int finalSum = 0;
        StringBuilder currentNumberBuilder = new StringBuilder(); // StringBuilder 사용

        foreach (char c in my_string)
        {
            if (char.IsDigit(c))
            {
                currentNumberBuilder.Append(c); // 바구니에 담기
            }
            else
            {
                if (currentNumberBuilder.Length > 0)
                {
                    finalSum += int.Parse(currentNumberBuilder.ToString());
                    currentNumberBuilder.Clear(); // 바구니 비우기
                }
            }
        }

        // 마지막 함정 처리: 루프가 끝난 후 바구니에 남은 숫자가 있다면?
        if (currentNumberBuilder.Length > 0)
        {
            finalSum += int.Parse(currentNumberBuilder.ToString());
        }

        return finalSum;
    }
}
