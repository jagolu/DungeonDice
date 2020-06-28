using DungeonDice.Models.Characters;
using System;

namespace DungeonDice.Models.Dices
{
    abstract class Dice
    {
        public int actualValue;
        public Category category;
        public Character character;

        public Dice() {
            this.actualValue = 0;
        }

        public void rollDice()
        {
            var rand = new Random();
            this.actualValue = rand.Next(1, 7);
        }

        public abstract void roll();
        public Character getValue()
        {
            return this.character;
        }
    }
}
