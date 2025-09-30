namespace problem_120907
{

    /// <summary>
    ///  2025년 9월 29일
    ///  문제 : 덧셈, 뺄셈 수식들이 'X [연산자] Y = Z' 형태로 들어있는 문자열 배열 quiz가 매개변수로 주어집니다. 
    ///  수식이 옳다면 "O"를 틀리다면 "X"를 순서대로 담은 배열을 return하도록 solution 함수를 완성해주세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120907

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public string[] solution(string[] quiz)
        {
            List<string> answer = new List<string>();

            foreach (string s in quiz)
            {
                string[] temp = s.Split(' ');

                if (temp[1] == "+")
                {
                    if (int.Parse(temp[0]) + int.Parse(temp[2]) == int.Parse(temp[4]))
                    {
                        answer.Add("O");
                    }
                    else
                    {
                        answer.Add("X");
                    }
                }
                else if (temp[1] == "-")
                {
                    if (int.Parse(temp[0]) - int.Parse(temp[2]) == int.Parse(temp[4]))
                    {
                        answer.Add("O");
                    }
                    else
                    {
                        answer.Add("X");
                    }
                }
            }
            return answer.ToArray();
        }
    }
}
