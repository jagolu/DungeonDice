using DungeonDice.Models;
using DungeonDice.Src.Menus;
using System;

namespace DungeonDice.Src.Manager.SubMenuManagers
{
    class InitialMenuManager
    {
        #region singleton
        private InitialMenuManager()
        {
            this.initialMenu = new InitialMenu();
            this.heroSelectionMenu = new HeroSelection();
            this.specificHeroSelectionMenu = new SpecificHeroSelection();
            this.confirmSpecificHeroSelectionMenu = new ConfirmSpecificHeroSelectionMenu();
        }

        private static InitialMenuManager _instance;

        public static InitialMenuManager getInstance()
        {
            if (_instance == null)
            {
                _instance = new InitialMenuManager();
            }

            return _instance;
        }

        #endregion

        #region vars

        private readonly InitialMenu initialMenu;
        private readonly HeroSelection heroSelectionMenu;
        private readonly SpecificHeroSelection specificHeroSelectionMenu;
        private readonly ConfirmSpecificHeroSelectionMenu confirmSpecificHeroSelectionMenu;

        #endregion

        #region initialMenu
        public MenuOptions Run()
        {
            MenuOptions option = this.initialMenu.Run();
            MenuOptions retOption = MenuOptions.FAIL;

            switch (option)
            {
                case MenuOptions.NEWGAME:
                    retOption = this.RunHeroSelectionMenu();
                    break;
                case MenuOptions.LOADGAME:
                    retOption = this.RunShowLoadGame();
                    break;
                case MenuOptions.STATICS:
                    retOption = this.RunShowStatitics();
                    break;
                case MenuOptions.QUIT:
                    this.Quit();
                    break;
            }

            return retOption;
        }

        private MenuOptions RunShowStatitics()
        {
            throw new NotImplementedException();
        }

        private MenuOptions RunShowLoadGame()
        {
            throw new NotImplementedException();
        }

        private void Quit()
        {
            Console.WriteLine("Bye");
            Environment.Exit(0);
        }

        #endregion

        #region heroSelection

        private MenuOptions RunHeroSelectionMenu()
        {
            MenuOptions option = this.heroSelectionMenu.Run();
            MenuOptions retOption = MenuOptions.FAIL;

            switch (option)
            {
                case MenuOptions.RANDOM_HERO:
                    retOption = option;
                    break;
                case MenuOptions.SELECT_HERO:
                    retOption = this.RunSelectSpecificHeroMenu();
                    break;
                case MenuOptions.HERO_SELECTION_BACK:
                    retOption = this.Run();
                    break;
            }

            return retOption;
        }

        private MenuOptions RunSelectSpecificHeroMenu()
        {
            MenuOptions option = this.specificHeroSelectionMenu.Run();
            MenuOptions selectOption = MenuOptions.FAIL;

            switch (option)
            {
                case MenuOptions.SELECT_CRUSADER:
                case MenuOptions.SELECT_ENCHANTRESS:
                case MenuOptions.SELECT_HALFGOBLIN:
                case MenuOptions.SELECT_KNIGHT:
                case MenuOptions.SELECT_MERCENARY:
                case MenuOptions.SELECT_MINSTREL:
                case MenuOptions.SELECT_OCCULTIST:
                case MenuOptions.SELECT_SPELLSWORD:
                    selectOption = this.RunConfirmSpecificHeroSelectionMenu(option);
                    break;
                case MenuOptions.SPECIFIC_HERO_SELECTION_BACK:
                    selectOption = this.RunHeroSelectionMenu();
                    break;
            }

            return selectOption;
        }

        private MenuOptions RunConfirmSpecificHeroSelectionMenu(MenuOptions chosenOption)
        {
            this.confirmSpecificHeroSelectionMenu.setOptionChosen(chosenOption);
            MenuOptions option = this.confirmSpecificHeroSelectionMenu.Run();
            MenuOptions selectOption = MenuOptions.FAIL;

            switch (option)
            {
                case MenuOptions.CONFIRM_SPECIFIC_HERO_SELECTION:
                    selectOption = chosenOption;
                    break;
                case MenuOptions.CONFIRM_SPECIFIC_HERO_SELECTION_BACK:
                    selectOption = this.RunSelectSpecificHeroMenu();
                    break;
            }

            return selectOption;
        }

        #endregion
    }
}
