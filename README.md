# CommandLineMenuSystem
A simple but flexible command-line menu system in C# using abstract classes for menu options.

**Last Updated:** January 2021

## How To Use
1. Copy the files `MenuGenerator.cs`, `MenuOptionBase.cs`, `QuitParameter.cs` into your project.
2. All new menu options should inherit from MenuOptionBase.cs, and override the abstract functions to implement whatever functionality is desired.
3. If the menu option needs to close the original menu, have it set `QuitParameter.quit` to true (using the quitParameter instance passed as an argument).
4. To run the menu:

   a. Make an array of menu options
   
   b. Create a QuitParameter instance (this will designate when the menu should be exited)
   
   c. Use `MenuGenerator.RunMenu` to write a new menu to the screen. If you want to return to the menu after running an option, put it in a loop until `QuitParameter.quit` is set to true.
  
