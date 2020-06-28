using System;

namespace DungeonDice.Models.Heroes
{
    class Enchantress : BasicHero
    {
        public Enchantress() : base()
        {
            this.name = "Enchantress";
            this.speciality = "Quest scrolls can be used as any companion";
            this.hability = "Transform one monster into a potion";
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
