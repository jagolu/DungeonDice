using System;

namespace DungeonDice.Models.Heroes
{
    class DragonSlayer : Hero
    {
        public DragonSlayer() : base()
        {
            this.name = "Dragon slayer";
            this.speciality = "When forming your team, all quest scrolls become champions. Use 2 different companions to defeat dragons (instead of 3)";
            this.hability = "Transforms all monsters to dragon dices and move them to the dragon base";
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
