using Products.Library.Entity.Models;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataProvider
{
    public class GetProductsByID
    {
        public async Task<ProductsInfo> Get(List<SQLParam> sQLParams)
        {
             return await new SQLGetAsync().ExecuteAsObjectAsync<ProductsInfo>("[dbo].[usp_Products_GetProduct_By_ProductID]", sQLParams);
        }
           
    }
}
