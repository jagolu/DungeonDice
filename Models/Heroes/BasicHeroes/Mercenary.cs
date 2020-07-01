using System;

namespace DungeonDice.Models.Heroes
{
    class Mercenary : BasicHero
    {
        public Mercenary() : base()
        {
            this.name = "Mercenary";
            this.speciality = "When you form your team, you can re-roll any number of your team";
            this.hability = "Defeat any 2 monsters";
            this.evolvedHero = new Commander();
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
