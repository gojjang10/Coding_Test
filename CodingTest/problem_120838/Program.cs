namespace problem_120838
{
    using System.Text;
    /// <summary>
    ///  2025년 8월 21일
    ///  문제 : 머쓱이는 친구에게 모스부호를 이용한 편지를 받았습니다. 
    ///  그냥은 읽을 수 없어 이를 해독하는 프로그램을 만들려고 합니다. 
    ///  문자열 letter가 매개변수로 주어질 때, letter를 영어 소문자로 바꾼 문자열을 return 하도록 solution 함수를 완성해보세요.
    ///  모스부호는 다음과 같습니다.
    ///  morse = { 
    ///'.-':'a','-...':'b','-.-.':'c','-..':'d','.':'e','..-.':'f',
    ///'--.':'g','....':'h','..':'i','.---':'j','-.-':'k','.-..':'l',
    ///'--':'m','-.':'n','---':'o','.--.':'p','--.-':'q','.-.':'r',
    ///'...':'s','-':'t','..-':'u','...-':'v','.--':'w','-..-':'x',
    ///'-.--':'y','--..':'z'
    ///  URL : https://school.programmers.co.kr/learn/courses/30/lessons/120838
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
        public string solution(string letter)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<string, string> morseMap = new Dictionary<string, string>
            {
                { ".-", "a" },
                { "-...", "b" },
                { "-.-.", "c" },
                { "-..", "d" },
                { ".", "e" },
                { "..-.", "f" },
                { "--.", "g" },
                { "....", "h" },
                { "..", "i" },
                { ".---", "j" },
                { "-.-", "k" },
                { ".-..", "l" },
                { "--", "m" },
                { "-.", "n" },
                { "---", "o" },
                { ".--.", "p" },
                { "--.-", "q" },
                { ".-.", "r" },
                { "...", "s" },
                { "-", "t" },
                { "..-", "u" },
                { "...-", "v" },
                { ".--", "w" },
                { "-..-", "x" },
                { "-.--", "y" },
                { "--..", "z" }
            };
            string[] resultString = letter.Split();

            foreach (string str in resultString)
            {
                sb.Append(morseMap[str]);
            }

            string answer;
            return answer = sb.ToString();
        }
    }
}
