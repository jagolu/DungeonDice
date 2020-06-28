namespace DungeonDice.Models.Prizes
{
    abstract class Prize
    {
        public string name;
        public string explanation;

        public abstract void use();
    }
}
