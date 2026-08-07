using System;
using System.Collections.Generic;
using System.Text;

namespace Guy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy("Joe", 50);
            Guy bob = new Guy("Bob", 100);

            while (true)
            {
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;

                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();

                    if (whichGuy == "Joe")
                    {
                        int cashGived = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGived);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGived = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGived);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit)");
                }
            }
        }
    }
}
