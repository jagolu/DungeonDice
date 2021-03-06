﻿using System;
namespace DungeonDice.Models.Heroes
{
    class Knight : BasicHero
    {
        public Knight() : base()
        {
            this.name = "Knight";
            this.speciality = "When you form your team, all the Quest scrolls become Champions";
            this.hability = "Transforms all monsters to Dragon dices and move them to the dragon base";
            this.evolvedHero = new DragonSlayer();
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
