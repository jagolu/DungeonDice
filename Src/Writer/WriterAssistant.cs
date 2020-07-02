using System;

namespace DungeonDice.Src.Writer
{
    static class WriterAssistant
    {
        public static void writeLine(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("-------------------------");
            }
        }

        public static void setMenuColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void setDefaultColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
