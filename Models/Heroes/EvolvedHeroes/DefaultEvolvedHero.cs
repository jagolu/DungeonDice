using System;

namespace DungeonDice.Models.Heroes.EvolvedHeroes
{
    class DefaultEvolvedHero : Hero
    {
        public DefaultEvolvedHero() : base()
        {
            this.name = "Default evolved hero";
            this.speciality = "This hero doesn't have any speciality";
            this.hability = "This.hero doesn't have any hability";
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
