using System;

namespace InventoryLibrary
{
    public class BaseClass
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        // Constructor
        public BaseClass()
        {
            Id = Guid.NewGuid().ToString(); // Generate a unique ID
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
        }
    }
}
