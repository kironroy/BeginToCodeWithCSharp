using SnapsLibrary;

class Dice
{
    public void StartProgram()
    {
        /*int spotCount = SnapsEngine.ThrowDice();

        SnapsEngine.SetTitleString(spotCount.ToString());

        SnapsEngine.SpeakString("You have rolled a " + spotCount.ToString());
        */

        if (SnapsEngine.ThrowDice() < 4)
        {
            SnapsEngine.SpeakString("You will be rich");
        }
        else
        {
            SnapsEngine.SpeakString("You will remain poor");
        }
    }
}