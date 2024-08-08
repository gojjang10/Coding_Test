namespace problem_120812
{
    /// <summary>
    ///  2024년 8월 7일
    ///  문제 : 최빈값은 주어진 값 중에서 가장 자주 나오는 값을 의미합니다. 
    ///  정수 배열 array가 매개변수로 주어질 때, 최빈값을 return 하도록 solution 함수를 완성해보세요. 
    ///  최빈값이 여러 개면 -1을 return 합니다.
    ///  중앙값을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120812
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int[] array)
            {
                int answer = 0;
                Array.Sort(array);
                int repeat;

                for (int i = 0; i < array.Length; i ++)
                {
                    if (array[i] == array[i +1])
                    {
                        repeat = array[i];
                    }
                   
                }


                return answer;
            }
        }
    }

}
