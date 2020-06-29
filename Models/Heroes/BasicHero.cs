using System;

namespace DungeonDice.Models.Heroes
{
    abstract class BasicHero : Hero
    {
        public bool hasUsedHisHability;
        public int experience;
        public bool evolved;
        public Hero evolvedHero;

        public BasicHero() : base ()
        {
            this.hasUsedHisHability = false;
            this.experience = 0;
            evolved = false;
        }

        public void evolve()
        {
            if (this.experience < 5 || this.evolved) return;
            this.evolved = true;
            this.hasUsedHisHability = false;
            this.speciality = this.evolvedHero.speciality;
            this.hability = this.evolvedHero.hability;

            Console.WriteLine("You have evolved!");
        }

        public void useHability()
        {
            if (!this.hasUsedHisHability)
            {
                Console.WriteLine("You have already used your speciality");
                return;
            }

            if (this.evolved)
            {
                this.evolvedHero.useHability();
                return;
            }

            this.executeHability();
        }

        public void useSpeciality()
        {
            if (this.evolved)
            {
                this.evolvedHero.executeSpeciality();
                return;
            }

            this.executeSpeciality();
        }

        public abstract override void executeHability();
        public abstract override void executeSpeciality();
    }
}
