using System;
using System.Collections.Generic;
using System.Text;

namespace Guy
{
    class Guy
    {
        string Name;
        int Cash;

        public Guy(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }

        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " + "I don't have enough money to give you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        public void ReceiveCash(int amount)
        {
            if (amount <= 0 )
            {
                Console.WriteLine(Name + " says: " + amount + "isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
