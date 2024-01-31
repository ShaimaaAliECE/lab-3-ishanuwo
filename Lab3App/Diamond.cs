using System;

namespace Lab3App
{
    // Define a class called Diamond, which inherits from Treasure
    public class Diamond : Treasure
    {
        // Constructor to initialize the description and score using base constructor from Treasure
        public Diamond(string description, int score) : base(description, score) { }

        // Override the Display method from the base class Collectable
        public override void Display()
        {
            // Print a message
            Console.WriteLine("Diamond " + description + " is displayed");
        }
    }
}
