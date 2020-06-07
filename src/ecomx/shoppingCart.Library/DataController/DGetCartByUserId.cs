using shoppingCart.Library.DataProvider;
using shoppingCart.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataController
{
    public class DGetCartByUserId
    {
        readonly GetCartByUserId _getCart = new GetCartByUserId();
        public async Task<IEnumerable<CartModel>> CartByUserId(string userId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@UserId",userId)

            };
            return await _getCart.Get(sQLParams);
        }
    }
}
