namespace problem_120583
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
        public int solution(int[] array, int n)
        {
            int count = 0;

            foreach (int num in array)
            {
                if ( num == n ) count++;
            }
            return count;
        }
    }
}
