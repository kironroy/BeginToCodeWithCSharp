using SnapsLibrary;

class TryStuff
{
    public void StartProgram()
    {
        /*int count = 1;
        while (count < 5)
        {
            SnapsEngine.DisplayString("Welcome to the world of Snaps");
            SnapsEngine.SpeakString("Welcome to the world of Snaps");
            count += 1;
        }
        
        
        int age;
        do
        {
            age = SnapsEngine.ReadInteger("Enter your age");

        } while (age < 1 || age > 100); */

        for (int i = 10; i > -1; i--)
        {
            if (i == -1) // the counter will not say -1!
                break;
            SnapsEngine.DisplayString(i.ToString());
            SnapsEngine.SpeakString(i.ToString());
            

        }
        string url = "ms-appx:///Images/LA.jpg";
        SnapsEngine.DisplayImageFromUrl(imageURL: url);

    }
}

// add everything to GitHub!