using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataProvider
{
   public class RemoveCartProduct
    {
        public async Task Remove(List<SQLParam> sQLParams) =>
        await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("usp_odrmg_delete_product_by_cartId_by_user", sQLParams);
    }
}
