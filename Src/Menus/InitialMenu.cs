using DungeonDice.Models;
using System;
using System.Collections.Generic;

namespace DungeonDice.Src.Menus
{
    class InitialMenu : Menu
    {
        public InitialMenu() : base ()
        {
            this.options = new List<int>() { 1, 2, 3, 4 };
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
            switch (selectedOption)
            {
                case 1:
                    return MenuOptions.NEWGAME;
                case 2:
                    return MenuOptions.LOADGAME;
                case 3:
                    return MenuOptions.STATICS;
                case 4:
                    return MenuOptions.QUIT;
            }

            return MenuOptions.FAIL;
        }
    }
}
