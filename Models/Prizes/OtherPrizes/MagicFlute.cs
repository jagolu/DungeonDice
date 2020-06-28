using System;

namespace DungeonDice.Models.Prizes
{
    class MagicFlute : Prize
    {
        public MagicFlute() : base()
        {
            this.name = "Magic flute";
            this.explanation = "Transforms all monsters to dragon dices";
        }

        public override void use()
        {
            throw new NotImplementedException();
        }
    }
}
