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

            // Creates quit parameter
            QuitParameter quitMenu = new QuitParameter();

            while (!quitMenu.quit)
            {
                MenuGenerator.RunMenu(menuOptions, "CMD Programs Menu", quitMenu);
            }
        }
    }
}