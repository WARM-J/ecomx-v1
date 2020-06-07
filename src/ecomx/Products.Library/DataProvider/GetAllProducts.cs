using Products.Library.Entity.Models;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataProvider
{
    public class GetAllProducts
    {
        public async Task<IEnumerable<ProductsInfo>> Get() =>
           await new SQLGetListAsync().ExecuteAsEnumerableAsync<ProductsInfo>("[dbo].[usp_Products_GetAllProduct]");
    }
}
