namespace problem_120808
{
    /// <summary>
    ///  2024년 8월 5일
    ///  문제 : 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1, 두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다. 
    ///  두 분수를 더한 값을 기약 분수로 나타냈을 때 분자와 분모를 순서대로 담은 배열을 return 하도록 solution 함수를 완성해보세요.
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120807
    /// </summary>

    public class Solution
    {
        public int[] solution(int numer1, int denom1, int numer2, int denom2)
        {

            if (0 < numer1 && numer1 < 1000 &&
                 0 < denom1 && denom1 < 1000 &&

                 0 < numer2 && numer2 < 1000 &&
                 0 < denom2 && denom2 < 1000)
            {
                int bottom = denom1 * denom2;
                int top = (numer1 * denom2) + (numer2 * denom1);


                int gcd = GCD(top, bottom);

                top /= gcd;
                bottom /= gcd;

                 
                return new int[]{top, bottom};
            }
            return new int[]{0, 0};
        }

        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
