using DungeonDice.Models;
using DungeonDice.Src.Writer;
using System;
using System.Globalization;

namespace DungeonDice.Src.Menus
{
    abstract class Menu
    {
        public int maxOption;

        protected Menu()
        {
            this.maxOption = 0;
        }

        public MenuOptions Run()
        {
            this.startShowingMenu();

            int selectedOption = this.checkOptions();

            this.finishingShowingMenu();
            return this.parseOption(selectedOption);
        }

        public int checkOptions()
        {
            int option = -1;
            while (option == -1)
            {
                while ((option = this.parseInt(Console.ReadLine())) == -1)
                {
                    //This has to be an empty loop because I only check if
                    //the data introduced by the user is correct or not
                }

                if (!this.validOption(option))
                {
                    Console.WriteLine("Option Incorrecta\n");
                    this.showOptions();
                    option = -1;
                }
            }

            return option;
        }

        public int parseInt(string stringValue)
        {
            try
            {
                return int.Parse(stringValue, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
            }
            catch (Exception)
            {
                Console.WriteLine("Numero no valido\n");
            }

            return -1;
        }

        public abstract void showOptions();

        public abstract MenuOptions parseOption(int selectedOption);

        private bool validOption(int option)
        {
            return 0 < option && option <= this.maxOption;
        }

        private void startShowingMenu()
        {
            WriterAssistant.setMenuColor();
            WriterAssistant.writeLine(1);
            this.showOptions();
            WriterAssistant.setDefaultColor();
        }

        private void finishingShowingMenu()
        {
            WriterAssistant.setMenuColor();
            WriterAssistant.writeLine(2);
            WriterAssistant.setDefaultColor();
        }
    }
}
