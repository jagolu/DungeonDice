using DungeonDice.Models.Characters;

namespace DungeonDice.Models.Dices
{
    class TeamDice : Dice
    {
        public TeamDice() : base()
        {
            this.category = Category.GOOD;
        }

        public override void roll()
        {
            this.rollDice();

            switch (this.actualValue)
            {
                case 1:
                    this.character = new Champion();
                    break;
                case 2:
                    this.character = new Bishop();
                    break;
                case 3:
                    this.character = new Fighter();
                    break;
                case 4:
                    this.character = new QuestScroll();
                    break;
                case 5:
                    this.character = new Rogue();
                    break;
                case 6:
                    this.character = new Wizard();
                    break;
            }
        }
    }
}
