using Game.Enum;
using System;


namespace Game
{
    class Program
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("MIRCIU", Faction.GoodGuy);
            Warrior badGuy = new Warrior("GEORGE", Faction.BadGuy);


            while(goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }
        }
    }
}
