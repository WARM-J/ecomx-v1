using order.Library.DataProvider;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataController
{
    public class DGetTotalPrice
    {
        readonly GetTotalPrice _getOrderCount = new GetTotalPrice();
        public async Task<decimal> Get(string userId)
        {
            List<SQLParam> SQlParams = new List<SQLParam>()
            {
                new SQLParam("@UserId",userId)
            };
            return await _getOrderCount.Get(SQlParams);
        }
    }
}
