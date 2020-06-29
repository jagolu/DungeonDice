namespace DungeonDice.Src.Prizes
{
    public class DungeonDiceGame
    {
    #region singleton
        private DungeonDiceGame() { }
        private static DungeonDiceGame _instance;

        public static DungeonDiceGame getInstance()
        {
            if(_instance == null)
            {
                _instance = new DungeonDiceGame();
            }
            return _instance;
        }
    #endregion
    }
}
