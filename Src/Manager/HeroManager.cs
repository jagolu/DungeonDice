using DungeonDice.Models;
using DungeonDice.Models.Heroes;
using DungeonDice.Models.Heroes.BasicHeroes;
using System;

namespace DungeonDice.Src.Manager
{
    class HeroManager
    {
        #region singleton
        private HeroManager() 
        {
            this.hero = new DefaultBasicHero();
        }
        private static HeroManager _instance;

        public static HeroManager getInstance()
        {
            if (_instance == null)
            {
                _instance = new HeroManager();
            }
            return _instance;
        }
        #endregion

        #region vars

        private Hero hero;

        #endregion

        #region public

        public void selectHero(MenuOptions option)
        {
            option = option == MenuOptions.RANDOM_HERO ? this.selectRandomHero() : option;

            switch (option)
            {
                case MenuOptions.SELECT_CRUSADER:
                    this.hero = new Crusader();
                    break;
                case MenuOptions.SELECT_ENCHANTRESS:
                    this.hero = new Enchantress();
                    break;
                case MenuOptions.SELECT_HALFGOBLIN:
                    this.hero = new HalfGoblin();
                    break;
                case MenuOptions.SELECT_KNIGHT:
                    this.hero = new Knight();
                    break;
                case MenuOptions.SELECT_MERCENARY:
                    this.hero = new Mercenary();
                    break;
                case MenuOptions.SELECT_MINSTREL:
                    this.hero = new Minstrel();
                    break;
                case MenuOptions.SELECT_OCCULTIST:
                    this.hero = new Occultist();
                    break;
                case MenuOptions.SELECT_SPELLSWORD:
                    this.hero = new Spellsword();
                    break;
                default:
                    this.hero = new DefaultBasicHero();
                    break;
            }
        }

        #endregion

        #region private

        private MenuOptions selectRandomHero()
        {
            var rand = new Random();
            int randValue = rand.Next(1, 9);
            MenuOptions newOption;

            switch (randValue)
            {
                case 1:
                    newOption = MenuOptions.SELECT_CRUSADER;
                    break;
                case 2:
                    newOption = MenuOptions.SELECT_ENCHANTRESS;
                    break;
                case 3:
                    newOption = MenuOptions.SELECT_HALFGOBLIN;
                    break;
                case 4:
                    newOption = MenuOptions.SELECT_KNIGHT;
                    break;
                case 5:
                    newOption = MenuOptions.SELECT_MERCENARY;
                    break;
                case 6:
                    newOption = MenuOptions.SELECT_MINSTREL;
                    break;
                case 7:
                    newOption = MenuOptions.SELECT_OCCULTIST;
                    break;
                case 8:
                    newOption = MenuOptions.SELECT_SPELLSWORD;
                    break;
                default:
                    newOption = MenuOptions.FAIL;
                    break;
            }

            return newOption;
        }

        #endregion
    }
}
