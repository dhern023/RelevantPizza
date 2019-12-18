using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelevantPizza.Models
{
    public enum InventoryItemType
    {
        Flavor = 1,
        Size = 2,
        Topping = 3,
        Sauce = 4,
        Cheese = 5,
        Dough= 6
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
