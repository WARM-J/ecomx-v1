using System;
using System.Collections.Generic;
using System.Text;

namespace order.Library.Entity.Model
{
    public class ServerSideOrderDetailModel
    {
        public int OrderDetailId { get; set; }
        public string OrderNumber { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string DeliveryInstruction { get; set; }
        public string UserId { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
