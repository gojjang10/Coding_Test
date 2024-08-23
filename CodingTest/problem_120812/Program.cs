using System.ComponentModel.Design;

namespace problem_120812
{
    /// <summary>
    ///  2024년 8월 23일
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
                // 반환 값
                int maxValue = 0;
                // 배열의 최대 수

                foreach (int value in array)
                    // 입력받은 배열 반복
                {
                    if(value > maxValue)
                        // 최대 수보다 현재 배열 속 값이 크다면
                    {
                        maxValue = value;
                        // 최대값을 현재 배열 속 값으로 초기화
                    }
                }

                int[] countArray = new int[maxValue + 1];
                // 카운트를 세는 배열 선언. 그리고 배열의 인덱스는 0부터 시작하기 때문에 + 1 추가

                foreach (int value in array)
                    // 입력받은 배열 다시 반복
                {
                    countArray[value]++;
                    // 입력받은 배열 숫자를 카운트를 새는 배열에 넣으면 입력받은 배열 속 숫자의 값의 카운트를 셀 수 있다.
                    // 중복되면 해당 인덱스의 값을 1씩 추가한다
                }

                int mode = 0;
                // 최빈값 변수
                int modeCount = 0;
                // 최빈값의 카운트
                bool sameValue = false;
                // 최빈값의 중복 여부

                for (int i = 0; i <= maxValue; i++)
                {
                    if (countArray[i] > modeCount)
                        // 카운트 배열 해당 숫자 안에 카운트가 최빈값 카운트보다 크다면
                    {
                        modeCount = countArray[i];
                        // 최빈값 카운트를 초기화
                        mode = i;
                        // 최빈값 현재 i로 초기화
                        sameValue = false ;
                        // 중복 여부 거짓
                    }
                    else if(countArray[i] == modeCount)
                        // 카운트 배열 해당 숫자 안에 카운트가 최빈값 카운트와 같다면
                    {
                        sameValue = true ;
                        // 중복 여부 참
                    }
                }
               
                if (sameValue)
                    // 중복일때
                {
                    answer = -1;
                    // -1 저장
                }
                else
                {
                    answer = mode;
                    // 중복이 아니면 최빈값 저장
                }

                return answer;
            }
        }
    }

}
