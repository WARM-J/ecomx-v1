using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataProvider
{
    public class UpdateProducts
    {
        public async Task Update(List<SQLParam> sQLParams)
        {
             await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("[dbo].[usp_Products_Update_Product]", sQLParams);
        }
    }
}
