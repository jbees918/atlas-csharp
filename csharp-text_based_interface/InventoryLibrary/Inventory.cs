using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            if (user_id != null && item_id != null)
            {
                this.UserId = user_id;
                this.ItemId = item_id;
                this.Quantity = quantity;
            }
        }

        public string ItemId { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
