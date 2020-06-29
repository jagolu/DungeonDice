using System;

namespace DungeonDice.Models.Heroes
{
    class Commander : Hero
    {
        public Commander() : base()
        {
            this.name = "Commander";
            this.speciality = "Fighters defeat 1 extra monster of any type";
            this.hability = "Re-roll any number of team members and dungeon dices";
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
