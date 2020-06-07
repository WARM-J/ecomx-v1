using Products.Library.DataProvider;
using Products.Library.Entity.Models;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataController
{
    public class DUpdataProducts
    {
        readonly UpdateProducts _updateProducts = new UpdateProducts();
        public async Task Update(ProductsInfo productsInfo)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@ProductName",productsInfo.ProductName),
                new SQLParam("@ImageUrl",productsInfo.ImageUrl),
                new SQLParam("@Rating",productsInfo.Rating),
                new SQLParam("@Brand",productsInfo.Brand),
                new SQLParam("@MRP",productsInfo.MRP),
                new SQLParam("@Price",productsInfo.Price),
                new SQLParam("@Quantity",productsInfo.Quantity)
            };
            await _updateProducts.Update(sQLParams);
        }
    }
}
