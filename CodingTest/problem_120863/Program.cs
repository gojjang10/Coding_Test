namespace problem_120863
{

    /// <summary>
    ///  2025년 10월 14일
    ///  문제 : 한 개 이상의 항의 합으로 이루어진 식을 다항식이라고 합니다. 다항식을 계산할 때는 동류항끼리 계산해 정리합니다. 
    ///  덧셈으로 이루어진 다항식 polynomial이 매개변수로 주어질 때, 
    ///  동류항끼리 더한 결괏값을 문자열로 return 하도록 solution 함수를 완성해보세요. 같은 식이라면 가장 짧은 수식을 return 합니다.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120863

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public string solution(string polynomial)
        {
            string[] parts = polynomial.Split(" + ");
            int xValue = 0;
            int constantValue = 0;

            foreach (string part in parts)
            {
                if (part.Contains("x"))
                {
                    string coefficient = part.Replace("x", "");
                    if (coefficient == "")
                    {
                        xValue += 1;
                    }
                    else
                    {
                        xValue += int.Parse(coefficient);
                    }
                }
                else
                {
                    constantValue += int.Parse(part);
                }
            }

            List<string> resultParts = new List<string>();

            // 1. x 항 처리
            if (xValue > 0)
            {
                // xValue가 1이면 "x"를, 아니면 "nx" 형태로 추가
                resultParts.Add(xValue == 1 ? "x" : $"{xValue}x");
            }

            // 2. 상수 항 처리
            if (constantValue > 0)
            {
                resultParts.Add(constantValue.ToString());
            }

            // 3. 결과 조합
            if (resultParts.Count > 0)
            {
                // " + "를 구분자로 사용하여 모든 조각을 합친다.
                return string.Join(" + ", resultParts);
            }
            else
            {
                // x 항과 상수 항이 모두 0인 경우는 문제 조건에 따라 처리
                // (보통 이런 경우는 없거나 "0"을 반환하라고 함)
                return "0";
            }
        }

    }
}


