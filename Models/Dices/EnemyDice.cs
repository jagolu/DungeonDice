using DungeonDice.Models.Characters;

namespace DungeonDice.Models.Dices
{
    class EnemyDice : Dice
    {
        public EnemyDice (): base()
        {
            this.category = Category.BAD;
        }

        public override void roll()
        {
            this.rollDice();

            switch (this.actualValue)
            {
                case 1:
                    this.character = new Zombie();
                    break;
                case 2:
                    this.character = new Potion();
                    break;
                case 3:
                    this.character = new Chest();
                    break;
                case 4:
                    this.character = new Skeleton();
                    break;
                case 5:
                    this.character = new Dragon();
                    break;
                case 6:
                    this.character = new SwampCreature();
                    break;
            }
        }
    }
}
