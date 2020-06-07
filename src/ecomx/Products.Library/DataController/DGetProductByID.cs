using Products.Library.DataProvider;
using Products.Library.Entity.Models;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataController
{
    public class DGetProductByID
    {
        readonly GetProductsByID _getProductsByID = new GetProductsByID();
        public async Task<ProductsInfo> GetProductsId(int productID)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@ProductID",productID)
            };
            return await _getProductsByID.Get(sQLParams);

        }
    }
}
