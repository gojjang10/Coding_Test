namespace problem_120835
{

    /// <summary>
    ///  2025년 8월 16일
    ///  문제 : 외과의사 머쓱이는 응급실에 온 환자의 응급도를 기준으로 진료 순서를 정하려고 합니다. 
    ///  정수 배열 emergency가 매개변수로 주어질 때 응급도가 높은 순서대로 진료 순서를 정한 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120835
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int[] solution(int[] emergency)
        {
            // 반환해야하는 배열
            int[] answer = new int[emergency.Length];

            // OrderByDescending을 사용하여 내림차순으로 정렬.
            int[] sortedEmergency = emergency.OrderByDescending(x => x).ToArray();

            // 응급도 순위를 위한 자료구조
            Dictionary<int, int> rank = new Dictionary<int, int>();

            // 딕셔너리에 내림차순으로 정리된 배열의 값을 넣어주며 추가
            for(int i = 0; i < sortedEmergency.Length; i++)
            {
                rank.Add(sortedEmergency[i], i + 1);
            }

            for (int i = 0; i < emergency.Length; i++)
            {
                // 딕셔너리에 원본 배열 속 0번째 요소를 키로 사용해서 rank 딕셔너리 속 키에 접근해서 해당 키에 저장된 값을 answer 배열에 넣어주기 반복
                answer[i] = rank[emergency[i]];
            }

            return answer;
        }
    }
}
