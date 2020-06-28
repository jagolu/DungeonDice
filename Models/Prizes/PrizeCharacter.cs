using DungeonDice.Models.Characters;
using System;

namespace DungeonDice.Models.Prizes
{
    class PrizeCharacter : Prize
    {
        public Character character;

        public PrizeCharacter() : base() { }

        public override void use()
        {
            //Use this.character as own character
            throw new NotImplementedException();
        }
    }
}
