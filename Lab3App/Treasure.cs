using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Define an abstract class called Treasure, which inherits from Collectable
    public abstract class Treasure : Collectable
    {
        // Private field to hold the score of the treasure
        private int score;

        // Constructor to initialize the description and score using base constructor from Collectable
        public Treasure(string description, int score) : base(description)
        {
            this.score = score;
        }

        // Method to update the total score on the board
        public void UpdateTotalScore()
        {
            // Add the score of this treasure to the total score on the board
            Board.TotalScore += score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        // Override the AddMe method from the base class Collectable
        public override void AddMe(List<Collectable> collectables)
        {
            // Call the AddMe method from the base class
            base.AddMe(collectables);
            // Print a message
            Console.WriteLine(description + " Collected, Congrats!!!!");
            // Update the total score
            UpdateTotalScore();
        }
    }
}
