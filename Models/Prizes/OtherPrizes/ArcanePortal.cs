using System;

namespace DungeonDice.Models.Prizes
{
    class ArcanePortal : Prize
    {
        public ArcanePortal() : base()
        {
            this.name = "Arcane portal";
            this.explanation = "Earn points equal to the actual level and end the actual exploration.";
            this.explanation += "If it's unused is worthed by 2 points at the end of the game";
        }

        public override void use()
        {
            throw new NotImplementedException();
        }
    }
}
