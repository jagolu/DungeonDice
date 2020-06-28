namespace DungeonDice.Models.Characters
{
    abstract class BadCharacter : Character
    {
        public BadCharacter()
        {
            this.category = Category.BAD;
        }
    }
}
