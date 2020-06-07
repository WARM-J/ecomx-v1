using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataProvider
{
    public class DeleteProducts
    {
        public async Task Delete(List<SQLParam> sQLParams) =>
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("[dbo].[usp_Products_Delete_Product]", sQLParams);
    }
}
