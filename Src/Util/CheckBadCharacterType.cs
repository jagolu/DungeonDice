using DungeonDice.Models.Characters;

namespace DungeonDice.Src.Util
{
    static class CheckBadCharacterType
    {
        public static bool isChest(Character bc)
        {
            return CheckType.isEqualTypeCharacter(bc, new Chest());
        }
        public static bool isDragon(Character bc)
        {
            return CheckType.isEqualTypeCharacter(bc, new Dragon());
        }
        public static bool isPotion(Character bc)
        {
            return CheckType.isEqualTypeCharacter(bc, new Potion());
        }
        public static bool isSkeleton(Character bc)
        {
            return CheckType.isEqualTypeCharacter(bc, new Skeleton());
        }
        public static bool isSwampCreature(Character bc)
        {
            return CheckType.isEqualTypeCharacter(bc, new SwampCreature());
        }
        public static bool isZombie(Character bc)
        {
            return CheckType.isEqualTypeCharacter(bc, new Zombie());
        }
    }
}
