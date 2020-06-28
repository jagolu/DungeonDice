using DungeonDice.Models.Characters;

namespace DungeonDice.Models.Prizes
{
    class MagicTalisman : PrizeCharacter
    {
        public MagicTalisman() : base()
        {
            this.name = "Magic Talisman";
            this.character = new Bishop();
            this.explanation = "Use as a Bishop";
        }
    }
}
