using shoppingCart.Library.DataProvider;
using shoppingCart.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart.Library.DataController
{
    public class DUpdateCart
    {
        readonly UpdateCart _updateCart = new UpdateCart();
        public async Task Update(CartModel model)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@Quantity",model.Quantity)
            };
            await _updateCart.Update(sQLParams);
        }
    }
}
