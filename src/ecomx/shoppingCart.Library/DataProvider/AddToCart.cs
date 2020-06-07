using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataProvider
{
    public class AddToCart
    {
        public async Task Create(List<SQLParam> sQLParams) =>
           await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("usp_odrmg_add_to_cart_by_user", sQLParams);
    }
}
