using shoppingCart.Library.DataProvider;
using SQLHelper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataController
{
    public class DUpdateIsPlacedOrderInCart
    {
        readonly UpdatePlacedOrderInCart _updateCart = new UpdatePlacedOrderInCart();
        public async Task Update(string userId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                 new SQLParam("@UserId",userId),
                new SQLParam("@IsOrderPlaced","True")
            };
            await _updateCart.Update(sQLParams);
        }
    }
}
