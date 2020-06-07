using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataProvider
{
    public class UpdatePlacedOrderInCart
    {
        public async Task Update(List<SQLParam> sQLParams)
        {
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("usp_odrmg_update_is_placed_order_in__cart", sQLParams);
        }
    }
}
