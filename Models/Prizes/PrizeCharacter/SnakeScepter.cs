using DungeonDice.Models.Characters;

namespace DungeonDice.Models.Prizes
{
    class SnakeScepter : PrizeCharacter
    {
        public SnakeScepter() : base()
        {
            this.name = "Snake scepter";
            this.character = new Wizard();
            this.explanation = "Use as a Wizard";
        }
    }
}
