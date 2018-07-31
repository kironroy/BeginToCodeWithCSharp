using SnapsLibrary;

class CityImage
{
    public void StartProgram()
    {
        string url = "ms-appx:///Images/LA.jpg";
        SnapsEngine.DisplayImageFromUrl(imageURL: url);
    }
}

