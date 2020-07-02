using DungeonDice.Models;
using DungeonDice.Src.Manager.SubMenuManagers;

namespace DungeonDice.Src.Manager
{
    class MainMenuManager
    {
        #region singleton
        private MainMenuManager()
        {
            this.imm = InitialMenuManager.getInstance();
        }

        private static MainMenuManager _instance;

        public static MainMenuManager getInstance()
        {
            if (_instance == null)
            {
                _instance = new MainMenuManager();
            }
            return _instance;
        }

        #endregion

        private readonly InitialMenuManager imm;

        public MenuOptions RunInitialMenu()
        {
            return this.imm.Run();
        }
    }
}
