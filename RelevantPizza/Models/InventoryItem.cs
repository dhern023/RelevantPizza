using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelevantPizza.Models
{
    public enum InventoryItemType
    {
        Flavor,
        Size,
        Topping,
        Sauce,
        Cheese,
        Dough
    }
    public class InventoryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public InventoryItemType Type { get; set; }
        public int QuantityRemaining { get; set; }
        public decimal PricePerUnit { get; set; }
    }
}
