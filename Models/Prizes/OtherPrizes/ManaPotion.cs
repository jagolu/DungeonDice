using System;

namespace DungeonDice.Models.Prizes
{
    class ManaPotion : Prize
    {
        public ManaPotion() : base()
        {
            this.name = "Mana potion";
            this.explanation = "Revive 1 team dice and choose which member will it be";
        }

        public override void use()
        {
            throw new NotImplementedException();
        }
    }
}
