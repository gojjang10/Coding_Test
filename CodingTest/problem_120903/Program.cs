namespace problem_120903
{

    /// <summary>
    ///  2025년 9월 26일
    ///  문제 : 두 배열이 얼마나 유사한지 확인해보려고 합니다.
    ///  문자열 배열 s1과 s2가 주어질 때 같은 원소의 개수를 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120903

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(string[] s1, string[] s2)
        {
            int count = 0;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string str in s1)
            {
                    dict[str] = 1;
            }

            foreach (string str in s2)
            {
                if (dict.ContainsKey(str))
                {
                    count++;
                    //dict.Remove(str); // 중복 카운트를 방지하기 위해 이미 카운트된 항목을 제거
                }
            }

            return count;
        }
    }




    //foreach (string str in s1)
    //{
    //    foreach (string str2 in s2)
    //    {
    //        if (str == str2)
    //        {
    //            count++;
    //            break; // 중복 카운트를 방지하기 위해 내부 루프를 종료
    //        }
    //    }
    //}




    //foreach (string str in s1)
    //{
    //    if (Array.Exists(s2, element => element == str))
    //    {
    //        count++;
    //    }
    //}
}
