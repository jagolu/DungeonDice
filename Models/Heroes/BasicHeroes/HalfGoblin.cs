using System;

namespace DungeonDice.Models.Heroes
{
    class HalfGoblin : BasicHero
    {
        public HalfGoblin() : base()
        {
            this.name = "Half-Goblin";
            this.speciality = "You can open chests and potions at any time during the monster phase";
            this.hability = "Transform 1 zombie into a Rogue. Discard it during the next Regroup phase";
            this.evolvedHero = new Chieftain();
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
