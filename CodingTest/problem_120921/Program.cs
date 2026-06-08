namespace problem_120921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(string A, string B)
        {
            int answer = 0;
            LinkedList<char> listA = new LinkedList<char>(A);

            // 1. 문자열 A의 길이만큼 반복하는 반복문을 선언
            for(int i = 0; i < A.Length; i++)
            {
                // 2. 밀지 않아도 일치하는 경우가 있다면 answer에 0을 넣고 answer을 return
                if (A == B)
                {
                    answer = 0;
                    return answer;
                }

                // 3. 반복문 안에서 맨 뒤 노드를 맨 앞으로 이동시키는 작업을 수행
                var lastChar = listA.Last;
                listA.RemoveLast();
                listA.AddFirst(lastChar);

                // 4. 이동된 문자열이 B와 일치하는지 확인
                if (new string(listA.ToArray()) == B)
                {
                    // 5. 일치한다면 현재 반복문의 i에 +1 answer에 넣고 break
                    answer = i + 1;
                    break;
                }
            }
            // 6. 일치하는 것이 없다면 answer에 -1을 넣고 break
            answer = answer == 0 ? -1 : answer;
            return answer;
        }
    }
}
