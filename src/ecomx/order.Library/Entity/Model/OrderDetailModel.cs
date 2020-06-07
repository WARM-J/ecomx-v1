using System;
using System.Collections.Generic;
using System.Text;

namespace order.Library.Entity.Model
{
    public class OrderDetailModel
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
    }
}
