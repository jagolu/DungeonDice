namespace DungeonDice.Models.Characters
{
    abstract class GoodCharacter : Character
    {
        public GoodCharacter()
        {
            this.category = Category.GOOD;
        }
    }
}
