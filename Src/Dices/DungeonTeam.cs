using System;
using System.Collections.Generic;
using DungeonDice.Models.Dices;
using System.Linq;

namespace DungeonDice.Src.Dices
{
    class DungeonTeam
    {
        #region singleton

        private DungeonTeam()
        {
            this.initializeDicesVars();
        }
        private static DungeonTeam _instance;

        public static DungeonTeam getInstance()
        {
            if (_instance == null)
            {
                _instance = new DungeonTeam();
            }
            return _instance;
        }

        #endregion

        #region vars

        private int availableDungeonDices;
        private List<EnemyDice> levelDungeonDices;
        private int dragonFaces;
        private int goneDices;
        private int numberDungeonDices;

        #endregion

        #region public

        public void startDungeonLevel(int dungeonLevel)
        {
            int thisLevelDices = (availableDungeonDices < dungeonLevel) ? this.numberDungeonDices : dungeonLevel;
            this.levelDungeonDices = Enumerable.Repeat(new EnemyDice(), thisLevelDices).ToList();
            this.levelDungeonDices.ForEach(ldg =>
            {
                ldg.roll();
                if (ldg.isDragon())
                {
                    this.dragonFaces++;
                }
            });
        }

        public bool doesTheDragonAttacks()
        {
            return this.dragonFaces >= 3;
        }

        public void takeOneDungeonDiceFromActualLevel(int dungeonDiceToTake)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region private

        private void initializeDicesVars()
        {
            this.numberDungeonDices = 7;
            this.availableDungeonDices = this.numberDungeonDices;
            this.levelDungeonDices = new List<EnemyDice>();
            this.dragonFaces = 0;
            this.goneDices = 0;
        }

        #endregion
    }
}
