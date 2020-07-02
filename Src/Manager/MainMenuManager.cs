using DungeonDice.Models;

namespace DungeonDice.Src.Manager
{
    class MainMenuManager
    {
        private readonly InitialMenuManager imm;


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
