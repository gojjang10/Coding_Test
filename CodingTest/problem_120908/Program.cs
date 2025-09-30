using System;

namespace problem_120908
{

    /// <summary>
    ///  2025년 9월 29일
    ///  문제 : 문자열 str1, str2가 매개변수로 주어집니다. str1 안에 str2가 있다면 1을 없다면 2를 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120908
    ///  1. str2를 char타입 배열로 만들어준다.
    ///  2. str1 순회를 돌면서 char타입 배열에 담긴 길이만큼 반복문을 만들고, 현재 순회를 돌고 있는 문자와 str2 char타입 배열의 0번째 요소가 참인지 거짓인지를 판단하여 맞는지 아닌지를 판독해주는 if문을 만들어준다.
    ///  3. 확인 후 있다면 1, 없다면 2를 반환한다.


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
