namespace problem_120896
{

    /// <summary>
    ///  2025년 9월 24일
    ///  문제 : 문자열 s가 매개변수로 주어집니다. s에서 한 번만 등장하는 문자를 사전 순으로 정렬한 문자열을 return 하도록 solution 함수를 완성해보세요.
    ///  한 번만 등장하는 문자가 없을 경우 빈 문자열을 return 합니다.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120896

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

public class Solution
    {
        public string solution(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            List<char> resultChars = new List<char>();
            foreach (var kvp in charCount)
            {
                if (kvp.Value == 1)
                {
                    resultChars.Add(kvp.Key);
                }
            }

            resultChars.Sort();
            return new string(resultChars.ToArray());
        }
    }
}
