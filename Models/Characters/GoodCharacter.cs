namespace DungeonDice.Models.Characters
{
    abstract class GoodCharacter : Character
    {
        protected GoodCharacter()
        {
            this.category = Category.GOOD;
        }
    }
}
