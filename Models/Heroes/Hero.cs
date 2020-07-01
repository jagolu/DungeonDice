using System;

namespace DungeonDice.Models.Heroes
{
    abstract class Hero
    {
        public string name;
        public string speciality;
        public string hability;

        public abstract void executeHability();

        public abstract void executeSpeciality();

        public string getHeroName()
        {
            return this.name;
        }

        public void showInformation()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Speciality: " + this.speciality);
            Console.WriteLine("Hability: " + this.hability);
        }
    }
}
