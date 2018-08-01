using SnapsLibrary;

class Alert
{
    void Alerts(string message)
    {
        SnapsEngine.DisplayString(message);
        SnapsEngine.SpeakString(message);
    }

    public void StartProgram()
    {
        Alerts("Reactor going critical.");
    }
}
