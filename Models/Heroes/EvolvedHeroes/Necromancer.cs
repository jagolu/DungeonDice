using System;

namespace DungeonDice.Models.Heroes
{
    class Necromancer : Hero
    {
        public Necromancer() : base()
        {
            this.name = "Necromancer";
            this.speciality = "Bishops can be used as Wizards and Wizards as Bishops";
            this.hability = "Transform 2 skeletons into fighters. Discard them during the next regroup phase";
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
