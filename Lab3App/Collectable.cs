using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Define an abstract class called Collectable which implements the Displayable interface
    public abstract class Collectable : Displayable
    {
        // Abstract method required by the Displayable interface, to be implemented by derived classes
        public abstract void Display();

        // Public field to hold description of the collectable
        public string description;

        // Public field to reference the CollectionBoard object
        public CollectionBoard Board;

        // Constructor to initialize the collectable's description
        public Collectable(string description)
        {
            this.description = description;
        }

        // Virtual method to add the collectable to a list of collectables
        public virtual void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
        }
    }
}
