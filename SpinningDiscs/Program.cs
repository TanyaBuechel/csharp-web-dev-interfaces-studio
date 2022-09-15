using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD myCD = new CD("Whitney Houston", 650, "Music", "CD", true);
            DVD myDVD = new DVD("Spider-Man", 4700, "Movie", "DVD", true);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            myCD.SpinDisc();
            myDVD.SpinDisc();
        }
    }
}
