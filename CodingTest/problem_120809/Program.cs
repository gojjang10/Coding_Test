﻿namespace problem_120809
{
    /// <summary>
    ///  2024년 8월 7일
    ///  문제 : 정수 배열 numbers가 매개변수로 주어집니다. 
    ///  numbers의 각 원소에 두배한 원소를 가진 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120809
    /// </summary>

    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };

            for (int i = 0; i < numbers.Length; i++)
            {
                answer[i] = numbers[i] * 2;
            }

            return answer;
        }
    }
}
