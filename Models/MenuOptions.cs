namespace DungeonDice.Models
{
    enum MenuOptions
    { 
        FAIL = -1,
        //1001XX INITIAL MENU OPTIONS
        NEWGAME = 100101,
        LOADGAME = 100102,
        STATICS = 100103,
        QUIT = 100104,

        //1002XX HERO SELECTION MENU OPTIONS
        RANDOM_HERO = 100201,
        SELECT_HERO = 100202,
        HERO_SELECTION_BACK = 100203
    }
}
