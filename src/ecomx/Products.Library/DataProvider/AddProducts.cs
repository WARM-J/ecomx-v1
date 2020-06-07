using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataProvider
{
    public class AddProducts
    {
        public async Task Create(List<SQLParam> sQLParams) =>
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("[dbo].[usp_Products_Add_Product]", sQLParams);
    }
}
