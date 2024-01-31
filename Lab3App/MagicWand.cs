using System;

namespace Lab3App
{
    // Define a class called MagicWand, which inherits from Tool
    public class MagicWand : Tool
    {
        // Constructor to initialize the description using base constructor from Tool
        public MagicWand(string description) : base(description) { }

        // Override the DoAction method from the base class
        public override void DoAction()
        {
            // Call the base class DoAction method
            base.DoAction();
            Console.WriteLine("MagicWand is Used");
        }

        // Override the Display method from the base class Collectable
        public override void Display()
        {
            // Print a message
            Console.WriteLine("MagicWand " + description + " is displayed");
        }
    }
}
