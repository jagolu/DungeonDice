using System;

namespace DungeonDice.Models.Heroes
{
    class Crusader : BasicHero
    {
        public Crusader() : base()
        {
            this.name = "Crusader";
            this.speciality = "Fighters can be used as Bishops and Bishops as Fighers";
            this.hability = "Crusader can be used as a Bishop or as a Figher";
            //TODO
            //this.evolvedHero = ...
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
