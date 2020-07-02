using DungeonDice.Models.Characters;
using DungeonDice.Models.Prizes;

namespace DungeonDice.Src.Util
{
    static class CheckType
    {
        public static bool isEqualTypePrize(Prize p1, Prize p2)
        {
            return p1.GetType() == p2.GetType();
        }
    }
}
