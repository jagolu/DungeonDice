using System;

namespace DungeonDice.Models.Heroes
{
    class Occultist : BasicHero
    {
        public Occultist() : base()
        {
            this.name = "Occultist";
            this.speciality = "Bishops can be used as Wizards and Wizards as Bishops";
            this.hability = "Transform one skeleton into a fighter. Discard it during the next Regroup phase";
            this.evolvedHero = new Necromancer();
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
