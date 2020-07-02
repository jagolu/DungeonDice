namespace DungeonDice.Models.Characters.BadCharacters
{
    class DefaultEnemy : BadCharacter
    {
        public DefaultEnemy(): base()
        {
            this.name = "Default enemy";
            this.color = Color.WHITE;
        }
    }
}
