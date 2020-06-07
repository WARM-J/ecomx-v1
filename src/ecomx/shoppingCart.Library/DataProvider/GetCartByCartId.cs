using shoppingCart.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataProvider
{
    public class GetCartByCartId
    {
        public async Task<IEnumerable<CartModel>> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetListAsync().ExecuteAsEnumerableAsync<CartModel>("usp_odrmg_get_cart_by_cartId_by_user", sQLParams);
        }
    }
}
