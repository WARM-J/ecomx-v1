using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingCart.Library.Entity.Model
{
    public class CartModel
    {
        public int CartId { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DataCreated { get; set; }
    }
}
