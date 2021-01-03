using System;

namespace CommandLineMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates menu
            MenuOption[] menuOptions = new MenuOption[1]{
                new QuitOption("Quit");
            };

            // Creates quit parameter
            QuitParameter quitMenu = new QuitParameter();

            while (!quitMenu.quit)
            {
                MenuGenerator.RunMenu(menuOptions, "Example Menu", quitMenu);
            }
        }
    }
}
