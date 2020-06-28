using DungeonDice.Models.Prizes;
using DungeonDice.Src.Prizes;
using DungeonDice.Src.Util;
using System;
using System.Collections.Generic;

namespace DungeonDice.Src
{
    class PrizesChest
    {
        private List<Prize> prizes;

        public PrizesChest()
        {
            PrizeInitializer prizeInitializer = new PrizeInitializer();
            this.prizes = prizeInitializer.Initialize();
            this.randomize();
        }

        public Prize getPrize()
        {
            Prize prize = this.prizes[0];
            this.prizes.RemoveAt(0);

            return prize;
        }

        public void returnPrizeToChest(Prize prize)
        {
            if (CheckPrizeType.isDragonEgg(prize))
            {
                Console.WriteLine("No puedes usar este objeto");
                return;
            }

            this.prizes.Add(prize);
            this.randomize();
        }

        private void randomize()
        {
            Random rnd = new Random();
            int n = this.prizes.Count;

            while(n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Prize value = this.prizes[k];
                this.prizes[k] = this.prizes[n];
                this.prizes[n] = value;
            }
        }
    }
}
