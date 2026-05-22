namespace problem_120956
{

    /// <summary>
    ///  2026년 5월 22일
    ///  문제 : 머쓱이는 태어난 지 6개월 된 조카를 돌보고 있습니다. 조카는 아직 "aya", "ye", "woo", "ma" 네 가지 발음을 최대 한 번씩 사용해 조합한(이어 붙인) 발음밖에 하지 못합니다. 
    ///  문자열 배열 babbling이 매개변수로 주어질 때, 머쓱이의 조카가 발음할 수 있는 단어의 개수를 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120956

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class Solution
    {
        public int solution(string[] babbling)
        {
            int answer = 0;
            string[] validWords = { "aya", "ye", "woo", "ma" };

            foreach (string babble in babbling)
            {
                string current = babble;

                foreach (string word in validWords)
                {
                    // 문자열의 불변성 특성 때문에 Replace는 새로운 문자열을 반환합니다. 따라서 current에 다시 할당해야 합니다.
                    current = current.Replace(word, " ");
                }

                current = current.Replace(" ", "");

                if(current.Length == 0)
                {
                    answer++;
                }
            }

            return answer;
        }
    }
}
