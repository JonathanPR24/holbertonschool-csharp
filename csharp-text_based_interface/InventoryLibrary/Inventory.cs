using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        // Required properties
        public string UserId { get; set; } // from User id
        public string ItemId { get; set; } // from Item id
        private int _quantity = 1; // Default value
        
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity cannot be less than 0.");
                }
                _quantity = value;
            }
        }

        // Constructor
        public Inventory(string userId, string itemId)
        {
            UserId = userId;
            ItemId = itemId;
        }
    }
}
