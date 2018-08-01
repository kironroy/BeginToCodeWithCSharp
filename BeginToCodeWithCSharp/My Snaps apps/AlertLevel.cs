using SnapsLibrary;

class AlertLevel
{
    void AlertLevels(string message, bool urgent)
    {
        SnapsEngine.DisplayString(message);
        SnapsEngine.SpeakString(message);

        if (urgent)
            SnapsEngine.PlaySoundEffect("ding");
        //SnapsEngine.DisplayString(message);
        //SnapsEngine.SpeakString(message);
    }

    public void StartProgram()
    {
        //AlertLevels(urgent: false, message: "Time for a coffee break.");
        AlertLevels(message: "Reactor going critical.", urgent: true);

        AlertLevels(urgent: false, message: "Donuts have arrived");
    }
}
