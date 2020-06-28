namespace DungeonDice.Models.Heroes
{
    abstract class Hero
    {
        public string name;
        public string speciality;
        public string hability;

        public abstract void useHability();

        public abstract void useSpeciality();

        public abstract void executeHability();

        public abstract void executeSpeciality();
    }
}
