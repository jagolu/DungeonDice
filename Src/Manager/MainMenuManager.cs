﻿using DungeonDice.Models;
using DungeonDice.Src.Manager.SubMenuManagers;

namespace DungeonDice.Src.Manager
{
    class MainMenuManager
    {
        private readonly InitialMenuManager imm;
            this.imm = InitialMenuManager.getInstance();


        public MainMenuManager()
        {
            this.imm = new InitialMenuManager();
        }

        public MenuOptions RunInitialMenu()
        {
            return this.imm.Run();
        }
    }
}
