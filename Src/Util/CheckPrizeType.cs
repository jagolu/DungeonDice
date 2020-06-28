using DungeonDice.Models.Prizes;

namespace DungeonDice.Src.Util
{
    static class CheckPrizeType
    {
        public static bool isArcaneProtal(Prize p)
        {
            return isEqualType(p, new ArcanePortal());
        }

        public static bool isDragonEgg(Prize p)
        {
            return isEqualType(p, new DragonEgg());
        }

        public static bool isMagicFlute(Prize p)
        {
            return isEqualType(p, new MagicFlute());
        }

        public static bool isMagicRing(Prize p)
        {
            return isEqualType(p, new MagicRing());
        }

        public static bool isManaPotion(Prize p)
        {
            return isEqualType(p, new ManaPotion());
        }

        public static bool isEmeraldSword(Prize p)
        {
            return isEqualType(p, new EmeraldSword());
        }

        public static bool isForbiddenScroll(Prize p)
        {
            return isEqualType(p, new ForbiddenScroll());
        }

        public static bool isLightKnife(Prize p)
        {
            return isEqualType(p, new LightKnife());
        }

        public static bool isMagicTalisman(Prize p)
        {
            return isEqualType(p, new MagicTalisman());
        }

        public static bool isSnakeScepter(Prize p)
        {
            return isEqualType(p, new SnakeScepter());
        }

        private static bool isEqualType(Prize p1, Prize p2)
        {
            return p1.GetType() == p2.GetType();
        }
    }
}
