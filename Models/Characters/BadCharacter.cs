namespace DungeonDice.Models.Characters
{
    abstract class BadCharacter : Character
    {
        protected BadCharacter()
        {
            this.category = Category.BAD;
        }
    }
}
