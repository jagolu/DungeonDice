using System;
using DungeonDice.Models;

namespace DungeonDice.Src.Menus
{
    class HeroSelection : Menu
    {
        public HeroSelection() : base()
        {
            this.maxOption = 3;
        }


        public override void showOptions()
        {
            Console.WriteLine("1) Random Hero");
            Console.WriteLine("2) Select a Hero");
            Console.WriteLine("3) Back");
            Console.WriteLine("\n");
        }

        public override MenuOptions parseOption(int selectedOption)
        {
            MenuOptions chosenOption;
            switch (selectedOption)
            {
                case 1:
                    chosenOption = MenuOptions.RANDOM_HERO;
                    break;
                case 2:
                    chosenOption = MenuOptions.SELECT_HERO;
                    break;
                case 3:
                    chosenOption = MenuOptions.HERO_SELECTION_BACK;
                    break;
                default:
                    chosenOption = MenuOptions.FAIL;
                    break;
            }

            return chosenOption;
        }
    }
}
