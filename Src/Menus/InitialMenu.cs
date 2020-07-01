using DungeonDice.Models;
using System;

namespace DungeonDice.Src.Menus
{
    class InitialMenu : Menu
    {
        public InitialMenu() : base ()
        {
            this.maxOption = 4;
        }

        public override void showOptions()
        {
            Console.WriteLine("1) New Game");
            Console.WriteLine("2) Load Game");
            Console.WriteLine("3) Statics");
            Console.WriteLine("4) Quit");
            Console.WriteLine("\n");
        }

        public override MenuOptions parseOption(int selectedOption)
        {
            MenuOptions chosenOption;
            switch (selectedOption)
            {
                case 1:
                    chosenOption = MenuOptions.NEWGAME;
                    break;
                case 2:
                    chosenOption = MenuOptions.LOADGAME;
                    break;
                case 3:
                    chosenOption = MenuOptions.STATICS;
                    break;
                case 4:
                    chosenOption = MenuOptions.QUIT;
                    break;
                default:
                    chosenOption = MenuOptions.FAIL;
                    break;
            }

            return chosenOption;
        }
    }
}
