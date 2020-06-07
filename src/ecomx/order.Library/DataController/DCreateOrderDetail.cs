using order.Library.DataProvider;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataController
{
    public class DCreateOrderDetail
    {
        readonly CreateOrderDetail _createOrderDetail = new CreateOrderDetail();
        public async Task Create(string userId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@UserId",userId)
                //new SQLParam("@OrderNumber",orderNumber)
            };
            await _createOrderDetail.Create(sQLParams);
        }
    }
}
