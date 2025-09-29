namespace problem_120907
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
