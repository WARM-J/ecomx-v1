using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataProvider
{
    public class GetTotalPrice
    {
        public async Task<decimal> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsScalarAsync<decimal>("usp_odrmg_get_total", sQLParams);
        }
    }
}
