using SnapsLibrary;

class WhatWouldIDo
{
    void WhatWouldI_Do(int input)
    {
        input = 99;
    }

    public void StartProgram()
    {
        int test = 0;
        WhatWouldI_Do(test);
        SnapsEngine.DisplayString("Test is: " + test);
    }
}
