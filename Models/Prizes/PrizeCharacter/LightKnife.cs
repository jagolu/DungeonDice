using DungeonDice.Models.Characters;

namespace DungeonDice.Models.Prizes
{
    class LightKnife : PrizeCharacter
    {
        public LightKnife() : base()
        {
            this.name = "Light knife";
            this.character = new Rogue();
            this.explanation = "Use as a Rogue";
        }
    }
}
