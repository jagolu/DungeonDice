using System;

namespace DungeonDice.Models.Prizes
{
    class DragonEgg : Prize
    {
        public DragonEgg() : base()
        {
            this.name = "Dragon egg";
            this.explanation = "At the end of the game, this worth by 2 points";
        }

        public override void use()
        {
            throw new NotImplementedException();
        }
    }
}
