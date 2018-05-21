using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int level;
            float health, armor, damage, totalXp, xp;
            bool inGame = true;
            string gameName = "Heroville", pressKey = "Press any key to continue...";

            Random random = new Random();
           
            while (inGame)
            {
                Console.WriteLine("Welcome to " + gameName + "!");
                Console.WriteLine(pressKey);
                Console.ReadKey(true);

                //Console.ReadKey(true);
            }

            Console.ReadKey(true);
        }

        void Intro()
        {
            Console.WriteLine("");
            Console.ReadKey(true);
        }

        void Loot()
        {

        }

        void Upgrade()
        {

        }
    }
}
