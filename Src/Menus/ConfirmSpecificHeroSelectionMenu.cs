using DungeonDice.Models;
using DungeonDice.Models.Heroes;
using System;

namespace DungeonDice.Src.Menus
{
    class ConfirmSpecificHeroSelectionMenu : Menu
    {
        private BasicHero heroToShow;

        public ConfirmSpecificHeroSelectionMenu(MenuOptions beforeMenuOption) : base()
        {
            this.maxOption = 2;
            this.getHero(beforeMenuOption);
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

        private void getHero(MenuOptions option)
        {
            switch (option)
            {
                case MenuOptions.SELECT_CRUSADER:
                    this.heroToShow = new Crusader();
                    break;
                case MenuOptions.SELECT_ENCHANTRESS:
                    this.heroToShow = new Enchantress();
                    break;
                case MenuOptions.SELECT_HALFGOBLIN:
                    this.heroToShow = new HalfGoblin();
                    break;
                case MenuOptions.SELECT_KNIGHT:
                    this.heroToShow = new Knight();
                    break;
                case MenuOptions.SELECT_MERCENARY:
                    this.heroToShow = new Mercenary();
                    break;
                case MenuOptions.SELECT_MINSTREL:
                    this.heroToShow = new Minstrel();
                    break;
                case MenuOptions.SELECT_OCCULTIST:
                    this.heroToShow = new Occultist();
                    break;
                case MenuOptions.SELECT_SPELLSWORD:
                    this.heroToShow = new Spellsword();
                    break;
            }
        }
    }
}
