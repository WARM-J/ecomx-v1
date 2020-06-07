using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Library.Entity.Models
{
    public class ProductsInfo
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Rating { get; set; }
        public string Brand { get; set; }
        public int MRP { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
