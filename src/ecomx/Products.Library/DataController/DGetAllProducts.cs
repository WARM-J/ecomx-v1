using Products.Library.DataProvider;
using Products.Library.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataController
{
    public class DGetAllProducts
    {
        readonly GetAllProducts _getAllProducts = new GetAllProducts();
        public async Task<IEnumerable<ProductsInfo>> AllProducts()
        {
            return await _getAllProducts.Get();
        }
    }
}
