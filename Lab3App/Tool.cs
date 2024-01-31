using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Define an abstract class called Tool, which inherits from Collectable
    public abstract class Tool : Collectable
    {
        // Constructor to initialize the description using base constructor from Collectable
        public Tool(string description) : base(description) { }

        // Virtual method to perform an action when the tool is collected
        public virtual void DoAction()
        {
            // Display a message indicating the tool has been collected
            Console.WriteLine(description + " Collected, Congrats!!!!");
        }

        // Override the AddMe method from the base class
        public override void AddMe(List<Collectable> collectables)
        {
            // Add the tool to the list of collectables
            collectables.Add(this);
            // Perform the action
            DoAction();
        }
    }
}
