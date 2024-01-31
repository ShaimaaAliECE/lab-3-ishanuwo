using System;

namespace Lab3App
{
    // Define a class called Axe, which inherits from Tool
    public class Axe : Tool
    {
        // Constructor to initialize the description using base constructor from Tool
        public Axe(string description) : base(description) { }

        // Override the DoAction method from the base class
        public override void DoAction()
        {
            // Call the base class DoAction method
            base.DoAction();
            Console.WriteLine("Axe is Used");
        }

        // Override the Display method from the base class Collectable
        public override void Display()
        {
            // Print a message
            Console.WriteLine("Axe " + description + " is displayed");
        }
    }
}
