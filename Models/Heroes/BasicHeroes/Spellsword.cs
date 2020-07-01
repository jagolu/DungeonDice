using System;

namespace DungeonDice.Models.Heroes
{
    class Spellsword : BasicHero
    {
        public Spellsword() : base()
        {
            this.name = "Spellsword";
            this.speciality = "Fighters can be used as Wizards and Wizards as Fighers";
            this.hability = "Spellsword can be used as a figher or wizard";
            this.evolvedHero = new Battlemage();
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
