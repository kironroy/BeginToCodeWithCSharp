using SnapsLibrary;

class HandleRiverCruise
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Super Funfair Rides");
        string ride;
        ride = SnapsEngine.SelectFrom5Buttons(
            "Scenic River Cruise",
            "Carnival Carousel",
            "Jungle Adventure Water Splash",
            "Downhill Mountain Run",
            "The Regurgitator");

        SnapsEngine.SetTitleString(ride);

        if (ride == "Scenic River Cruise")
        {
            SnapsEngine.DisplayString("There are no age restrictions on this ride. Enjoy.");
        }

        else
        {
            // These rides have age restrictions - read the age

            int ageInt = SnapsEngine.ReadInteger("What is your age");

            SnapsEngine.DisplayString("You are " + ageInt + " years old");

            // carnival carousel

            if (ride == "Carnival Carousel")
            {
                if (ageInt >= 3)
                    SnapsEngine.DisplayString("You can go on the ride.");
            }
            else
                SnapsEngine.DisplayString("You CANNOT go on the ride.");

            // jungle 

            if (ride == "Jungle Adventure Water Splash")
            {
                if (ageInt >= 3)
                    SnapsEngine.DisplayString("You can go on the ride.");
            }
            else
                SnapsEngine.DisplayString("You CANNOT go on the ride.");

            // regurgitator

            if (ride == "The Regurgitator")
            {
                if (ageInt <= 12)
                    SnapsEngine.DisplayString("I'm sorry, too young");
                {
                    if (ageInt > 70)
                    {
                        SnapsEngine.DisplayString("I'm sorry, too old");
                    }
                    
                }

            }
        }
    }
}
