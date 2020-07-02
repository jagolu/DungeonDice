using DungeonDice.Models.Prizes;

namespace DungeonDice.Src.Util
{
    static class CheckPrizeType
    {
        public static bool isArcaneProtal(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new ArcanePortal());
        }

        public static bool isDragonEgg(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new DragonEgg());
        }

        public static bool isMagicFlute(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new MagicFlute());
        }

        public static bool isMagicRing(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new MagicRing());
        }

        public static bool isManaPotion(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new ManaPotion());
        }

        public static bool isEmeraldSword(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new EmeraldSword());
        }

        public static bool isForbiddenScroll(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new ForbiddenScroll());
        }

        public static bool isLightKnife(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new LightKnife());
        }

        public static bool isMagicTalisman(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new MagicTalisman());
        }

        public static bool isSnakeScepter(Prize p)
        {
            return CheckType.isEqualTypePrize(p, new SnakeScepter());
        }
    }
}
