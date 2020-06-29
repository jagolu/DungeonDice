using System;

namespace DungeonDice.Models.Heroes
{
    class Chieftain : Hero
    {
        public Chieftain() : base()
        {
            this.name = "Chieftain";
            this.speciality = "You can open chests and use potions at any time during Monsters Phase";
            this.hability = "Transforms 2 zombies into rogues. Discard them during the next regroup phase";
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
