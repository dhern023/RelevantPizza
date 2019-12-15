using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelevantPizza.Models
{
    public enum OrderItemType
    {
        Pizza,
        Drink,
        Wings,
        Sandwiches,
        Bread,
        Chicken
    }
    public class OrderItem
    {
        public int ID { get; set; }
        public OrderItemType Type { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<InventoryItem> OrderItemDetails { get; set; }
    }
}
