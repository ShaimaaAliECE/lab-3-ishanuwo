using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Define a class called Coin, which inherits from Treasure
    public class Coin : Treasure
    {
        // Private field to hold the value of the coin
        private int value;

        // Constructor to initialize the description, score, and value using base constructor from Treasure
        public Coin(string description, int score, int value) : base(description, score)
        {
            this.value = value;
        }

        // Method to update the total value on the board
        public void UpdateTotalValue()
        {
            // Add the value of this coin to the total value on the board
            Board.TotalValue += value;
        }

        // Override the Display method from the base class Collectable
        public override void Display()
        {
            // Print a message
            Console.WriteLine("Coin " + description + " is displayed");
        }

        // Override the AddMe method from the base class Collectable
        public override void AddMe(List<Collectable> collectables)
        {
            // Call the AddMe method from the base class
            base.AddMe(collectables);
            // Update the total value
            UpdateTotalValue();
        }
    }
}
