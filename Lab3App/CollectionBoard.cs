using System;
namespace Lab3App
{
    // Define a public class called CollectionBoard
    public class CollectionBoard
    {
        // Private fields to hold total score and total value
        private int totalScore;
        private int totalValue;

        // Public property TotalScore to access and modify the total score field
        public int TotalScore
        {
            get { return totalScore; }  // Getter returns the value of totalScore
            set { totalScore = value; } // Setter sets the value of totalScore
        }

        // Public property TotalValue to access and modify the total value field
        public int TotalValue
        {
            get { return totalValue; }  // Getter returns the value of totalValue
            set { totalValue = value; } // Setter sets the value of totalValue
        }
    }
}
