using System;

namespace DungeonDice.Models.Heroes
{
    class Minstrel : BasicHero
    {
        public Minstrel() : base()
        {
            this.name = "Minstrel";
            this.speciality = "Rogues can be used as Wizards and Wizards can be used as Rogues";
            this.hability = "Remove all the dragon dices in the dragon base";
            this.evolvedHero = new Bard();
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
