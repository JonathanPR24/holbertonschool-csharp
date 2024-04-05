using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        // Required properties
        public string Name { get; set; }

        // Optional properties
        public string Description { get; set; }
        public float? Price { get; set; } // Nullable float to allow null
        public List<string> Tags { get; set; }

        // Constructor
        public Item(string name)
        {
            Name = name;
            Tags = new List<string>();
        }
    }
}
