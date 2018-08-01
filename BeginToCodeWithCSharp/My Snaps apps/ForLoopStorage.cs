using SnapsLibrary;

class ForLoopStorage
{
    public void StartProgram()
    {
        int[] sales = new int[10];
        for (int count = 0; count < 10; count += 1)
        {
            int displayCount = count + 1;
            sales[count] = SnapsEngine.ReadInteger("Enter the sales value " + 
                displayCount);
        }
    }
}
