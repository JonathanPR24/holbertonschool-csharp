using System;

namespace InventoryLibrary
{
    public class User : BaseClass
    {
        // Required properties
        public string Name { get; set; }

        // Constructor
        public User(string name)
        {
            Name = name;
        }
    }
}
