using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataProvider
{
    public class CreateOrderDetail
    {
        public async Task Create(List<SQLParam> sQLParams) =>
          await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("usp_odrmg_create_order_details", sQLParams);
    }
}
