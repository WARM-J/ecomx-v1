using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataProvider
{
    public class GetOrderTableCount
    {
        public async Task<int> Get()
        {
            return await new SQLGetAsync().ExecuteAsScalarAsync<int>("usp_odrmg_get_orderNo_count");
        }
    }
}
