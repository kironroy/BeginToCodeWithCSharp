using SnapsLibrary;

class Ch04_02_ReadingAString
{
    public void StartProgram()
    {
        // variables

        string guestName;
        string age;

        // output

        guestName = SnapsEngine.ReadString("What is your name");
        SnapsEngine.DisplayString(guestName);
        
        age = SnapsEngine.ReadString("What is your age");
        SnapsEngine.DisplayString(age );

        SnapsEngine.AddLineToTextDisplay("Hello " + guestName + " you are " + age + " years old");

    }
}
