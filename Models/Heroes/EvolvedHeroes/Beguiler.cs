using System;

namespace DungeonDice.Models.Heroes
{
    class Beguiler : Hero
    {
        public Beguiler() : base()
        {
            this.name = "Beguiler";
            this.speciality = "Quest scrolls can be used as any companion";
            this.hability = "Transform 2 monsters into 1 potion";
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
