using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataProvider
{
    public class UpdateCart
    {
        public async Task Update(List<SQLParam> sQLParams)
        {
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("usp_odrmg_update_cart_by_user", sQLParams);
        }
    }
}
