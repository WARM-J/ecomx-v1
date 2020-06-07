using order.Library.DataProvider;
using order.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataController
{
    public class DGetOrderDetail
    {
        readonly GetOrderDetail _getOrdersDetails = new GetOrderDetail();
        public async Task<IEnumerable<ServerSideOrderDetailModel>> OrderDetailsById(string orderNumber)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@OrderNumber",orderNumber)
            };
            return await _getOrdersDetails.Get(sQLParams);

        }
    }
}
