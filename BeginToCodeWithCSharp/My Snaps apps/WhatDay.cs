using SnapsLibrary;

class SpeaktheDay
{
    public void StartProgram()
    {
        SnapsEngine.SetDisplayStringSize(20);

        string dayName;
        int hour;
        int minute;

        dayName = SnapsEngine.GetDayOfWeekName();
        hour = SnapsEngine.GetHourValue();
        minute = SnapsEngine.GetMinuteValue();
        string printDay = "Today is: " + dayName ;
        SnapsEngine.SpeakString(printDay);
        SnapsEngine.DisplayString(printDay + " " + hour + ":" + minute);
    }
}
