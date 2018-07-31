using SnapsLibrary;

class TryStuff
{
    public void StartProgram()
    {
        /*int count = 0;
        while (count < 10)
        {
            SnapsEngine.SpeakString("Welcome to the world of Snaps");
            count += 1;

        }*/

        int age;
        do
        {
            age = SnapsEngine.ReadInteger("Enter your age");

        } while (age < 1 || age > 100);

    }
}
