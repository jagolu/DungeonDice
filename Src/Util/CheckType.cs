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

        public static bool isEqualTypeCharacter(Character bc1, Character bc2)
        {
            return bc1.GetType() == bc2.GetType();
        }
    }
}
