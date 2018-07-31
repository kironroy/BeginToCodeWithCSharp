using SnapsLibrary;

class TalkingTimesTables
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Talking Times Tables");

        //while (true)
        //{

            int count = 1;

            int timesValue = 2;

            while (count < 5)
            {
                int result = count * timesValue;

                string message = count.ToString() +
                    " times " + timesValue.ToString() +
                    " is " + result.ToString();

                SnapsEngine.DisplayString(message);
                SnapsEngine.SpeakString(message);

                count += 1;
            }
        //}
    }
}
