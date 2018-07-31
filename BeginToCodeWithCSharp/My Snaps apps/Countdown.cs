using SnapsLibrary;

public class Countdown
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("The Final countdown:");


        for (int taskNumber = 1; taskNumber <= 3; taskNumber++)
        {
            SnapsEngine.SetBackgroundColor(red:42,green:82,blue:190);
            SnapsEngine.SetTextColor(SnapsColor.White);
            SnapsEngine.SetTitleColor(SnapsColor.Yellow);
            SnapsEngine.Delay(0.5);
            SnapsEngine.AddLineToTextDisplay(taskNumber.ToString() + "." + " Final Countdown!");
            SnapsEngine.Delay(0.5);
            SnapsEngine.SpeakString("Final Countdown!");
        }

    }
}


