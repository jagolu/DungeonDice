﻿using DungeonDice.Models.Characters;

namespace DungeonDice.Models.Prizes
{
    class EmeraldSword : PrizeCharacter
    {
        public EmeraldSword() : base()
        {
            this.name = "Emerald Sword";
            this.explanation = "Use as a Fighter";
            this.character = new Fighter();
        }
    }
}
