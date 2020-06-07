using order.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataProvider
{
    public class GetAllOrder
    {
        public async Task<IEnumerable<OrderModel>> Get() =>
        await new SQLGetListAsync().ExecuteAsEnumerableAsync<OrderModel>("usp_odrmg_get_all_order_details");
    }
}
