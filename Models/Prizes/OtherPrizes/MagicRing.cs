using System;

namespace DungeonDice.Models.Prizes
{
    class MagicRing : Prize
    {
        public MagicRing() : base()
        {
            this.name = "Magic ring";
            this.explanation = "Return all the bad dragon dices to the actives dices. (Not count as defeating the dragon)";
        }

        public override void use()
        {
            throw new NotImplementedException();
        }
    }
}
