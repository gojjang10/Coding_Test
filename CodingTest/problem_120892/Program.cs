using System.Text;

namespace problem_120892
{

    /// <summary>
    ///  2025년 9월 23일
    ///  문제 : 군 전략가 머쓱이는 전쟁 중 적군이 다음과 같은 암호 체계를 사용한다는 것을 알아냈습니다.
    ///  암호화된 문자열 cipher를 주고받습니다.
    ///  그 문자열에서 code의 배수 번째 글자만 진짜 암호입니다.
    ///  문자열 cipher와 정수 code가 매개변수로 주어질 때 해독된 암호 문자열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120892

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public string solution(string cipher, int code)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = code - 1; i < cipher.Length; i += code)
            {
                sb.Append(cipher[i]);
            }

            return sb.ToString();
        } 
    }
}
