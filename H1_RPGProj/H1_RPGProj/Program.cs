using H1_RPGProj;
using System.Diagnostics.Metrics;

namespace H1_RPG
{
    class Program
    {
        static Character player;
        static string[] classes = { "Soldier", "Assassin", "Hunter", "Berserker", "Enchanter", "Shadowknight" };
        static void Main(string[] args)
        {
            GetPlayerInfo();
        }
        static void GetPlayerInfo()
        {
            Console.WriteLine("Name: ");
            while(true)
            {
                string name = Console.ReadLine();
                if(name.Trim() == "")
                {
                    Console.WriteLine("give name please");
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Choose a class by pressing number\n");
            for(int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine($"{i}: {classes[i]}");
            }

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if(key == ConsoleKey.D0 || key == ConsoleKey.D1 || key == ConsoleKey.D2 || key == ConsoleKey.D3 || key == ConsoleKey.D4 || key == ConsoleKey.D5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please press a valid number.");
                }
            }
            Console.ReadLine();    
        }
    }
}