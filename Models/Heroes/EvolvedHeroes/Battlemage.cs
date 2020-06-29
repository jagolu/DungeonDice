using System;

namespace DungeonDice.Models.Heroes
{
    class Battlemage : Hero
    {
        public Battlemage() : base()
        {
            this.name = "Battlemage";
            this.speciality = "Fighters can be used as wizards and wizards as fighters";
            this.hability = "Discards all monsters, chests, potions and dragon dices in the dragon base";
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
