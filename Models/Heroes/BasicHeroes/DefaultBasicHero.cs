using DungeonDice.Models.Heroes.EvolvedHeroes;
using System;

namespace DungeonDice.Models.Heroes.BasicHeroes
{
    class DefaultBasicHero : BasicHero
    {
        public DefaultBasicHero() : base()
        {
            this.name = "Default basic hero";
            this.speciality = "This hero has no speciality";
            this.hability = "This hero has no hability";
            this.evolvedHero = new DefaultEvolvedHero();
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
