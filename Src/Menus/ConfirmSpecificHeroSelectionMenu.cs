using DungeonDice.Models;
using DungeonDice.Models.Heroes;
using System;

namespace DungeonDice.Src.Menus
{
    class ConfirmSpecificHeroSelectionMenu : Menu
    {
        private readonly BasicHero heroToShow;

        public ConfirmSpecificHeroSelectionMenu(BasicHero heroToShow) : base()
        {
            this.heroToShow = heroToShow;
            this.maxOption = 2;
        }

        public override void showOptions()
        {
            this.heroToShow.showFullHeroInformation();
            Console.WriteLine("\n1) Confirm selection");
            Console.WriteLine("2) Back");
        }

        public override MenuOptions parseOption(int selectedOption)
        {
            MenuOptions chosenOption;
            switch (selectedOption)
            {
                case 1:
                    chosenOption = MenuOptions.CONFIRM_SPECIFIC_HERO_SELECTION;
                    break;
                case 2:
                    chosenOption = MenuOptions.CONFIRM_SPECIFIC_HERO_SELECTION_BACK;
                    break;
                default:
                    chosenOption = MenuOptions.FAIL;
                    break;
            }

            return chosenOption;
        }
    }
}
