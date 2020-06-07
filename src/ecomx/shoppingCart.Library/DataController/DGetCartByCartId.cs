using shoppingCart.Library.DataProvider;
using shoppingCart.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataController
{
    public class DGetCartByCartId
    {
        readonly GetCartByCartId _getCartByCartId = new GetCartByCartId();
        public async Task<IEnumerable<CartModel>> CartByCartId(int cartId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@CartId",cartId)

            };
            return await _getCartByCartId.Get(sQLParams);
        }
    }
}
