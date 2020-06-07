using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace order.Library.Entity.Model
{
    public class OrderModel
    {
        public string OrderNumber { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        public string DeliveryInstruction { get; set; }
        public string UserId { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
