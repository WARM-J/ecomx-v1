using order.Library.DataProvider;
using order.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataController
{
    public class DGetOrderByUserId
    {
        readonly GetOrderByUserId _getOrder = new GetOrderByUserId();
        public async Task<IEnumerable<OrderModel>> OrderByUserId(string userId)
        {
            List<SQLParam> SQlParams = new List<SQLParam>()
            {
                new SQLParam("@UserId",userId)
            };
            return await _getOrder.Get(SQlParams);
        }
    }
}
