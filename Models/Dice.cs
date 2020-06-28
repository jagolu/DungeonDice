using System;

namespace DungeonDice.Models
{
    abstract class Dice
    {
        public int actualValue;

        public Dice() {
            this.actualValue = 0;
        }

        public void roll()
        {
            var rand = new Random();
            this.actualValue = rand.Next(1, 6);
        }

        public abstract string getValue();
    }
}
