using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineMenu
{
    public static class MenuGenerator
    {
        public static void RunMenu(MenuOption[] options, string menuName, QuitParameter menuQuitParameter)
        {
            // Creates dictionaries of menu options for sorting
            Dictionary<string, MenuOption> menuOptionTable = new Dictionary<string, MenuOption>();

            for (int id = 0; id < options.Length; id++)
            {
                menuOptionTable.Add(options[id].optionName, options[id]);
            }

            // Displays Menu
            Console.Clear();
            Console.WriteLine("----[" + menuName + "]----");
            for (int id = 0; id < options.Length; id++)
            {
                Console.WriteLine("> (" + id + ") " + options[id].optionName);
            }

            MenuOption selectedOption;

            // Reads input, loops until valid input
            while (true)
            {
                Console.WriteLine("\nInput: ");
                string input = Console.ReadLine().ToLower();

                int inputAsID;
                if (int.TryParse(input, out inputAsID))
                {
                    if (inputAsID >= 0 && inputAsID < options.Length)
                    {
                        selectedOption = options[inputAsID];
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                }

                else
                {
                    if (menuOptionTable.TryGetValue(input, out selectedOption))
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                }
            }

            // Runs selected option
            string output = selectedOption.RunOption();
            Console.Write("--[OUTPUT]--\n" + output);
            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();
        }

    }
}

