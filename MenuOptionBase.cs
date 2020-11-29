namespace CommandLineMenu
{
    public abstract class MenuOption
    {
        public string optionName;
        public abstract string RunOption(QuitParameter menuQuitParameter);
    }

    public class QuitOption : MenuOption
    {
        public override string RunOption(QuitParameter menuQuitParameter)
        {
            menuQuitParameter.quit = true;
            return "Application Closed.";
        }

        public QuitOption(string name) => optionName = name;
    }
}