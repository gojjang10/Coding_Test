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
        private void PracticePlayer()
        {
            Player player1 = new Player();
            player1.health = 100;
            player1.weapon = new Weapon();

            Player player2;
            player2.health = 500;
            player2.weapon = player1.weapon;
        }
    }


}
