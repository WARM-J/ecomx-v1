using shoppingCart.Library.DataProvider;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataController
{
    public class DAddToCart
    {
        readonly AddToCart _addTOCart = new AddToCart();
        public async Task Create(int productId, string userId, int quantity)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@UserId",userId),
                new SQLParam("@ProductId",productId),
                new SQLParam("@Quantity",quantity),
                new SQLParam("@DataCreated",DateTime.Now),
                 new SQLParam("@IsOrderPlaced","False")
            };
            await _addTOCart.Create(sQLParams);
        }
    }
}
