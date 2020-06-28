using DungeonDice.Models.Characters;

namespace DungeonDice.Models.Prizes
{
    class ForbiddenScroll : PrizeCharacter
    {
        public ForbiddenScroll() : base()
        {
            this.name = "Forbidden scroll";
            this.character = new QuestScroll();
            this.explanation = "Use as a Quest scroll";
        }
    }
}
