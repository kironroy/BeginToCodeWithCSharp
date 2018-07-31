using SnapsLibrary;

class NightImage
{
    public void StartProgram()

    {
        SnapsEngine.SetTextColor(SnapsColor.Yellow);

        string url = "https://kironroy.github.io/images/fulls/09.jpg";
        bool displayedOK = SnapsEngine.DisplayImageFromUrl(imageURL: url);
        SnapsEngine.DisplayString("School Buses");
        SnapsEngine.SpeakString("School Buses");
        if (displayedOK == false)
        {
            SnapsEngine.DisplayString("Please check your connection");
        }

        SnapsEngine.Delay(0.2);

        string url2 = "https://kironroy.github.io/images/fulls/08.jpg";
        bool displayedOK2 = SnapsEngine.DisplayImageFromUrl(imageURL: url2);
        SnapsEngine.DisplayString("Bathroom, late night");
        SnapsEngine.SpeakString("Bathroom, late night");
       

        SnapsEngine.Delay(0.2);

        string url3 = "https://kironroy.github.io/images/fulls/07.jpg";
        bool displayedOK3 = SnapsEngine.DisplayImageFromUrl(imageURL: url3);
        SnapsEngine.DisplayString("Church");
        SnapsEngine.SpeakString("Church");


        

    }
}

