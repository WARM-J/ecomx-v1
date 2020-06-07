using order.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataProvider
{
    public class GetOrderByUserId
    {
        public async Task<IEnumerable<OrderModel>> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetListAsync().ExecuteAsEnumerableAsync<OrderModel>("usp_odrmg_get_order_by_userId", sQLParams);
        }
    }
}
