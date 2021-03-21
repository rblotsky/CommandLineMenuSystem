# CommandLineMenuSystem
A very simple but flexible command-line menu system 

How To Use
-
1. Copy the files `MenuGenerator.cs`, `MenuOptionBase.cs`, `QuitParameter.cs` into your project. (Just copying the code works fine as well)
2. All new menu options should inherit from MenuOptionBase.cs, and override the abstract functions to implement whatever functionality is desired.
3. If the menu option needs to close the original menu, have it set `QuitParameter.quit` to true (using the parameter passed as an argument).
4. To run the menu:
  a. Make an array of menu options
  b. Create a QuitParameter instance (this will designate when the menu should be exited)
  c. Use `MenuGenerator.RunMenu` to write a new menu to the screen. If you want to return to the menu after running an option, put it in a loop until `QuitParameter.quit` is set to true.
  
