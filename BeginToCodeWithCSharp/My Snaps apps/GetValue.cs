using SnapsLibrary;

class GetValue
{
    int GetValues(string prompt, int min, int max)
    {
        int result;

        do
        {
            result = SnapsEngine.ReadInteger(prompt);
        } while (result < min || result > max);

        return result;
    }

    public void StartProgram()
    {
        int age = GetValues(prompt:"Enter your age in years", min:0, max:100);
        int height = GetValues(prompt:"Enter your height in inches", min:30, max:96);

        SnapsEngine.DisplayString("Age is: " + age);
        SnapsEngine.DisplayString("Height is: " + height);
    }
}
