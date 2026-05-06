using System.Globalization;

namespace Practice
{
    class Weapon
    {
        public int damage;
    }

    struct Player
    {
        public int health;
        public Weapon weapon;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class SampleClass
    {
        LinkedList<int> numbers = new LinkedList<int>();
        private void PracticePlayer()
        {
            numbers.AddFirst(10); 
        }
    }


}
