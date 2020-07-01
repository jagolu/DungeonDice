using DungeonDice.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DungeonDice.Src
{
    abstract class Menu
    {
        public List<int> options;

        protected Menu()
        {
            this.options = new List<int>();
        }

        public MenuOptions Run()
        {
            this.showOptions();
            int selectedOption = this.checkOptions();

            return this.parseOption(selectedOption);
        }

        public int checkOptions()
        {
            int option = -1;
            while (option == -1)
            {
                while ((option = this.parseInt(Console.ReadLine())) == -1) ;
                option = this.options.Any(p => p == option) ? option : -1;
                if (!this.options.Any(p => p==option))
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
                this.showOptions();
            }

            return -1;
        }

        public abstract void showOptions();

        public abstract MenuOptions parseOption(int selectedOption);
    }
}
