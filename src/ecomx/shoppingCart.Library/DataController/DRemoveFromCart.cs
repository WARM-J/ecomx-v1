using shoppingCart.Library.DataProvider;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataController
{
    public class DRemoveFromCart
    {
        readonly RemoveCartProduct _removeCartProduct = new RemoveCartProduct();
        public async Task Remove(int cartId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@CartId",cartId)
            };
            await _removeCartProduct.Remove(sQLParams);
        }
    }
}
