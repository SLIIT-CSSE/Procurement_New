using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Procurment.Models
{
    public class OrderItem
    {
        [Key]
        public string OrderItemId { get; set; }
        public string OrderId { get; set; }
        public string ItemId { get; set; }
        public int quantity { get; set; }

    }
}