using order.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataProvider
{
    public class GetOrderDetail
    {
        public async Task<IEnumerable<ServerSideOrderDetailModel>> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetListAsync().ExecuteAsEnumerableAsync<ServerSideOrderDetailModel>("usp_odrmg_get_orders_details_by_order", sQLParams);
        }
    }
}
