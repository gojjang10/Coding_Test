using System;

namespace problem_120908
{

    /// <summary>
    ///  2025년 9월 30일
    ///  문제 : 문자열 str1, str2가 매개변수로 주어집니다. str1 안에 str2가 있다면 1을 없다면 2를 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120908


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(string str1, string str2)
        {
            if (str1.Contains(str2))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
