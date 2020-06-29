using System;

namespace DungeonDice.Models.Heroes
{
    class Paladin : Hero
    {
        public Paladin() : base()
        {
            this.name = "Paladin";
            this.speciality = "Fighters can be used as Bishops and Bishops as Fighters";
            this.hability = "Discard 1 treasure to defeat all monsters, open all chests, use all potions and discard all dragon dices in the dragon base";
        }

        public override void executeHability()
        {
            throw new NotImplementedException();
        }

        public override void executeSpeciality()
        {
            throw new NotImplementedException();
        }
    }
}
