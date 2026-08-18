using Guys;

namespace Guy_Odds
{
    internal class Program
    {
        public static Random random = new Random();
        public static double odds = 0.75;
        public static Guy player = new Guy("The player", 100);
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the cassino. The odds are ",  odds);

            while (player.Cash > 0)
            {
                player.WriteMyInfo();

                Console.Write("How much do you want to bet in the little tiger?? ");

                string? howMuch = Console.ReadLine();

                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = amount * 2;
                    int randomNum = random.Next(1);

                    if (pot > player.Cash)
                    {
                        break;
                    }

                    if (randomNum > odds)
                    {
                        player.ReceiveCash(pot);
                        Console.WriteLine("You win ", pot);
                    }
                    else
                    {
                        player.GiveCash(pot);
                        Console.WriteLine($"You lose {amount} bucks.");
                        Console.WriteLine("The house always wins, loser.");
                    }
                }
            }

        }
    }
}
