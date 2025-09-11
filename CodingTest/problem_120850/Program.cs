namespace problem_120850
{

    /// <summary>
    ///  2025년 9월 9일
    ///  문제 : 문자열 my_string이 매개변수로 주어질 때, 
    ///  my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를 return 하도록 solution 함수를 작성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120850
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
        public List<int> solution(string my_string)
        {
            List<int> resultList = new List<int>();

            foreach(char s in my_string)
            {
                if(char.IsDigit(s))
                {
                    resultList.Add(s);
                }
            }

            resultList = resultList.OrderBy(x => x).ToList();
            return resultList;
        }
    }
}
