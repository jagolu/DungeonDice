using System;

namespace DungeonDice.Models.Heroes
{
    class Bard : Hero
    {
        public Bard() : base()
        {
            this.name = "Bard";
            this.speciality = "Rogues can be used as Wizards and Wizards as Rogues. Champions defeats 1 extra monster.";
            this.hability = "Discard all the dragon dices in the dragon base";
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
