using System;
using DungeonDice.Models;
using DungeonDice.Models.Heroes;

namespace DungeonDice.Src.Menus
{
    class SpecificHeroSelection : Menu
    {
        public SpecificHeroSelection() : base()
        {
            this.maxOption = 9;
        }

        public override void showOptions()
        {
            for(int i = 1; i < 9; i++)
            {
                Console.WriteLine(i + ") "+this.getHeroName(i));
            }
            Console.WriteLine("9) Back");
            Console.WriteLine("\n");
        }

        public override MenuOptions parseOption(int selectedOption)
        {
            MenuOptions chosenOption;
            switch (selectedOption)
            {
                case 1:
                    chosenOption = MenuOptions.SELECT_CRUSADER;
                    break;
                case 2:
                    chosenOption = MenuOptions.SELECT_ENCHANTRESS;
                    break;
                case 3:
                    chosenOption = MenuOptions.SELECT_HALFGOBLIN;
                    break;
                case 4:
                    chosenOption = MenuOptions.SELECT_KNIGHT;
                    break;
                case 5:
                    chosenOption = MenuOptions.SELECT_MERCENARY;
                    break;
                case 6:
                    chosenOption = MenuOptions.SELECT_MINSTREL;
                    break;
                case 7:
                    chosenOption = MenuOptions.SELECT_OCCULTIST;
                    break;
                case 8:
                    chosenOption = MenuOptions.SELECT_SPELLSWORD;
                    break;                
                case 9:
                    chosenOption = MenuOptions.SPECIFIC_HERO_SELECTION_BACK;
                    break;
                default:
                    chosenOption = MenuOptions.FAIL;
                    break;
            }

            return chosenOption;
        }

        private string getHeroName(int option)
        {
            string heroName;
            switch (option)
            {
                case 1:
                    heroName = new Crusader().getHeroName();
                    break;
                case 2:
                    heroName = new Enchantress().getHeroName();
                    break;
                case 3:
                    heroName = new HalfGoblin().getHeroName();
                    break;
                case 4:
                    heroName = new Knight().getHeroName();
                    break;
                case 5:
                    heroName = new Mercenary().getHeroName();
                    break;
                case 6:
                    heroName = new Minstrel().getHeroName();
                    break;
                case 7:
                    heroName = new Occultist().getHeroName();
                    break;
                case 8:
                    heroName = new Spellsword().getHeroName();
                    break;
                default:
                    heroName = "";
                    break;
            }

            return heroName;
        }
    }
}
