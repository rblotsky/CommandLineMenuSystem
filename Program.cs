using System;

namespace CommandLineMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates menu
            MenuOption[] menuOptions = new MenuOption[0]{
            };

            MenuGenerator.RunMenu(menuOptions, "CMD Programs Menu");
        }
    }
}