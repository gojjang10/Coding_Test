namespace problem_120869
{

    /// <summary>
    ///  2025년 10월 22일
    ///  문제 : PROGRAMMERS-962 행성에 불시착한 우주비행사 머쓱이는 외계행성의 언어를 공부하려고 합니다. 
    ///  알파벳이 담긴 배열 spell과 외계어 사전 dic이 매개변수로 주어집니다.
    ///  spell에 담긴 알파벳을 한번씩만 모두 사용한 단어가 dic에 존재한다면 1, 존재하지 않는다면 2를 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120869


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(string[] spell, string[] dic)
        {

            foreach (string word in dic)
            {
                bool containsAll = true; // 일단 다 포함한다고 가정
                foreach (string letter in spell)
                {
                    if (!word.Contains(letter))
                    {
                        containsAll = false; // 하나라도 포함 안 하면 실패
                        break; // 더 볼 필요 없음
                    }
                }

                // 만약 현재 word가 모든 글자를 포함한다면?
                if (containsAll)
                {
                    // 그리고 단어 길이도 spell 배열 길이와 같다면 (문제 조건 확인 필요)
                    if (word.Length == spell.Length)
                    {
                        return 1; // 조건 만족하는 단어 찾았으니 즉시 1 반환
                    }
                }
            }
            return 2; // 기본 반환값
        }
    }
}
