using System.Globalization;

namespace RollTheDice;

class Program
{
    static readonly Random rnd = new();

    static int Dice1 = rnd.Next(1, 7);
    static int Dice2 = rnd.Next(1, 7);
    static int sum = Dice1 + Dice2;
    static int game = 1;
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Välkommen till Hustler Tärningskastet");
        Console.WriteLine("För att sluta förlora pengar tryck på x.");
        Console.WriteLine("--------------------------------");

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Spel omgång {0}", game);
        Console.WriteLine("--------------------------------");
        Console.ResetColor();
        while (true)
        {
            Dice1 = rnd.Next(1, 7);
            Dice2 = rnd.Next(1, 7);
            sum = Dice1 + Dice2;
            Console.WriteLine("Tärning1:" + Dice1);
            Console.WriteLine("Tärning2:" + Dice2);
            Console.WriteLine("Summa:" + sum);
            if (sum == 12)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Grattis din Pimp");
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine("Du förlorade pengar!");
            }
            Console.WriteLine("Vill du spela igen? y/n");
            if (Console.ReadLine()! == "y")
            {
                game++;
                Console.WriteLine("-----------------------");
                Console.WriteLine("spel: {0}", game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}

