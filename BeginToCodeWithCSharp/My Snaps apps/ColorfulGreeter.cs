using SnapsLibrary;

class ColorfulGreeter
{
    public void StartProgram()
    {
        string name;
        string errorMessage = "Please enter your name";
        name = SnapsEngine.ReadString("What is your name");

        string upperCaseName = name.ToUpper();
        if (upperCaseName == "")
        {
            SnapsEngine.DisplayString(errorMessage);
            SnapsEngine.ReadString("What is your name");
            string dayOfWeek = SnapsEngine.GetDayOfWeekName();
            string fullMessage = "Hello " + upperCaseName + " Hope you are having a great " + dayOfWeek;
            SnapsEngine.SetTextColor(SnapsColor.Blue);
            SnapsEngine.DisplayString(fullMessage);

        }

        else 
        {
            string dayOfWeek = SnapsEngine.GetDayOfWeekName();
            string fullMessage = "Hello " + upperCaseName + " Hope you are having a great " + dayOfWeek;
            SnapsEngine.SetTextColor(SnapsColor.Blue);
            SnapsEngine.DisplayString(fullMessage);
        }
    
    }
}
