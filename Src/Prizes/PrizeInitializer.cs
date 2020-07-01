using DungeonDice.Models.Prizes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonDice.Src.Prizes
{
    class PrizeInitializer
    {
        public List<Prize> Initialize()
        {
            List<Prize> prizes = new List<Prize>();
            List<Tuple<Prize, int>> availablePrizes = this.getAvailablePrizes();

            for(int i=0; i<availablePrizes.Count; i++)
            {
                this.addPrizes(availablePrizes[i].Item2, availablePrizes[i].Item1, prizes);
            }

            return prizes;
        }


        private void addPrizes(int number, Prize prize, List<Prize> prizes)
        {
            prizes.AddRange(Enumerable.Repeat(prize, number).ToList());
        }

        private List<Tuple<Prize, int>> getAvailablePrizes()
        {
            List<Tuple<Prize, int>> prizes = new List<Tuple<Prize, int>>();
            prizes.Add(new Tuple<Prize, int>(new EmeraldSword(), 3));
            prizes.Add(new Tuple<Prize, int>(new ForbiddenScroll(), 3));
            prizes.Add(new Tuple<Prize, int>(new LightKnife(), 3));
            prizes.Add(new Tuple<Prize, int>(new MagicTalisman(), 3));
            prizes.Add(new Tuple<Prize, int>(new SnakeScepter(), 3));
            prizes.Add(new Tuple<Prize, int>(new MagicRing(), 4));
            prizes.Add(new Tuple<Prize, int>(new DragonEgg(), 6));
            prizes.Add(new Tuple<Prize, int>(new ManaPotion(), 3));
            prizes.Add(new Tuple<Prize, int>(new MagicFlute(), 4));
            prizes.Add(new Tuple<Prize, int>(new ArcanePortal(), 4));

            return prizes;
        }
    }
}
