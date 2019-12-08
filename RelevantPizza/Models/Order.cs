using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RelevantPizza.Models
{
    public enum OrderType
    {
        Delivery,
        Takeout
    }
    public class Order
    {
        public int ID { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public OrderType OrderType { get; set; }
        public Employee Driver { get; set; }
        public DateTime DriverOut { get; set; }
        public DateTime DriverIn { get; set; }

        [Required]
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
