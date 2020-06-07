using shoppingCart.Library.Entity.Model;
using SQLHelper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataProvider
{
    public class GetCartByUserId
    {
        public async Task<IEnumerable<CartModel>> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetListAsync().ExecuteAsEnumerableAsync<CartModel>("usp_odrmg_get_cart_by_userId_by_user", sQLParams);
        }
    }
}
